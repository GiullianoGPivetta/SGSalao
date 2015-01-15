using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace SGAgenda
{
    partial class frmDetalheAgenda : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalheAgenda));
            this.btGravar = new DevExpress.XtraEditors.SimpleButton();
            this.cboSituacao = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtComentario = new DevExpress.XtraEditors.MemoEdit();
            this.bteCliente = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.cboProfissional = new DevExpress.XtraEditors.LookUpEdit();
            this.lblProfissional = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblDataHoraAgenda = new DevExpress.XtraEditors.LabelControl();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lblValor = new DevExpress.XtraEditors.LabelControl();
            this.gcServicos = new DevExpress.XtraGrid.GridControl();
            this.gvServicos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdServico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltempo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cboSituacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProfissional.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // btGravar
            // 
            this.btGravar.Image = ((System.Drawing.Image)(resources.GetObject("btGravar.Image")));
            this.btGravar.Location = new System.Drawing.Point(275, 330);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(107, 38);
            this.btGravar.TabIndex = 5;
            this.btGravar.Text = "Gravar";
            this.btGravar.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cboSituacao
            // 
            this.cboSituacao.Location = new System.Drawing.Point(291, 85);
            this.cboSituacao.Name = "cboSituacao";
            this.cboSituacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSituacao.Size = new System.Drawing.Size(91, 20);
            this.cboSituacao.TabIndex = 2;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(9, 281);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Properties.MaxLength = 50;
            this.txtComentario.Size = new System.Drawing.Size(373, 43);
            this.txtComentario.TabIndex = 4;
            // 
            // bteCliente
            // 
            this.bteCliente.Location = new System.Drawing.Point(73, 59);
            this.bteCliente.Name = "bteCliente";
            this.bteCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteCliente.Size = new System.Drawing.Size(309, 20);
            this.bteCliente.TabIndex = 1;
            this.bteCliente.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteCliente_ButtonClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(394, 25);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Detalhes da Agenda";
            // 
            // btCancelar
            // 
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.Location = new System.Drawing.Point(9, 330);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(107, 38);
            this.btCancelar.TabIndex = 6;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // cboProfissional
            // 
            this.cboProfissional.Location = new System.Drawing.Point(73, 33);
            this.cboProfissional.Name = "cboProfissional";
            this.cboProfissional.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboProfissional.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdProfissional", "IdProfissional", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome")});
            this.cboProfissional.Properties.DisplayMember = "Nome";
            this.cboProfissional.Properties.NullText = "";
            this.cboProfissional.Properties.ValueMember = "IdProfissional";
            this.cboProfissional.Size = new System.Drawing.Size(309, 20);
            this.cboProfissional.TabIndex = 0;
            // 
            // lblProfissional
            // 
            this.lblProfissional.Location = new System.Drawing.Point(9, 36);
            this.lblProfissional.Name = "lblProfissional";
            this.lblProfissional.Size = new System.Drawing.Size(58, 13);
            this.lblProfissional.TabIndex = 10;
            this.lblProfissional.Text = "Profissional:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Cliente:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 88);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(94, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Horário da Agenda:";
            // 
            // lblDataHoraAgenda
            // 
            this.lblDataHoraAgenda.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDataHoraAgenda.Location = new System.Drawing.Point(109, 88);
            this.lblDataHoraAgenda.Name = "lblDataHoraAgenda";
            this.lblDataHoraAgenda.Size = new System.Drawing.Size(75, 13);
            this.lblDataHoraAgenda.TabIndex = 13;
            this.lblDataHoraAgenda.Text = "labelControl4";
            this.lblDataHoraAgenda.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(250, 88);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Status:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 262);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 13);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Comentários:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(9, 113);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 13);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Serviços:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(250, 113);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 13);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "Valor:";
            // 
            // lblValor
            // 
            this.lblValor.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblValor.Location = new System.Drawing.Point(291, 113);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(42, 13);
            this.lblValor.TabIndex = 19;
            this.lblValor.Text = "lblValor";
            // 
            // gcServicos
            // 
            this.gcServicos.Location = new System.Drawing.Point(9, 132);
            this.gcServicos.MainView = this.gvServicos;
            this.gcServicos.Name = "gcServicos";
            this.gcServicos.Size = new System.Drawing.Size(373, 124);
            this.gcServicos.TabIndex = 20;
            this.gcServicos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvServicos});
            // 
            // gvServicos
            // 
            this.gvServicos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdServico,
            this.colDescricao,
            this.coltempo,
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
            // colDescricao
            // 
            this.colDescricao.Caption = "Descrição";
            this.colDescricao.FieldName = "Descricao";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.Visible = true;
            this.colDescricao.VisibleIndex = 0;
            this.colDescricao.Width = 601;
            // 
            // colValor
            // 
            this.colValor.Caption = "Valor";
            this.colValor.DisplayFormat.FormatString = "c";
            this.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colValor.FieldName = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.Visible = true;
            this.colValor.VisibleIndex = 2;
            this.colValor.Width = 92;
            // 
            // coltempo
            // 
            this.coltempo.Caption = "Tempo";
            this.coltempo.FieldName = "Tempo";
            this.coltempo.Name = "coltempo";
            this.coltempo.Visible = true;
            this.coltempo.VisibleIndex = 1;
            this.coltempo.Width = 88;
            // 
            // frmDetalheAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 372);
            this.Controls.Add(this.gcServicos);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDataHoraAgenda);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblProfissional);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cboProfissional);
            this.Controls.Add(this.bteCliente);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.cboSituacao);
            this.Name = "frmDetalheAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDetalheAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboSituacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProfissional.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btGravar;
        private DevExpress.XtraEditors.ButtonEdit bteCliente;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btCancelar;
        private DevExpress.XtraEditors.LookUpEdit cboProfissional;
        private DevExpress.XtraEditors.MemoEdit txtComentario;
        private DevExpress.XtraEditors.ComboBoxEdit cboSituacao;
        private DevExpress.XtraEditors.LabelControl lblProfissional;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblDataHoraAgenda;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lblValor;
        private DevExpress.XtraGrid.GridControl gcServicos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvServicos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdServico;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn coltempo;
        private DevExpress.XtraGrid.Columns.GridColumn colValor;
    }
}