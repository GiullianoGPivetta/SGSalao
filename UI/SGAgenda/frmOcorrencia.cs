using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGAgenda
{
    public partial class frmOcorrencia : Form
    {
        private DateTime _data;


        public frmOcorrencia(DateTime data)
        {
            InitializeComponent();

            _data = data;
            Consultar();
        }

        private void Consultar()
        {
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
