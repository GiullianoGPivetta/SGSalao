using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using SGAgenda.Properties;
using SGEntidades.Entidades;
using SGServico.Servicos;

namespace SGAgenda.usrControls
{
    public partial class uConsultaAgenda : UserControl
    {
        private readonly ProfissionalServico _profissionalService = new ProfissionalServico();
        private readonly AgendaServico _agendaServico = new AgendaServico();
        private List<Profissional> _recursos;

        public uConsultaAgenda()
        {
            InitializeComponent();



            RecuperarProfissionaisAgenda();
            MontaHorarios();
            schedulerAgenda.OptionsCustomization.AllowInplaceEditor = UsedAppointmentType.Custom;

        }

        private void MontaHorarios()
        {
            var agendas = _agendaServico.RecuperarLista(DateTime.Now.Date);
            schedulerAgendaStorage.Appointments.DataSource = agendas;
        }

        private void RecuperarProfissionaisAgenda()
        {
            _recursos = _profissionalService.RecuperarParticipaAgenda();
            schedulerAgendaStorage.Resources.DataSource = _recursos;
            schedulerAgenda.GroupType = SchedulerGroupType.Resource;
        }

        private void schedulerAgenda_Click(object sender, EventArgs e)
        {

        }

        private void btDia_Click(object sender, EventArgs e)
        {
            schedulerAgenda.ActiveViewType = SchedulerViewType.Day;
        }

        private void btSemana_Click(object sender, EventArgs e)
        {
            schedulerAgenda.ActiveViewType = SchedulerViewType.Week;
        }

        private void btMes_Click(object sender, EventArgs e)
        {
            schedulerAgenda.ActiveViewType = SchedulerViewType.Month;
        }

        private void schedulerAgenda_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            if (!_recursos.Any())
            {
                MessageBox.Show(Resources.ProfissionalAgenda, Resources.Atencao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            var prof = (int)schedulerAgenda.SelectedResource.Id;
            var time = schedulerAgenda.SelectedInterval.Start;

            var form = new frmDetalheAgenda(prof, time);
            if (form.ShowDialog() == DialogResult.OK)
                MontaHorarios();

            e.Handled = true;
        }
    }
}
