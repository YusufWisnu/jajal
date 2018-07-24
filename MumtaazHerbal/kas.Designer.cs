namespace MumtaazHerbal
{
    partial class kas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kas));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            this.btnHapus = new DevExpress.XtraEditors.SimpleButton();
            this.btnBayar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.No = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTxtNo = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Keterangan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTxtTotal = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtTanggal = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTransaksi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtKeterangan = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransaksi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeterangan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHapus
            // 
            this.btnHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHapus.Location = new System.Drawing.Point(12, 441);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(85, 25);
            this.btnHapus.TabIndex = 2;
            this.btnHapus.Text = "Hapus Detail";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnBayar
            // 
            this.btnBayar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBayar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBayar.ImageOptions.Image")));
            this.btnBayar.Location = new System.Drawing.Point(96, 501);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(76, 25);
            this.btnBayar.TabIndex = 6;
            this.btnBayar.Text = "Simpan";
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(11, 501);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 25);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Batal";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gridLevelNode1.RelationName = "Level1";
            gridLevelNode2.RelationName = "Level2";
            gridLevelNode3.RelationName = "Level3";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2,
            gridLevelNode3});
            this.gridControl1.Location = new System.Drawing.Point(11, 99);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repTxtTotal,
            this.repTxtNo});
            this.gridControl1.Size = new System.Drawing.Size(1326, 336);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.No,
            this.Keterangan,
            this.Total});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // No
            // 
            this.No.AppearanceCell.Options.UseTextOptions = true;
            this.No.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.No.Caption = "No";
            this.No.ColumnEdit = this.repTxtNo;
            this.No.FieldName = "No";
            this.No.Name = "No";
            this.No.OptionsColumn.AllowEdit = false;
            this.No.OptionsColumn.AllowFocus = false;
            this.No.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.No.Visible = true;
            this.No.VisibleIndex = 0;
            this.No.Width = 40;
            // 
            // repTxtNo
            // 
            this.repTxtNo.AutoHeight = false;
            this.repTxtNo.Mask.EditMask = "n0";
            this.repTxtNo.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repTxtNo.Mask.UseMaskAsDisplayFormat = true;
            this.repTxtNo.Name = "repTxtNo";
            this.repTxtNo.ReadOnly = true;
            // 
            // Keterangan
            // 
            this.Keterangan.Caption = "Detail Keterangan";
            this.Keterangan.FieldName = "Keterangan";
            this.Keterangan.Name = "Keterangan";
            this.Keterangan.Visible = true;
            this.Keterangan.VisibleIndex = 1;
            this.Keterangan.Width = 1067;
            // 
            // Total
            // 
            this.Total.Caption = "Total";
            this.Total.ColumnEdit = this.repTxtTotal;
            this.Total.DisplayFormat.FormatString = "n0";
            this.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Total.FieldName = "Total";
            this.Total.Name = "Total";
            this.Total.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Total.Visible = true;
            this.Total.VisibleIndex = 2;
            this.Total.Width = 201;
            // 
            // repTxtTotal
            // 
            this.repTxtTotal.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repTxtTotal.AutoHeight = false;
            this.repTxtTotal.DisplayFormat.FormatString = "n0";
            this.repTxtTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repTxtTotal.EditFormat.FormatString = "n0";
            this.repTxtTotal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repTxtTotal.Mask.EditMask = "n0";
            this.repTxtTotal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repTxtTotal.Mask.UseMaskAsDisplayFormat = true;
            this.repTxtTotal.Name = "repTxtTotal";
            this.repTxtTotal.NullText = "0";
            this.repTxtTotal.NullValuePrompt = "0";
            this.repTxtTotal.NullValuePromptShowForEmptyValue = true;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n";
            this.repositoryItemTextEdit1.Mask.IgnoreMaskBlank = false;
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.DisplayFormat.FormatString = "n";
            this.repositoryItemTextEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit2.Mask.EditMask = "n";
            this.repositoryItemTextEdit2.Mask.IgnoreMaskBlank = false;
            this.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // txtTanggal
            // 
            this.txtTanggal.EditValue = null;
            this.txtTanggal.Location = new System.Drawing.Point(96, 36);
            this.txtTanggal.Name = "txtTanggal";
            this.txtTanggal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTanggal.Size = new System.Drawing.Size(134, 20);
            this.txtTanggal.TabIndex = 51;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(45, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 50;
            this.labelControl2.Text = "Tanggal :";
            // 
            // txtTransaksi
            // 
            this.txtTransaksi.Location = new System.Drawing.Point(96, 13);
            this.txtTransaksi.Name = "txtTransaksi";
            this.txtTransaksi.Size = new System.Drawing.Size(134, 20);
            this.txtTransaksi.TabIndex = 49;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 48;
            this.labelControl1.Text = "No Transaksi :";
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Location = new System.Drawing.Point(96, 62);
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(245, 31);
            this.txtKeterangan.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(27, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 13);
            this.labelControl3.TabIndex = 66;
            this.labelControl3.Text = "Keterangan :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(1055, 461);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 19);
            this.labelControl4.TabIndex = 67;
            this.labelControl4.Text = "Total :";
            // 
            // txtTotal
            // 
            this.txtTotal.EditValue = "";
            this.txtTotal.Location = new System.Drawing.Point(1141, 455);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.Appearance.Options.UseForeColor = true;
            this.txtTotal.Properties.AutoHeight = false;
            this.txtTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotal.Properties.Mask.EditMask = "###0,#####";
            this.txtTotal.Properties.Mask.IgnoreMaskBlank = false;
            this.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.Size = new System.Drawing.Size(196, 31);
            this.txtTotal.TabIndex = 68;
            // 
            // kas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 539);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtTanggal);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtTransaksi);
            this.Controls.Add(this.labelControl1);
            this.Name = "kas";
            this.Text = "Kas Keluar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kas_FormClosing);
            this.Load += new System.EventHandler(this.kas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransaksi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeterangan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHapus;
        private DevExpress.XtraEditors.SimpleButton btnBayar;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.DateEdit txtTanggal;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.TextEdit txtTransaksi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn No;
        private DevExpress.XtraGrid.Columns.GridColumn Keterangan;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTxtTotal;
        private DevExpress.XtraEditors.MemoEdit txtKeterangan;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTxtNo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.TextEdit txtTotal;
    }
}