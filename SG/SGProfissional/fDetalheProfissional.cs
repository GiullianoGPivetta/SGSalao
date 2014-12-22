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

namespace SGProfissional
{
    public partial class fDetalheProfissional : Form
    {
        private readonly Profissional _profissional;
        private readonly ProfissionalServico _profissionalServSevico = new ProfissionalServico();
        
        public fDetalheProfissional()
        {
            InitializeComponent();
        }

        public fDetalheProfissional(Profissional profissional)
            : this()
        {
            _profissional = profissional;

            MontaProfissional();
        }

        private void MontaProfissional()
        {
            if (_profissional == null) return;

            txtNome.Text = _profissional.Nome;
            txtNumero.Text = _profissional.Numero;
            txtTelefone.Text = _profissional.Telefone;
            txtEndereco.Text = _profissional.Endereco;
            txtEmail.Text = _profissional.Email;
            txtCelular.Text = _profissional.Celular;
            txtBairro.Text = _profissional.Bairro;
            txtCidade.Text = _profissional.Cidade;
            cboAgenda.Text = EnumUtils<SimNao>.GetDescription(_profissional.ParticipaAgenda);
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if (!Valida()) return;

            var profissional = new Profissional()
            {
                Nome = txtNome.Text,
                Nascimento = cboNascimento.Text != string.Empty ? cboNascimento.DateTime : (DateTime?)null,
                Bairro = txtBairro.Text,
                Celular = txtCelular.Text,
                Cidade = txtCidade.Text,
                Numero = txtNumero.Text,
                Telefone = txtTelefone.Text,
                Email = txtEmail.Text,
                Endereco = txtEndereco.Text,
                ParticipaAgenda = EnumUtils<SimNao>.FromDescription(cboAgenda.SelectedText)
            };

            if (_profissional == null)
                _profissionalServSevico.Inserir(profissional);
            else
            {
                profissional.IdProfissional = _profissional.IdProfissional;
                _profissionalServSevico.Editar(profissional);
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool Valida()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
                dxError.SetError(txtNome, "O Nome do Profissional deve ser informado.");

            if (string.IsNullOrWhiteSpace(txtTelefone.Text))
                dxError.SetError(txtTelefone, "O Telefone do Profissional deve ser informado.");

            if (string.IsNullOrWhiteSpace(txtCelular.Text))
                dxError.SetError(txtCelular, "O Celular do Profissional deve ser informado.");

            if (string.IsNullOrWhiteSpace(cboAgenda.))
                dxError.SetError(cboAgenda, "Deve ser informado se o Profissional participa da agenda.");

            if (string.IsNullOrWhiteSpace(txtNumero.Text))
                dxError.SetError(txtNumero, "O Numero do endereço do Profissional deve ser informado.");

            if (string.IsNullOrWhiteSpace(txtCidade.Text))
                dxError.SetError(txtCidade, "A cidade do Profissional deve ser informado.");


            return !dxError.HasErrors;
        }

    }
}
