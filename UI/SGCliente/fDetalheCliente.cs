using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGCore.Utils;
using SGEntidades.Entidades;
using SGEntidades.Enum;
using SGServico.Servicos;

namespace SGCliente
{
    public partial class fDetalheCliente : Form
    {
        private readonly Cliente _cliente;
        private readonly ClienteServico _clienteServico = new ClienteServico();


        public fDetalheCliente()
        {
            InitializeComponent();

            CarregaEndereco();

        }

        private void CarregaEndereco()
        {
            //
        }

        public fDetalheCliente(Cliente cliente)
            : this()
        {
            _cliente = cliente;

            MontaCliente();
        }


        private void MontaCliente()
        {
            if (_cliente == null) return;

            txtNome.Text = _cliente.Nome;
            txtNumero.Text = _cliente.Numero;
            txtTelefone.Text = _cliente.Telefone;
            txtEndereco.Text = _cliente.Endereco;
            txtCpf.Text = _cliente.CPF;
            txtEmail.Text = _cliente.Email;
            txtCelular.Text = _cliente.Celular;
            txtBairro.Text = _cliente.Bairro;
            txtCidade.Text = _cliente.Cidade;
            cboStatus.SelectedText = EnumUtils<Status>.GetDescription(_cliente.Status);
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if (!Valida()) return;

            var cliente = new Cliente()
            {
                Nome = txtNome.Text,
                Nascimento = cboNascimento.Text != string.Empty ? cboNascimento.DateTime : (DateTime?)null,
                Bairro = txtBairro.Text,
                Celular = txtCelular.Text,
                CPF = txtCpf.Text,
                Cidade = txtCidade.Text,
                Numero = txtNumero.Text,
                Telefone = txtTelefone.Text,
                Email = txtEmail.Text,
                Endereco = txtEndereco.Text,
                Status = EnumUtils<Status>.FromDescription(cboStatus.SelectedText)

            };

            if (_cliente == null)
                _clienteServico.Inserir(cliente);
            else
            {
                cliente.IdCliente = _cliente.IdCliente;
                _clienteServico.Editar(cliente);
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool Valida()
        {
            if (String.IsNullOrWhiteSpace(txtNome.Text))
                dxError.SetError(txtNome, "O Nome do cliente deve ser informado.");

            if (String.IsNullOrWhiteSpace(txtTelefone.Text))
                dxError.SetError(txtNome, "O Telefone do cliente deve ser informado.");

            if (String.IsNullOrWhiteSpace(txtTelefone.Text))
                dxError.SetError(txtNome, "O Celular do cliente deve ser informado.");

            return !dxError.HasErrors;
        }


    }
}
