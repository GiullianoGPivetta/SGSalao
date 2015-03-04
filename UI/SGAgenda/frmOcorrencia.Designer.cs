namespace SGAgenda
{
    partial class frmOcorrencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOcorrencia));
            this.gcOcorrencias = new DevExpress.XtraGrid.GridControl();
            this.gvOcorrencias = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btSair = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcOcorrencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOcorrencias)).BeginInit();
            this.SuspendLayout();
            // 
            // gcOcorrencias
            // 
            this.gcOcorrencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcOcorrencias.Location = new System.Drawing.Point(4, 4);
            this.gcOcorrencias.MainView = this.gvOcorrencias;
            this.gcOcorrencias.Name = "gcOcorrencias";
            this.gcOcorrencias.Size = new System.Drawing.Size(463, 256);
            this.gcOcorrencias.TabIndex = 0;
            this.gcOcorrencias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOcorrencias});
            // 
            // gvOcorrencias
            // 
            this.gvOcorrencias.GridControl = this.gcOcorrencias;
            this.gvOcorrencias.Name = "gvOcorrencias";
            this.gvOcorrencias.OptionsView.ShowGroupPanel = false;
            // 
            // btSair
            // 
            this.btSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.Location = new System.Drawing.Point(384, 266);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 1;
            this.btSair.Text = "Fechar";
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // frmOcorrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 294);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.gcOcorrencias);
            this.Name = "frmOcorrencia";
            this.Text = "Ocorrências";
            ((System.ComponentModel.ISupportInitialize)(this.gcOcorrencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOcorrencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcOcorrencias;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOcorrencias;
        private DevExpress.XtraEditors.SimpleButton btSair;
    }
}