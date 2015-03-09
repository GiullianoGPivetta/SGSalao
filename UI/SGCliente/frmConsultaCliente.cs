using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGEntidades.Entidades;
using SGGUIBase;

namespace SGCliente
{
    public partial class frmConsultaCliente : frmBase
    {
        public Cliente _clienteSelecionado;

        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        public frmConsultaCliente(bool consulta)
            : this()
        {
            var usr = new usrConsultaCliente(consulta) { Dock = DockStyle.Fill };
            this.Controls.Add(usr);
            usr._seleciona += usr__seleciona;
        }

        void usr__seleciona(Cliente a)
        {
            _clienteSelecionado = a;
            DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
