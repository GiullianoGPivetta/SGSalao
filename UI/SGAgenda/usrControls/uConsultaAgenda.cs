using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
using SGAgenda.Properties;
using SGEntidades.Entidades;
using SGEntidades.Enum;
using SGServico.Servicos;

namespace SGAgenda.usrControls
{
    public partial class uConsultaAgenda : UserControl
    {
        private readonly ProfissionalServico _profissionalService = new ProfissionalServico();
        private readonly AgendaServico _agendaServico = new AgendaServico();
        private List<Profissional> _recursos;
        private List<Agenda> _agendas;

        public uConsultaAgenda()
        {
            InitializeComponent();
        }

        private void MontaHorarios()
        {
            _agendas = _agendaServico.RecuperarLista(dateNavigator1.DateTime.Date);
            schedulerStorage.Appointments.DataSource = _agendas.Where(x => x.Situacao != SituacaoAgenda.Cancelada);

            var cont = _agendas.Count(x => x.Situacao == SituacaoAgenda.Cancelada);

            btOcorrencia.Text = string.Format("Ocorrências ({0})", cont);

            PintaAgenda();
        }

        private void PintaAgenda()
        {
        }

        private void RecuperarProfissionaisAgenda()
        {
            _recursos = _profissionalService.RecuperarParticipaAgenda();
            schedulerStorage.Resources.DataSource = _recursos;
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

            Agenda agenda;
            if (schedulerAgenda.SelectedAppointments.Count == 1)
            {
                agenda = _agendas.First(x => x.IdAgenda == ((Agenda)schedulerAgenda.SelectedAppointments[0].GetRow(schedulerStorage)).IdAgenda);
            }
            else
            {
                agenda = new Agenda
                {
                    Profissional = _recursos.First(x => x.IdProfissional == (int)schedulerAgenda.SelectedResource.Id),
                    HoraInicial = schedulerAgenda.SelectedInterval.Start,
                    Data = dateNavigator1.DateTime.Date
                };
            }

            var form = new frmDetalheAgenda(agenda);

            if (form.ShowDialog() == DialogResult.OK)
                MontaHorarios();

            e.Handled = true;
        }

        private void uConsultaAgenda_Load(object sender, EventArgs e)
        {
            dateNavigator1.DateTime = DateTime.Now;

            RecuperarProfissionaisAgenda();
            MontaHorarios();

            schedulerAgenda.OptionsCustomization.AllowInplaceEditor = UsedAppointmentType.Custom;
            dateNavigator1.Refresh();
        }

        private void dateNavigator1_EditDateModified(object sender, EventArgs e)
        {
            MontaHorarios();
        }

        private void schedulerAgenda_Click(object sender, EventArgs e)
        {
            if (schedulerAgenda.SelectedAppointments.Count == 0)
            {
                rteAgenda.Text = string.Empty;
                return;
            }

            Agenda agenda = _agendas.First(x => x.IdAgenda == ((Agenda)schedulerAgenda.SelectedAppointments[0].GetRow(schedulerStorage)).IdAgenda);
            rteAgenda.Text = ResumoDadosDaAgenda(agenda);
        }

        private string ResumoDadosDaAgenda(Agenda agenda)
        {
            var servicos = new StringBuilder();

            foreach (var serv in agenda.Servicos)
            {
                servicos.AppendLine("\n " + serv.Descricao);
            }

            return new StringBuilder().Append("\n Cliente: " + agenda.Cliente.Nome)
                .Append("\n\n Profissional: " + agenda.Profissional.Nome)
                .Append("\n\n Data: " + agenda.Data.ToShortDateString())
                .Append("\n\n Horário: " +
                        string.Format("{0} - {1}", agenda.HoraInicial.ToShortTimeString(),
                            agenda.HoraFinal.ToShortTimeString()))
                .Append("\n\n Telefone: " + agenda.Cliente.Telefone)
                .Append("\n\n Celular: " + agenda.Cliente.Celular)
                .Append("\n\n Serviços: " + servicos).ToString();
        }

        private void schedulerAgenda_AppointmentViewInfoCustomizing(object sender, AppointmentViewInfoCustomizingEventArgs e)
        {
            var aptViewInfo = e.ViewInfo as AppointmentViewInfo;

            if (aptViewInfo.Appointment.End >= DateTime.Now) return;

            aptViewInfo.Appearance.Options.UseBackColor = true;

            var agenda =
                _agendas.First(x => x.IdAgenda == ((Agenda)aptViewInfo.Appointment.GetRow(schedulerStorage)).IdAgenda);

            aptViewInfo.Appearance.BackColor = agenda.Situacao == SituacaoAgenda.Finalizada ? Color.LightSkyBlue : Color.BurlyWood;
        }

        private void btOcorrencia_Click(object sender, EventArgs e)
        {
            var frm = new frmOcorrencia(dateNavigator1.DateTime);
            frm.ShowDialog();
        }

        private void pictureEdit1_MouseEnter(object sender, EventArgs e)
        {
            panelLegenda.Visible = true;
        }

        private void pictureEdit1_MouseLeave(object sender, EventArgs e)
        {
            panelLegenda.Visible = false;
        }

        private void toolTipController_BeforeShow(object sender, DevExpress.Utils.ToolTipControllerShowEventArgs e)
        {
            ToolTipController controller = sender as ToolTipController;

           
            AppointmentViewInfo aptViewInfo = controller.ActiveObject as AppointmentViewInfo;
            if (aptViewInfo == null) return;         
           
            e.Title = aptViewInfo.Appointment.Subject;
            e.ToolTip = string.Format("{0}", aptViewInfo.Appointment.Description);
        }
    }
}
