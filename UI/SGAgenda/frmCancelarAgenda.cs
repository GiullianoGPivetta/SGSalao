using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGGUIBase;

namespace SGAgenda
{
    public partial class frmCancelarAgenda : frmBase
    {
        public string Justificativa = string.Empty;

        public frmCancelarAgenda()
        {
            InitializeComponent();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            Justificativa = memoJust.Text;
            DialogResult = DialogResult.OK;
            Close();

        }

        private bool Validar()
        {
            return !string.IsNullOrEmpty(memoJust.Text);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
