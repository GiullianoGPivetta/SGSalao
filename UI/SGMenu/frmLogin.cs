using System;
using System.Windows.Forms;
using SGGUIBase;

namespace SGMenu
{
    public partial class frmLogin : frmBase
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var menu = new fMenu();
            menu.ShowDialog();
        }
    }
}
