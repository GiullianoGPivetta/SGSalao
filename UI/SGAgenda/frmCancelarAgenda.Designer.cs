namespace SGAgenda
{
    partial class frmCancelarAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelarAgenda));
            this.lbTitulo = new DevExpress.XtraEditors.LabelControl();
            this.memoJust = new DevExpress.XtraEditors.MemoEdit();
            this.btConfirmar = new DevExpress.XtraEditors.SimpleButton();
            this.btCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.memoJust.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lbTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbTitulo.Location = new System.Drawing.Point(4, 1);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(394, 38);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Você tem certeza que deseja cancelar este agendamento? É necessário informar uma " +
    "justificativa para cancelar.";
            // 
            // memoJust
            // 
            this.memoJust.Location = new System.Drawing.Point(4, 41);
            this.memoJust.Name = "memoJust";
            this.memoJust.Properties.MaxLength = 50;
            this.memoJust.Size = new System.Drawing.Size(394, 34);
            this.memoJust.TabIndex = 1;
            // 
            // btConfirmar
            // 
            this.btConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btConfirmar.Image")));
            this.btConfirmar.Location = new System.Drawing.Point(286, 81);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btConfirmar.TabIndex = 2;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.Location = new System.Drawing.Point(29, 81);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // frmCancelarAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 106);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.memoJust);
            this.Controls.Add(this.lbTitulo);
            this.MaximumSize = new System.Drawing.Size(417, 145);
            this.MinimumSize = new System.Drawing.Size(417, 145);
            this.Name = "frmCancelarAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelamento de Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.memoJust.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbTitulo;
        private DevExpress.XtraEditors.MemoEdit memoJust;
        private DevExpress.XtraEditors.SimpleButton btConfirmar;
        private DevExpress.XtraEditors.SimpleButton btCancelar;
    }
}