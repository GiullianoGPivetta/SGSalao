using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils.Drawing.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using SGCliente;
using SGCore.Utils;
using SGEntidades.Entidades;
using SGEntidades.Enum;
using SGGUIBase;
using SGServico.Servicos;

namespace SGAgenda
{
    public partial class frmDetalheAgenda : frmBase
    {

        private readonly ProfissionalServico _profissionalService = new ProfissionalServico();
        private readonly AgendaServico _agendaService = new AgendaServico();
        private readonly ServicoServico _ServicoService = new ServicoServico();
        private readonly List<Profissional> _profissionais;
        private bool _inicializando;
        private Cliente _cliente;
        private Agenda _agenda;

        private readonly DateTime _data;

        public frmDetalheAgenda()
        {
            InitializeComponent();

            _inicializando = true;

            _profissionais = _profissionalService.RecuperarParticipaAgenda();
            cboProfissional.Properties.DataSource = _profissionais;
            cboSituacao.Enabled = false;
        }

        public frmDetalheAgenda(Agenda agenda)
             : this()
        {

            _agenda = agenda;
            cboSituacao.Enabled = false;
            lblValor.Visible = true;
            lblValor.Text = string.Format("{0:c}", 0);

            cboProfissional.EditValue = agenda.Profissional.IdProfissional;
            cboProfissional.Properties.ForceInitialize();

            if (_agenda.IdAgenda != 0)
                InicializaEdicao();

            _inicializando = false;

            lblDataHoraAgenda.Text = string.Format("{0:dd/MM/yy} {1} - {2}", agenda.Data, agenda.HoraInicial.ToShortTimeString(), agenda.HoraFinal.ToShortTimeString());
            lblDataHoraAgenda.Visible = true;

            List<Servico> serv = _ServicoService.RecuperarListaPorProfissional((Profissional)cboProfissional.GetSelectedDataRow());

            if (_agenda.Servicos != null)
                if (_agenda.Servicos.Any())
                {
                    foreach (var servico in _agenda.Servicos)
                    {
                        if (serv.Any(x => x.IdServico == servico.IdServico))
                            serv.First(x => x.IdServico == servico.IdServico).Selecionado = true;

                    }

                    lblValor.Text = string.Format("{0:c}", (serv.Where(x => x.Selecionado)).Sum(y => y.Valor));
                }


            gcServicos.DataSource = serv;
            gcServicos.RefreshDataSource();
        }

        private void InicializaEdicao()
        {
            _cliente = _agenda.Cliente;
            bteCliente.Text = _cliente.Nome;
            cboSituacao.Enabled = true;
            cboSituacao.SelectedText = EnumUtils<SituacaoAgenda>.GetDescription(_agenda.Situacao);
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

            var list = gcServicos.DataSource as List<Servico>;

            List<Servico> servicos = new List<Servico>(list.Where(x => x.Selecionado).ToList());

            var tempo = servicos.Sum(x => x.Tempo);

            var agenda = new Agenda
            {
                Cliente = _cliente,
                Situacao = EnumUtils<SituacaoAgenda>.FromDescription(cboSituacao.Text),
                HoraInicial = _agenda.HoraInicial,
                HoraFinal = _agenda.HoraInicial.AddMinutes(tempo),
                Data = _agenda.Data,
                Complemento = txtComentario.Text,
                Profissional = (Profissional)cboProfissional.GetSelectedDataRow(),
                Servicos = servicos
            };

            if (_agenda.IdAgenda != 0)
            {
                agenda.IdAgenda = _agenda.IdAgenda;
                _agendaService.Editar(agenda);

                if (EnumUtils<SituacaoAgenda>.FromDescription(cboSituacao.Text) == SituacaoAgenda.Cancelada)
                {
                    var just = new frmCancelarAgenda();
                    if (just.ShowDialog() == DialogResult.Cancel) return;

                    AgendaOcorrencia ocorrencia = new AgendaOcorrencia
                    {
                        Agenda = _agenda,
                        DataHora = DateTime.Now,
                        Motivo = just.Justificativa
                    };

                    _agendaService.GravarAgendaOcorrencia(ocorrencia);
                }
            }
            else
                _agendaService.Inserir(agenda);


            DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool Validar()
        {
            dxError.ClearErrors();

            if (cboProfissional.EditValue == null)
                dxError.SetError(cboProfissional, "Deve ser Selecionado o Profissional da Agenda", ErrorType.Critical);

            if (string.IsNullOrEmpty(bteCliente.Text))
                dxError.SetError(bteCliente, "Deve ser Selecionado o Cliente da Agenda", ErrorType.Critical);

            if (gcServicos.DataSource == null || !((List<Servico>)gcServicos.DataSource).Any(x => x.Selecionado))
                dxError.SetError(bteCliente, "Devem ser selecionado os Serviços a serem realizados no Cliente", ErrorType.Critical);

            return !dxError.HasErrors;
        }

        private void bteCliente_ButtonClick(object sender, ButtonPressedEventArgs e)
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

        private void riSelecionado_CheckedChanged(object sender, EventArgs e)
        {
            var servs = gcServicos.DataSource as List<Servico>;

            if (servs != null)
                servs.First(x => x.IdServico == ((Servico)gvServicos.GetFocusedRow()).IdServico).Selecionado = ((CheckEdit)sender).Checked;

            if (servs != null && servs.Any(x => x.Selecionado))
            {
                lblDataHoraAgenda.Text = string.Format("{0:dd/MM/yy} {1} - {2}", _agenda.Data, _agenda.HoraInicial.ToShortTimeString(), _agenda.HoraInicial.AddMinutes((servs.Where(x => x.Selecionado)).Sum(y => y.Tempo)).ToShortTimeString());
                lblValor.Text = string.Format("{0:c}", (servs.Where(x => x.Selecionado)).Sum(y => y.Valor));
            }
            else
            {
                lblDataHoraAgenda.Text = string.Format("{0:dd/MM/yy} {1} - {2}", _agenda.Data, _agenda.HoraInicial.ToShortTimeString(), _agenda.HoraInicial.ToShortTimeString());
                lblValor.Text = string.Format("{0:c}", 0);
            }
        }
    }
}
