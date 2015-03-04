using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGEntidades.Entidades;
using SGEntidades.Enum;
using SGServico.Servicos;

namespace SGServicos
{
    public partial class usrServicos : UserControl
    {
        private ServicoServico _servico = new ServicoServico();


        public usrServicos()
        {
            InitializeComponent();

            Consultar();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void Consultar()
        {
            Status status;

            if (checkAtivo.Checked && checkInativo.Checked || !checkAtivo.Checked && !checkInativo.Checked)
                status = Status.NaoInformado;
            else
                status = checkAtivo.Checked ? Status.Ativo : Status.Inativo;

            var servicos = _servico.RecuperarListaStatus(status);
            gcServicos.DataSource = servicos;
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            var frm = new frmServicoDetalhe();
            if (frm.ShowDialog() == DialogResult.OK)
                Consultar();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (gvServicos.SelectedRowsCount == 0) return;

            var serv = (Servico)gvServicos.GetFocusedRow();

            var frm = new frmServicoDetalhe(serv);
            if (frm.ShowDialog() == DialogResult.OK)
                Consultar();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (gvServicos.SelectedRowsCount == 0) return;

            var serv = (Servico)gvServicos.GetFocusedRow();
            serv.Status = Status.Inativo;

            _servico.Deletar(serv);
            Consultar();
        }
    }
}
