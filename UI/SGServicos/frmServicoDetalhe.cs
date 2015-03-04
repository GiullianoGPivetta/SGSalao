using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGCore.Utils;
using SGEntidades.Entidades;
using SGEntidades.Enum;
using SGServico.Servicos;

namespace SGServicos
{
    public partial class frmServicoDetalhe : Form
    {
        private Servico _servico;
        private ServicoServico _service = new ServicoServico();

        public frmServicoDetalhe()
        {
            InitializeComponent();
        }

        public frmServicoDetalhe(Servico servico)
            : this()
        {
            _servico = servico;

            MontaEdicao();
        }

        private void MontaEdicao()
        {
            txtDesc.Text = _servico.Descricao;
            txtValor.Text = Convert.ToString(_servico.Valor, CultureInfo.InvariantCulture);
            spTempo.Value = _servico.Tempo;
            cboStatus.Text = EnumUtils<Status>.GetDescription(_servico.Status);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            if (!Validar()) return;

            if (_servico == null)
            {
                var ser = new Servico
                {
                    Descricao = txtDesc.Text,
                    Tempo = Convert.ToInt16(spTempo.Value),
                    Valor = Convert.ToDecimal(txtValor.Text),
                    Status = EnumUtils<Status>.FromDescription(cboStatus.Text)
                };

                _service.Inserir(ser);
            }
            else
            {

                _servico.Descricao = txtDesc.Text;
                _servico.Tempo = Convert.ToInt16(spTempo.Value);
                _servico.Valor = Convert.ToDecimal(txtValor.Text);
                _servico.Status = EnumUtils<Status>.FromDescription(cboStatus.Text);

                _service.Editar(_servico);
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(txtDesc.Text))
                dxErro.SetError(txtDesc, "Deve ser inserida uma descrição.");

            if (string.IsNullOrEmpty(txtValor.Text))
                dxErro.SetError(txtValor, "Deve ser inserido um valor para o serviço.");

            if (string.IsNullOrEmpty(spTempo.Text))
                dxErro.SetError(txtValor, "Deve ser inserido um tempo para o serviço.");

            return !dxErro.HasErrors;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
