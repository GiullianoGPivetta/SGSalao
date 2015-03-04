namespace SGServicos
{
    partial class frmServicoDetalhe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServicoDetalhe));
            this.lblDescricao = new DevExpress.XtraEditors.LabelControl();
            this.txtDesc = new DevExpress.XtraEditors.TextEdit();
            this.txtValor = new DevExpress.XtraEditors.TextEdit();
            this.lblValor = new DevExpress.XtraEditors.LabelControl();
            this.lblTempo = new DevExpress.XtraEditors.LabelControl();
            this.spTempo = new DevExpress.XtraEditors.SpinEdit();
            this.cboStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            this.btCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.dxErro = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTempo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.Location = new System.Drawing.Point(12, 21);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(50, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(68, 18);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Properties.MaxLength = 25;
            this.txtDesc.Size = new System.Drawing.Size(204, 20);
            this.txtDesc.TabIndex = 0;
            // 
            // txtValor
            // 
            this.txtValor.EditValue = "0";
            this.txtValor.Location = new System.Drawing.Point(68, 92);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Mask.EditMask = "c";
            this.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 2;
            // 
            // lblValor
            // 
            this.lblValor.Location = new System.Drawing.Point(12, 95);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(28, 13);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor:";
            // 
            // lblTempo
            // 
            this.lblTempo.Location = new System.Drawing.Point(12, 58);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(36, 13);
            this.lblTempo.TabIndex = 4;
            this.lblTempo.Text = "Tempo:";
            // 
            // spTempo
            // 
            this.spTempo.EditValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.spTempo.Location = new System.Drawing.Point(68, 55);
            this.spTempo.Name = "spTempo";
            this.spTempo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spTempo.Properties.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.spTempo.Properties.Mask.EditMask = "t";
            this.spTempo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.spTempo.Properties.MaxValue = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.spTempo.Properties.MinValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.spTempo.Size = new System.Drawing.Size(100, 20);
            this.spTempo.TabIndex = 1;
            // 
            // cboStatus
            // 
            this.cboStatus.EditValue = "Ativo";
            this.cboStatus.Location = new System.Drawing.Point(68, 129);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStatus.Properties.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cboStatus.Size = new System.Drawing.Size(100, 20);
            this.cboStatus.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(12, 132);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status:";
            // 
            // btCancelar
            // 
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.Location = new System.Drawing.Point(183, 115);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(89, 35);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btSalvar.Image")));
            this.btSalvar.Location = new System.Drawing.Point(183, 58);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(89, 35);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // dxErro
            // 
            this.dxErro.ContainerControl = this;
            // 
            // frmServicoDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.spTempo);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDescricao);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 200);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "frmServicoDetalhe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes do Serviço";
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTempo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblDescricao;
        private DevExpress.XtraEditors.TextEdit txtDesc;
        private DevExpress.XtraEditors.TextEdit txtValor;
        private DevExpress.XtraEditors.LabelControl lblValor;
        private DevExpress.XtraEditors.LabelControl lblTempo;
        private DevExpress.XtraEditors.SpinEdit spTempo;
        private DevExpress.XtraEditors.ComboBoxEdit cboStatus;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.SimpleButton btCancelar;
        private DevExpress.XtraEditors.SimpleButton btSalvar;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErro;
    }
}