using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGAgenda.usrControls;
using SGCliente;
using SGConfiguracao;
using SGGUIBase;

namespace SGMenu
{
    public partial class fMenu : frmBase
        {
        private static readonly uConsultaAgenda _agenda = new uConsultaAgenda { Dock = DockStyle.Fill };
        private static readonly usrConsultaCliente _clientes = new usrConsultaCliente { Dock = DockStyle.Fill };

        public fMenu()
        {
            InitializeComponent();
        }

        private void btAgenda_Click(object sender, EventArgs e)
        {
            if (!splitMDI.Panel2.Controls.Contains(_agenda))
            {
                splitMDI.Panel2.Controls.Add(_agenda);
                _agenda.BringToFront();
            }
            else
            {
                _agenda.BringToFront();
                _agenda.Focus();
            }
        }

        private void btContatos_Click(object sender, EventArgs e)
        {

            if (!splitMDI.Panel2.Controls.Contains(_clientes))
            {
                splitMDI.Panel2.Controls.Add(_clientes);
                _clientes.BringToFront();
            }
            else
            {
                _clientes.BringToFront();
                _clientes.Focus();
            }
        }

        private void btDistribuidor_Click(object sender, EventArgs e)
        {
            //var agenda = new uConsultaAgenda() { Dock = DockStyle.Fill };
            //if (!splitMDI.Panel2.Controls.Contains(agenda))
            //    splitMDI.Panel2.Controls.Add(agenda);
            //else
            //    agenda.Focus();
        }

        private void btAgenda_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btAgenda_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            var gerenc = new usrGerenciamento { Dock = DockStyle.Fill };
            if (!splitMDI.Panel2.Controls.Contains(gerenc))
            {
                splitMDI.Panel2.Controls.Add(gerenc);
                gerenc.BringToFront();
            }
            else
            {
                gerenc.BringToFront();
                gerenc.Focus();
            }
        }
    }


}
