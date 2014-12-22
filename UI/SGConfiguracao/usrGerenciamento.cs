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

namespace SGConfiguracao
{
    public partial class usrGerenciamento : UserControl
    {
        public usrGerenciamento()
        {
            InitializeComponent();

            tabControl.SelectedTabPage = TabProfissional;

            MontaProfissional();
        }

        private void MontaProfissional()
        {
            var usr = new usrConsultaProfissional { Dock = DockStyle.Fill };
            TabProfissional.Controls.Add(usr);
        }
    }
}
