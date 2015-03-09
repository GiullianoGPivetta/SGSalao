using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SGCore.Utils;
using SGEntidades.Entidades;
using SGEntidades.Enum;
using SGGUIBase;
using SGServico.Servicos;

namespace SGProfissional
{
    public partial class fDetalheProfissional : frmBase
    {
        private readonly Profissional _profissional;
        private readonly ProfissionalServico _profissionalServSevico = new ProfissionalServico();
        private readonly ServicoServico _servicoServico = new ServicoServico();

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

            if (string.IsNullOrWhiteSpace(cboAgenda.Text))
                dxError.SetError(cboAgenda, "Deve ser informado se o Profissional participa da agenda.");

            if (string.IsNullOrWhiteSpace(txtNumero.Text))
                dxError.SetError(txtNumero, "O Numero do endereço do Profissional deve ser informado.");

            if (string.IsNullOrWhiteSpace(txtCidade.Text))
                dxError.SetError(txtCidade, "A cidade do Profissional deve ser informado.");


            return !dxError.HasErrors;
        }

        private void TabControl_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (TabControl.SelectedTabPage == TabServicos)
                MontaServicos();
        }

        private void MontaServicos()
        {
            var servicos = _servicoServico.RecuperarListaStatus(Status.Ativo);
            var servicosProfissional = _servicoServico.RecuperarListaPorProfissional(_profissional);

            foreach (var s in servicosProfissional)
            {
                (servicos.First(x => x.IdServico == s.IdServico)).Selecionado = true;
            }

            gcServicos.DataSource = servicos.OrderBy(x => x.Descricao);

        }

        private void TabControl_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            if (_profissional == null)
            {
                MessageBox.Show("Salve as informações antes para poder acessar os serviços.",
                    "Martins e Nickel Centro de Beleza", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabControl.SelectedTabPage = TabInfo;

                e.Cancel = true;
            }
        }

        private void riSelecionar_CheckedChanged(object sender, EventArgs e)
        {
            if (gvServicos.SelectedRowsCount == 0) return;
            var serv = gvServicos.GetFocusedRow() as Servico;
            if (serv == null) return;


            var check = (CheckEdit)sender;

            if (check.Checked)
            {
                _profissionalServSevico.InserirServico(_profissional.IdProfissional, serv.IdServico);
            }
            else
            {
                _profissionalServSevico.DeletarServico(_profissional.IdProfissional, serv.IdServico);
            }
        }
    }
}
