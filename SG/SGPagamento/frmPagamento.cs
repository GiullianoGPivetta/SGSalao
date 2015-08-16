using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGEntidades.Entidades;

namespace SGPagamento
{
    public partial class frmPagamento : SGGUIBase.frmBase
    {
        private Agenda _agenda;

        public frmPagamento()
        {
            InitializeComponent();
        }

        public frmPagamento(Agenda agenda)
            : this()
        {
            _agenda = agenda;

            var servs = _agenda.Servicos.Select(servico => new PagamentoServico { IdServico = servico.IdServico, Servico = servico.Descricao, VlBruto = servico.Valor, VlLiquido = servico.Valor }).ToList();
            gcServico.DataSource = servs;

        }


        internal class PagamentoServico
        {
            public int IdServico { get; set; }
            public string Servico { get; set; }
            public decimal VlBruto { get; set; }
            public decimal VlLiquido { get; set; }
        }


    }
}
