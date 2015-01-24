using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using DevExpress.Utils.Serializing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Forms;
using SGCliente;
using SGEntidades.DTO;
using SGEntidades.Entidades;
using SGEntidades.Enum;
using SGServico.Servicos;

namespace SGAgenda
{
    public partial class frmDetalheAgenda
    {

        private readonly ProfissionalServico _profissionalService = new ProfissionalServico();
        private readonly AgendaServico _agendaService = new AgendaServico();
        private readonly ServicoServico _ServicoService = new ServicoServico();
        private List<Profissional> _profissionais;
        private bool _inicializando;
        private Cliente _cliente;
        private Agenda _agenda;

        private readonly DateTime _data;

        public frmDetalheAgenda()
        {
            InitializeComponent();

            _inicializando = true;

            cboProfissional.Properties.DataSource = _profissionalService.RecuperarParticipaAgenda();
        }

        public frmDetalheAgenda(Profissional prof, DateTime time)
            : this()
        {
            _data = time;

            cboProfissional.EditValue = prof.IdProfissional;
            cboProfissional.Properties.ForceInitialize();
            _inicializando = false;
            lblDataHoraAgenda.Text = string.Format("{0:d} {1} -", time, time.ToShortTimeString());
            lblDataHoraAgenda.Visible = true;
            ConsultaProcedimentosProfissional();
        }

        public frmDetalheAgenda(Agenda agenda)
            : this()
        {
            cboProfissional.EditValue = agenda.Profissional.IdProfissional;
            cboProfissional.Properties.ForceInitialize();
            _cliente = agenda.Cliente;
            bteCliente.Text = _cliente.Nome;
            _inicializando = false;
            lblDataHoraAgenda.Text = string.Format("{0:d} {1} - {2}", agenda.Data, agenda.HoraInicial.ToShortTimeString(), agenda.HoraFinal.ToShortTimeString());
            lblDataHoraAgenda.Visible = true;
            var servicos = _ServicoService.RecuperarListaPorProfissional((Profissional)cboProfissional.GetSelectedDataRow());

            foreach (var serv in from serv in servicos from serv2 in agenda.Servicos.Where(serv2 => serv.IdServico == serv2.IdServico) select serv)
            {
                serv.Selecionado = true;
            }

            gcServicos.DataSource = servicos;
            gcServicos.RefreshDataSource();
        }


        private void ConsultaProcedimentosProfissional()
        {
            if (!_inicializando)
                gcServicos.DataSource =
                _ServicoService.RecuperarListaPorProfissional((Profissional)cboProfissional.GetSelectedDataRow());

            gcServicos.RefreshDataSource();
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            var servicos = ((List<ServicoSelecionado>)gcServicos.DataSource).Where(x => x.Selecionado = true);
            var tempo = servicos.Sum(x => x.Tempo);

            var agenda = new Agenda
            {
                Cliente = _cliente,
                Situacao = SituacaoAgenda.Aberta,
                HoraInicial = _data,
                HoraFinal = _data.AddMinutes(tempo),
                Data = _data.Date,
                Complemento = txtComentario.Text,
                Profissional = (Profissional)cboProfissional.GetSelectedDataRow()
            };

            _agendaService.Inserir(agenda);

            DialogResult = DialogResult.OK;

            this.Close();

        }

        private bool Validar()
        {
            dxError.ClearErrors();

            if (string.IsNullOrEmpty(cboProfissional.SelectedText))
                dxError.SetError(cboProfissional, "Deve ser Selecionado o Profissional da Agenda", ErrorType.Critical);

            if (string.IsNullOrEmpty(bteCliente.Text))
                dxError.SetError(bteCliente, "Deve ser Selecionado o Cliente da Agenda", ErrorType.Critical);

            if (((List<ServicoSelecionado>)gcServicos.DataSource).Any(x => x.Selecionado = true))
                dxError.SetError(lblServico, "Devem ser selecionado os Serviços a serem realizados no Cliente", ErrorType.Critical);

            return !dxError.HasErrors;
        }

        private void bteCliente_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var frm = new frmConsultaCliente(true);
            if (frm.ShowDialog() != DialogResult.OK) return;
            _cliente = frm._clienteSelecionado;
            bteCliente.Text = _cliente.Nome;
            bteCliente.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void frmDetalheAgenda_Load(object sender, EventArgs e)
        {
            _inicializando = false;
        }

        private void cboProfissional_EditValueChanged(object sender, EventArgs e)
        {
            ConsultaProcedimentosProfissional();
        }
    }
}
