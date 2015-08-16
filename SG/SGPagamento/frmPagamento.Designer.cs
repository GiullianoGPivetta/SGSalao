namespace SGPagamento
{
    partial class frmPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagamento));
            this.radioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gcServico = new DevExpress.XtraGrid.GridControl();
            this.gvServico = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdServico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVlBruto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVlLiquido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblValor = new DevExpress.XtraEditors.LabelControl();
            this.btConfirmar = new DevExpress.XtraEditors.SimpleButton();
            this.btCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioGroup
            // 
            this.radioGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioGroup.Location = new System.Drawing.Point(0, 0);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Properties.Columns = 4;
            this.radioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("DD", "Dinheiro"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("CC", "Cartão de Crédito"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("CH", "Cheque")});
            this.radioGroup.Size = new System.Drawing.Size(526, 29);
            this.radioGroup.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btCancelar);
            this.panelControl1.Controls.Add(this.btConfirmar);
            this.panelControl1.Controls.Add(this.lblValor);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 320);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(526, 29);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Valor Total:";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gcServico);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(526, 184);
            this.splitContainerControl1.SplitterPosition = 270;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gcServico
            // 
            this.gcServico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcServico.Location = new System.Drawing.Point(0, 0);
            this.gcServico.MainView = this.gvServico;
            this.gcServico.Name = "gcServico";
            this.gcServico.Size = new System.Drawing.Size(270, 184);
            this.gcServico.TabIndex = 0;
            this.gcServico.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvServico});
            // 
            // gvServico
            // 
            this.gvServico.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdServico,
            this.colServico,
            this.colVlBruto,
            this.colVlLiquido});
            this.gvServico.GridControl = this.gcServico;
            this.gvServico.Name = "gvServico";
            this.gvServico.OptionsView.ShowGroupPanel = false;
            // 
            // colIdServico
            // 
            this.colIdServico.Caption = "IdServico";
            this.colIdServico.FieldName = "IdServico";
            this.colIdServico.Name = "colIdServico";
            // 
            // colServico
            // 
            this.colServico.Caption = "Serviço";
            this.colServico.FieldName = "Servico";
            this.colServico.Name = "colServico";
            this.colServico.OptionsColumn.AllowEdit = false;
            this.colServico.Visible = true;
            this.colServico.VisibleIndex = 0;
            // 
            // colVlBruto
            // 
            this.colVlBruto.Caption = "Valor Bruto";
            this.colVlBruto.FieldName = "vlBruto";
            this.colVlBruto.Name = "colVlBruto";
            this.colVlBruto.OptionsColumn.AllowEdit = false;
            this.colVlBruto.Visible = true;
            this.colVlBruto.VisibleIndex = 1;
            // 
            // colVlLiquido
            // 
            this.colVlLiquido.Caption = "Valor Liquido";
            this.colVlLiquido.FieldName = "vlLiquido";
            this.colVlLiquido.Name = "colVlLiquido";
            this.colVlLiquido.Visible = true;
            this.colVlLiquido.VisibleIndex = 2;
            // 
            // lblValor
            // 
            this.lblValor.Location = new System.Drawing.Point(71, 9);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(24, 13);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "valor";
            // 
            // btConfirmar
            // 
            this.btConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btConfirmar.Image")));
            this.btConfirmar.Location = new System.Drawing.Point(439, 4);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btConfirmar.TabIndex = 2;
            this.btConfirmar.Text = "Confirmar";
            // 
            // btCancelar
            // 
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.Location = new System.Drawing.Point(344, 4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 29);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.splitContainerControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(526, 291);
            this.splitContainerControl2.SplitterPosition = 184;
            this.splitContainerControl2.TabIndex = 3;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // groupControl1
            // 
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(526, 102);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Pagamentos";
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 349);
            this.Controls.Add(this.splitContainerControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.radioGroup);
            this.Name = "frmPagamento";
            this.Text = "Pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup radioGroup;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btCancelar;
        private DevExpress.XtraEditors.SimpleButton btConfirmar;
        private DevExpress.XtraEditors.LabelControl lblValor;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gcServico;
        private DevExpress.XtraGrid.Views.Grid.GridView gvServico;
        private DevExpress.XtraGrid.Columns.GridColumn colIdServico;
        private DevExpress.XtraGrid.Columns.GridColumn colServico;
        private DevExpress.XtraGrid.Columns.GridColumn colVlBruto;
        private DevExpress.XtraGrid.Columns.GridColumn colVlLiquido;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}