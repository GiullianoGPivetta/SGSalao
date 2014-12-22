using System;
using System.Windows.Forms;

namespace SGMenu
{
    public partial class frmLogin : Form
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
