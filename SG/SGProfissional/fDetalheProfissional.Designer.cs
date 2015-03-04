namespace SGProfissional
{
    partial class fDetalheProfissional
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDetalheProfissional));
            this.txtNome = new DevExpress.XtraEditors.TextEdit();
            this.txtEndereco = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefone = new DevExpress.XtraEditors.TextEdit();
            this.txtCelular = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btGravar = new DevExpress.XtraEditors.SimpleButton();
            this.btCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.dxError = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.cboNascimento = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtBairro = new DevExpress.XtraEditors.TextEdit();
            this.txtCidade = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.cboAgenda = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TabControl = new DevExpress.XtraTab.XtraTabControl();
            this.TabInfo = new DevExpress.XtraTab.XtraTabPage();
            this.TabServicos = new DevExpress.XtraTab.XtraTabPage();
            this.gcServicos = new DevExpress.XtraGrid.GridControl();
            this.gvServicos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdServico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelecionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riSelecionar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTempo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndereco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCelular.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNascimento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNascimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBairro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAgenda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TabInfo.SuspendLayout();
            this.TabServicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riSelecionar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(66, 7);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtNome.Properties.Appearance.Options.UseBackColor = true;
            this.txtNome.Properties.MaxLength = 50;
            this.txtNome.Size = new System.Drawing.Size(241, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(66, 138);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Properties.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtEndereco.Properties.Appearance.Options.UseBackColor = true;
            this.txtEndereco.Properties.MaxLength = 50;
            this.txtEndereco.Size = new System.Drawing.Size(159, 20);
            this.txtEndereco.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Nome:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 141);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Endereço:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(235, 141);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(16, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "N°:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(254, 138);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Properties.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtNumero.Properties.Appearance.Options.UseBackColor = true;
            this.txtNumero.Properties.MaxLength = 10;
            this.txtNumero.Size = new System.Drawing.Size(53, 20);
            this.txtNumero.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 89);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Cidade:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 115);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(32, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Bairro:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(10, 167);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(66, 164);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.MaxLength = 50;
            this.txtEmail.Size = new System.Drawing.Size(241, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(66, 33);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Properties.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtTelefone.Properties.Appearance.Options.UseBackColor = true;
            this.txtTelefone.Properties.MaxLength = 15;
            this.txtTelefone.Size = new System.Drawing.Size(109, 20);
            this.txtTelefone.TabIndex = 1;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(66, 60);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Properties.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtCelular.Properties.Appearance.Options.UseBackColor = true;
            this.txtCelular.Properties.MaxLength = 15;
            this.txtCelular.Size = new System.Drawing.Size(109, 20);
            this.txtCelular.TabIndex = 3;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(11, 36);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(46, 13);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Telefone:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(11, 63);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(37, 13);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Celular:";
            // 
            // btGravar
            // 
            this.btGravar.Image = ((System.Drawing.Image)(resources.GetObject("btGravar.Image")));
            this.btGravar.Location = new System.Drawing.Point(232, 224);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(75, 23);
            this.btGravar.TabIndex = 11;
            this.btGravar.Text = "Gravar";
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.Location = new System.Drawing.Point(150, 224);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 12;
            this.btCancelar.Text = "Cancelar";
            // 
            // dxError
            // 
            this.dxError.ContainerControl = this;
            // 
            // cboNascimento
            // 
            this.cboNascimento.EditValue = null;
            this.cboNascimento.Location = new System.Drawing.Point(209, 33);
            this.cboNascimento.Name = "cboNascimento";
            this.cboNascimento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNascimento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNascimento.Size = new System.Drawing.Size(98, 20);
            this.cboNascimento.TabIndex = 2;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(177, 36);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(31, 13);
            this.labelControl9.TabIndex = 21;
            this.labelControl9.Text = "Nasc.:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(66, 112);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Properties.MaxLength = 50;
            this.txtBairro.Size = new System.Drawing.Size(241, 20);
            this.txtBairro.TabIndex = 7;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(66, 86);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Properties.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtCidade.Properties.Appearance.Options.UseBackColor = true;
            this.txtCidade.Properties.MaxLength = 50;
            this.txtCidade.Size = new System.Drawing.Size(241, 20);
            this.txtCidade.TabIndex = 5;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(10, 193);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(41, 13);
            this.labelControl10.TabIndex = 23;
            this.labelControl10.Text = "Agenda:";
            // 
            // cboAgenda
            // 
            this.cboAgenda.EditValue = "Sim";
            this.cboAgenda.Location = new System.Drawing.Point(66, 190);
            this.cboAgenda.Name = "cboAgenda";
            this.cboAgenda.Properties.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.cboAgenda.Properties.Appearance.Options.UseBackColor = true;
            this.cboAgenda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboAgenda.Properties.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cboAgenda.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboAgenda.Size = new System.Drawing.Size(74, 20);
            this.cboAgenda.TabIndex = 24;
            // 
            // TabControl
            // 
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedTabPage = this.TabInfo;
            this.TabControl.Size = new System.Drawing.Size(320, 286);
            this.TabControl.TabIndex = 25;
            this.TabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabInfo,
            this.TabServicos});
            this.TabControl.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.TabControl_SelectedPageChanged);
            this.TabControl.SelectedPageChanging += new DevExpress.XtraTab.TabPageChangingEventHandler(this.TabControl_SelectedPageChanging);
            // 
            // TabInfo
            // 
            this.TabInfo.Controls.Add(this.txtCidade);
            this.TabInfo.Controls.Add(this.cboAgenda);
            this.TabInfo.Controls.Add(this.txtBairro);
            this.TabInfo.Controls.Add(this.labelControl10);
            this.TabInfo.Controls.Add(this.txtNome);
            this.TabInfo.Controls.Add(this.labelControl9);
            this.TabInfo.Controls.Add(this.txtEndereco);
            this.TabInfo.Controls.Add(this.cboNascimento);
            this.TabInfo.Controls.Add(this.labelControl1);
            this.TabInfo.Controls.Add(this.btCancelar);
            this.TabInfo.Controls.Add(this.labelControl2);
            this.TabInfo.Controls.Add(this.btGravar);
            this.TabInfo.Controls.Add(this.labelControl3);
            this.TabInfo.Controls.Add(this.labelControl8);
            this.TabInfo.Controls.Add(this.txtNumero);
            this.TabInfo.Controls.Add(this.labelControl7);
            this.TabInfo.Controls.Add(this.labelControl4);
            this.TabInfo.Controls.Add(this.txtCelular);
            this.TabInfo.Controls.Add(this.labelControl5);
            this.TabInfo.Controls.Add(this.txtTelefone);
            this.TabInfo.Controls.Add(this.labelControl6);
            this.TabInfo.Controls.Add(this.txtEmail);
            this.TabInfo.Name = "TabInfo";
            this.TabInfo.Size = new System.Drawing.Size(314, 258);
            this.TabInfo.Text = "Informações";
            // 
            // TabServicos
            // 
            this.TabServicos.Controls.Add(this.gcServicos);
            this.TabServicos.Name = "TabServicos";
            this.TabServicos.Size = new System.Drawing.Size(314, 258);
            this.TabServicos.Text = "Serviços";
            // 
            // gcServicos
            // 
            this.gcServicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcServicos.Location = new System.Drawing.Point(0, 0);
            this.gcServicos.MainView = this.gvServicos;
            this.gcServicos.Name = "gcServicos";
            this.gcServicos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riSelecionar});
            this.gcServicos.Size = new System.Drawing.Size(314, 258);
            this.gcServicos.TabIndex = 0;
            this.gcServicos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvServicos});
            // 
            // gvServicos
            // 
            this.gvServicos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdServico,
            this.colSelecionado,
            this.colDescricao,
            this.colTempo,
            this.colValor});
            this.gvServicos.GridControl = this.gcServicos;
            this.gvServicos.Name = "gvServicos";
            this.gvServicos.OptionsView.ShowGroupPanel = false;
            // 
            // colIdServico
            // 
            this.colIdServico.Caption = "IdServico";
            this.colIdServico.FieldName = "IdServico";
            this.colIdServico.Name = "colIdServico";
            // 
            // colSelecionado
            // 
            this.colSelecionado.Caption = " ";
            this.colSelecionado.ColumnEdit = this.riSelecionar;
            this.colSelecionado.FieldName = "Selecionado";
            this.colSelecionado.Name = "colSelecionado";
            this.colSelecionado.Visible = true;
            this.colSelecionado.VisibleIndex = 0;
            this.colSelecionado.Width = 72;
            // 
            // riSelecionar
            // 
            this.riSelecionar.AutoHeight = false;
            this.riSelecionar.Name = "riSelecionar";
            this.riSelecionar.ValueGrayed = false;
            this.riSelecionar.CheckedChanged += new System.EventHandler(this.riSelecionar_CheckedChanged);
            // 
            // colDescricao
            // 
            this.colDescricao.Caption = "Descrição";
            this.colDescricao.FieldName = "Descricao";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.OptionsColumn.AllowEdit = false;
            this.colDescricao.Visible = true;
            this.colDescricao.VisibleIndex = 1;
            this.colDescricao.Width = 707;
            // 
            // colTempo
            // 
            this.colTempo.Caption = "Tempo";
            this.colTempo.DisplayFormat.FormatString = "{0} min";
            this.colTempo.FieldName = "Tempo";
            this.colTempo.Name = "colTempo";
            this.colTempo.OptionsColumn.AllowEdit = false;
            this.colTempo.Visible = true;
            this.colTempo.VisibleIndex = 2;
            this.colTempo.Width = 155;
            // 
            // colValor
            // 
            this.colValor.Caption = "Valor";
            this.colValor.DisplayFormat.FormatString = "{0:c}";
            this.colValor.FieldName = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.OptionsColumn.AllowEdit = false;
            this.colValor.Visible = true;
            this.colValor.VisibleIndex = 3;
            this.colValor.Width = 171;
            // 
            // fDetalheProfissional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 286);
            this.Controls.Add(this.TabControl);
            this.MinimizeBox = false;
            this.Name = "fDetalheProfissional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes do Profissional";
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndereco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCelular.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNascimento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNascimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBairro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAgenda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.TabInfo.ResumeLayout(false);
            this.TabInfo.PerformLayout();
            this.TabServicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riSelecionar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNome;
        private DevExpress.XtraEditors.TextEdit txtEndereco;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtNumero;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtTelefone;
        private DevExpress.XtraEditors.TextEdit txtCelular;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btGravar;
        private DevExpress.XtraEditors.SimpleButton btCancelar;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxError;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.DateEdit cboNascimento;
        private DevExpress.XtraEditors.TextEdit txtBairro;
        private DevExpress.XtraEditors.TextEdit txtCidade;
        private DevExpress.XtraEditors.ComboBoxEdit cboAgenda;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraTab.XtraTabControl TabControl;
        private DevExpress.XtraTab.XtraTabPage TabServicos;
        private DevExpress.XtraTab.XtraTabPage TabInfo;
        private DevExpress.XtraGrid.GridControl gcServicos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvServicos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdServico;
        private DevExpress.XtraGrid.Columns.GridColumn colSelecionado;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riSelecionar;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn colTempo;
        private DevExpress.XtraGrid.Columns.GridColumn colValor;
    }
}