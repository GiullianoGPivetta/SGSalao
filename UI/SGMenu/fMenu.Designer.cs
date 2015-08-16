namespace SGMenu
{
    partial class fMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMenu));
            this.splitMDI = new DevExpress.XtraEditors.SplitContainerControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btConfig = new DevExpress.XtraEditors.SimpleButton();
            this.btFeed = new DevExpress.XtraEditors.SimpleButton();
            this.btDistribuidor = new DevExpress.XtraEditors.SimpleButton();
            this.btClientes = new DevExpress.XtraEditors.SimpleButton();
            this.btAgenda = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.brRelatorio = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitMDI)).BeginInit();
            this.splitMDI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // splitMDI
            // 
            this.splitMDI.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitMDI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMDI.Horizontal = false;
            this.splitMDI.IsSplitterFixed = true;
            this.splitMDI.Location = new System.Drawing.Point(0, 0);
            this.splitMDI.Name = "splitMDI";
            this.splitMDI.Panel1.Controls.Add(this.layoutControl1);
            this.splitMDI.Panel1.Text = "Painel1";
            this.splitMDI.Panel2.Appearance.BackColor = System.Drawing.Color.Silver;
            this.splitMDI.Panel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitMDI.Panel2.Appearance.Options.UseBackColor = true;
            this.splitMDI.Panel2.Appearance.Options.UseForeColor = true;
            this.splitMDI.Panel2.Text = "PainelMDI";
            this.splitMDI.Size = new System.Drawing.Size(908, 483);
            this.splitMDI.SplitterPosition = 60;
            this.splitMDI.TabIndex = 0;
            this.splitMDI.Text = "splitContainerControl1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.brRelatorio);
            this.layoutControl1.Controls.Add(this.btConfig);
            this.layoutControl1.Controls.Add(this.btFeed);
            this.layoutControl1.Controls.Add(this.btDistribuidor);
            this.layoutControl1.Controls.Add(this.btClientes);
            this.layoutControl1.Controls.Add(this.btAgenda);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(462, 226, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(904, 60);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btConfig
            // 
            this.btConfig.Image = ((System.Drawing.Image)(resources.GetObject("btConfig.Image")));
            this.btConfig.Location = new System.Drawing.Point(774, 3);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(127, 54);
            this.btConfig.StyleController = this.layoutControl1;
            this.btConfig.TabIndex = 8;
            this.btConfig.Text = "Gerencial";
            this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // btFeed
            // 
            this.btFeed.Image = ((System.Drawing.Image)(resources.GetObject("btFeed.Image")));
            this.btFeed.Location = new System.Drawing.Point(411, 3);
            this.btFeed.Name = "btFeed";
            this.btFeed.Size = new System.Drawing.Size(127, 54);
            this.btFeed.StyleController = this.layoutControl1;
            this.btFeed.TabIndex = 7;
            this.btFeed.Text = "Feed";
            // 
            // btDistribuidor
            // 
            this.btDistribuidor.Image = ((System.Drawing.Image)(resources.GetObject("btDistribuidor.Image")));
            this.btDistribuidor.Location = new System.Drawing.Point(275, 3);
            this.btDistribuidor.Name = "btDistribuidor";
            this.btDistribuidor.Size = new System.Drawing.Size(127, 54);
            this.btDistribuidor.StyleController = this.layoutControl1;
            this.btDistribuidor.TabIndex = 6;
            this.btDistribuidor.Text = "Distribuidores";
            this.btDistribuidor.Click += new System.EventHandler(this.btDistribuidor_Click);
            // 
            // btClientes
            // 
            this.btClientes.Image = ((System.Drawing.Image)(resources.GetObject("btClientes.Image")));
            this.btClientes.Location = new System.Drawing.Point(139, 3);
            this.btClientes.Name = "btClientes";
            this.btClientes.Size = new System.Drawing.Size(127, 53);
            this.btClientes.StyleController = this.layoutControl1;
            this.btClientes.TabIndex = 5;
            this.btClientes.Text = "Clientes";
            this.btClientes.Click += new System.EventHandler(this.btContatos_Click);
            // 
            // btAgenda
            // 
            this.btAgenda.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btAgenda.Appearance.Options.UseForeColor = true;
            this.btAgenda.Image = ((System.Drawing.Image)(resources.GetObject("btAgenda.Image")));
            this.btAgenda.Location = new System.Drawing.Point(3, 3);
            this.btAgenda.Name = "btAgenda";
            this.btAgenda.Size = new System.Drawing.Size(127, 53);
            this.btAgenda.StyleController = this.layoutControl1;
            this.btAgenda.TabIndex = 4;
            this.btAgenda.Text = "Agenda";
            this.btAgenda.Click += new System.EventHandler(this.btAgenda_Click);
            this.btAgenda.MouseEnter += new System.EventHandler(this.btAgenda_MouseEnter);
            this.btAgenda.MouseLeave += new System.EventHandler(this.btAgenda_MouseLeave);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceGroup.BackColor = System.Drawing.Color.SteelBlue;
            this.layoutControlGroup1.AppearanceGroup.Options.UseBackColor = true;
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.emptySpaceItem2,
            this.layoutControlItem3,
            this.emptySpaceItem3,
            this.layoutControlItem4,
            this.emptySpaceItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutControlGroup1.Size = new System.Drawing.Size(904, 60);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btAgenda;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(131, 57);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(131, 57);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(131, 58);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(131, 0);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(5, 0);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(5, 20);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.emptySpaceItem1.Size = new System.Drawing.Size(5, 58);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btClientes;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(136, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(131, 57);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(131, 57);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(131, 58);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(267, 0);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(5, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(5, 58);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btDistribuidor;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(272, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(131, 58);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(131, 58);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(131, 58);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(403, 0);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(5, 24);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(5, 58);
            this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btFeed;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(408, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(131, 58);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(131, 58);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(131, 58);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            this.emptySpaceItem4.Location = new System.Drawing.Point(675, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(96, 58);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btConfig;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(771, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(131, 58);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(131, 58);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(131, 58);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // brRelatorio
            // 
            this.brRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("brRelatorio.Image")));
            this.brRelatorio.Location = new System.Drawing.Point(547, 3);
            this.brRelatorio.Name = "brRelatorio";
            this.brRelatorio.Size = new System.Drawing.Size(127, 54);
            this.brRelatorio.StyleController = this.layoutControl1;
            this.brRelatorio.TabIndex = 9;
            this.brRelatorio.Text = "Relatórios";
            this.brRelatorio.Click += new System.EventHandler(this.brRelatorio_Click);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.brRelatorio;
            this.layoutControlItem6.Location = new System.Drawing.Point(544, 0);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(131, 58);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(131, 58);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(131, 58);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(539, 0);
            this.emptySpaceItem5.MaxSize = new System.Drawing.Size(5, 58);
            this.emptySpaceItem5.MinSize = new System.Drawing.Size(5, 58);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.emptySpaceItem5.Size = new System.Drawing.Size(5, 58);
            this.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 483);
            this.Controls.Add(this.splitMDI);
            this.IsMdiContainer = true;
            this.Name = "fMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gerenciador de Salão";
            ((System.ComponentModel.ISupportInitialize)(this.splitMDI)).EndInit();
            this.splitMDI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitMDI;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btClientes;
        private DevExpress.XtraEditors.SimpleButton btAgenda;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton btDistribuidor;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.SimpleButton btFeed;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.SimpleButton btConfig;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton brRelatorio;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
    }
}

