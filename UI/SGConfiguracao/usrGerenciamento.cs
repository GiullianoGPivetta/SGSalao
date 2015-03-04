using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGProfissional;
using SGServicos;

namespace SGConfiguracao
{
    public partial class usrGerenciamento : UserControl
    {
        public usrGerenciamento()
        {
            InitializeComponent();

            tabControl.SelectedTabPage = TabProfissional;

            MontaProfissional();
            MontaServicos();
        }

        private void MontaProfissional()
        {
            var usr = new usrConsultaProfissional { Dock = DockStyle.Fill };
            TabProfissional.Controls.Add(usr);
        }

        private void tabControl_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            //if (tabControl.SelectedTabPage == TabProfissional)
            //{

            //}
            //else if (tabControl.SelectedTabPage == TabServicos)
            //{
            //    MontaServicos();
            //}
        }

        private void MontaServicos()
        {
            var usr = new usrServicos { Dock = DockStyle.Fill };
            TabServicos.Controls.Add(usr);
        }
    }
}
