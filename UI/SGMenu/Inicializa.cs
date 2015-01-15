using System.Windows.Forms;
using Microsoft.Win32;
using SGMenu.Properties;

namespace SGMenu
{
    public class Inicializa
    {
        public void IniciarSistema()
        {
            //var registryKey = Registry.LocalMachine.OpenSubKey(@"MNSalao");

            //var connection = string.Empty;

            //if (registryKey == null)
            //{
            //    MessageBox.Show(Resources.ErroRegistro, Resources.Sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //connection = registryKey.GetValue("ConnectionString").ToString();
            
            //if(string.IsNullOrWhiteSpace(connection))
            //{
            //    MessageBox.Show(Resources.ConnectionString, Resources.Sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            
            //var usr = new frmLogin();
            //if (usr.ShowDialog() != DialogResult.OK) return;

            var menu = new fMenu();
            menu.ShowDialog();
        }
    }
}