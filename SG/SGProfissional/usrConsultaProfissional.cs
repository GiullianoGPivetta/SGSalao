using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SGEntidades.Entidades;
using SGProfissional.Properties;
using SGServico.Servicos;

namespace SGProfissional
{
    public partial class usrConsultaProfissional : UserControl
    {
        private readonly ProfissionalServico _profissionalServico = new ProfissionalServico();
        private List<Profissional> _profissional;
        private readonly bool _seleciona;

        public delegate void SelecionaProfissional(Profissional prof);
        public event SelecionaProfissional _selecionaProfissional;

        public usrConsultaProfissional()
        {
            InitializeComponent();

            ConsultaLista();
        }

        public usrConsultaProfissional(bool seleciona)
            : this()
        {
            _seleciona = seleciona;
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            ConsultaLista();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            var detalhe = new fDetalheProfissional();
            if (detalhe.ShowDialog() == DialogResult.OK)
                ConsultaLista();

        }

        private void ConsultaLista()
        {
            _profissional = _profissionalServico.RecuperarLista();
            gcProfissional.DataSource = _profissional;
            gcProfissional.RefreshDataSource();
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            if (gvProfissional.SelectedRowsCount == 0) return;

            if (
                MessageBox.Show(Resources.ApagarProfissional, Resources.atencao, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                return;

            var profissional = gvProfissional.GetFocusedRow() as Profissional;

            _profissionalServico.Deletar(profissional);

            ConsultaLista();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (gvProfissional.SelectedRowsCount == 0) return;

            var selecionado = _profissional.Find(x => x.IdProfissional == ((Profissional)gvProfissional.GetFocusedRow()).IdProfissional);

            var usr = new fDetalheProfissional(selecionado);
            if (usr.ShowDialog() == DialogResult.OK)
                ConsultaLista();

        }

        private void gcProfissional_DoubleClick(object sender, EventArgs e)
        {
            if (gvProfissional.SelectedRowsCount == 0) return;

            var selecionado =
                _profissional.Find(
                    x => x.IdProfissional == ((Profissional)gvProfissional.GetFocusedRow()).IdProfissional);


            if (_seleciona)
            {
                _selecionaProfissional(selecionado);
            }
            else
            {
                var frm = new fDetalheProfissional(selecionado);
                if (frm.ShowDialog() == DialogResult.OK)
                    ConsultaLista();
            }
        }
    }
}
