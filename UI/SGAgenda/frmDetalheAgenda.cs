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
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Forms;
using SGCliente;
using SGEntidades.Entidades;
using SGEntidades.Enum;
using SGServico.Servicos;

namespace SGAgenda
{
    public partial class frmDetalheAgenda
    {

        private readonly ProfissionalServico _profissionalService = new ProfissionalServico();
        private readonly AgendaServico _agendaService = new AgendaServico();
        private readonly Profissional _profissional;
        private Cliente _cliente;

        public frmDetalheAgenda()
        {
            InitializeComponent();

            cboProfissional.Properties.DataSource = _profissionalService.RecuperarParticipaAgenda();

        }

        public frmDetalheAgenda(int prof, DateTime time)
            : this()
        {
            cboProfissional.EditValue = prof;
            dtInicio.Time = time;
            dtFim.Time = time.AddMinutes(30);
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            var agenda = new Agenda
            {
                Cliente = _cliente,
                Situacao = SituacaoAgenda.Aberta,
                HoraInicio = dtInicio.Time,
                HoraFim = dtFim.Time,
                Data = DateTime.Now,
                Complemento = txtComentario.Text,
                Profissional = (Profissional)cboProfissional.GetSelectedDataRow()
            };

            _agendaService.Inserir(agenda);

            DialogResult = DialogResult.OK;

            this.Close();

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
    }
}
