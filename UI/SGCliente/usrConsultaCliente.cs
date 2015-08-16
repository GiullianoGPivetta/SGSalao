
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using SGCliente.Properties;
using SGEntidades.Entidades;
using SGEntidades.Enum;
using SGServico.Servicos;

namespace SGCliente
{
    public partial class usrConsultaCliente : UserControl
    {
        private readonly ClienteServico _clienteServico = new ClienteServico();
        private List<Cliente> _clientes;
        private readonly bool _selecionaPaciente;

        public delegate void SelecionaCliente(Cliente a);
        public event SelecionaCliente _seleciona;

        public usrConsultaCliente()
        {
            InitializeComponent();

            ConsultaLista();
        }

        public usrConsultaCliente(bool consulta)
            : this()
        {
            _selecionaPaciente = true;
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            ConsultaLista();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            var detalhe = new fDetalheCliente();
            if (detalhe.ShowDialog() == DialogResult.OK)
                ConsultaLista();

        }

        private void ConsultaLista()
        {
            _clientes = _clienteServico.RecuperarLista();
            gcClientes.DataSource = _clientes;
            gcClientes.RefreshDataSource();
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            if (gvClientes.SelectedRowsCount == 0) return;

            if (
                MessageBox.Show(Resources.ApagarCliente, Resources.atencao, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                return;

            var cliente = gvClientes.GetFocusedRow() as Cliente;

            cliente.Status = cliente.Status == Status.Ativo ? Status.Inativo : Status.Ativo;

            _clienteServico.Deletar(cliente);

            ConsultaLista();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (gvClientes.SelectedRowsCount == 0) return;

            var selecionado = _clientes.Find(x => x.IdCliente == ((Cliente)gvClientes.GetFocusedRow()).IdCliente);

            var usr = new fDetalheCliente(selecionado);
            if (usr.ShowDialog() == DialogResult.OK)
                ConsultaLista();

        }

        private void gcClientes_DoubleClick(object sender, EventArgs e)
        {
            if (gvClientes.SelectedRowsCount == 0) return;

            var selecionado = _clientes.Find(x => x.IdCliente == ((Cliente)gvClientes.GetFocusedRow()).IdCliente);

            if (_selecionaPaciente)
            {
                _seleciona(selecionado);
            }
            else
            {
                var usr = new fDetalheCliente(selecionado);
                if (usr.ShowDialog() == DialogResult.OK)
                    ConsultaLista();
            }
        }

        private void txtCliente_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCliente.Text))
                gvClientes.Columns["Nome"].FilterInfo = new ColumnFilterInfo(string.Format("[Nome] LIKE '{0}%'", txtCliente.Text));
            else
                gvClientes.ClearColumnsFilter();
        }
    }
}
