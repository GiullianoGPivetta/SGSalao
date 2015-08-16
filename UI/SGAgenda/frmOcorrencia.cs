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
using SGServico.Servicos;

namespace SGAgenda
{
    public partial class frmOcorrencia : frmBase
    {
        private AgendaServico _servicoAgenda = new AgendaServico();

        private DateTime _data;


        public frmOcorrencia(DateTime data)
        {
            InitializeComponent();

            _data = data;
            Consultar();
        }

        private void Consultar()
        {
            var resp = _servicoAgenda.RecuperarListaOcorrencia(_data.Date);

            gcOcorrencias.DataSource = resp;
            gvOcorrencias.BestFitColumns();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
