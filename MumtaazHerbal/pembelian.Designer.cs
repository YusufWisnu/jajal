namespace MumtaazHerbal
{
    partial class pembelian
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pembelian));
            this.txtTimer = new DevExpress.XtraEditors.TextEdit();
            this.txtuser = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTanggal = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTransaksi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.No = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KodeItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NamaItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JumlahBarang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Satuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HargaBarang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDaftarItem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtKodeItem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtJumlah = new DevExpress.XtraEditors.TextEdit();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.btnHapus = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lookSupplier = new DevExpress.XtraEditors.LookUpEdit();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAlamat = new DevExpress.XtraEditors.LabelControl();
            this.lblNo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtuser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransaksi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKodeItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJumlah.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimer
            // 
            this.txtTimer.Location = new System.Drawing.Point(235, 42);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(71, 20);
            this.txtTimer.TabIndex = 32;
            // 
            // txtuser
            // 
            this.txtuser.EditValue = "";
            this.txtuser.Enabled = false;
            this.txtuser.Location = new System.Drawing.Point(235, 19);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(71, 20);
            this.txtuser.TabIndex = 31;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(44, 69);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 29;
            this.labelControl3.Text = "Supplier :";
            // 
            // txtTanggal
            // 
            this.txtTanggal.EditValue = null;
            this.txtTanggal.Location = new System.Drawing.Point(95, 42);
            this.txtTanggal.Name = "txtTanggal";
            this.txtTanggal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTanggal.Size = new System.Drawing.Size(134, 20);
            this.txtTanggal.TabIndex = 28;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(44, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "Tanggal :";
            // 
            // txtTransaksi
            // 
            this.txtTransaksi.Location = new System.Drawing.Point(95, 19);
            this.txtTransaksi.Name = "txtTransaksi";
            this.txtTransaksi.Size = new System.Drawing.Size(134, 20);
            this.txtTransaksi.TabIndex = 26;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "No Transaksi :";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(10, 154);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1326, 347);
            this.gridControl1.TabIndex = 34;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.No,
            this.KodeItem,
            this.NamaItem,
            this.JumlahBarang,
            this.Satuan,
            this.HargaBarang,
            this.Total});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // No
            // 
            this.No.AppearanceHeader.Options.UseTextOptions = true;
            this.No.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.No.Caption = "No";
            this.No.FieldName = "No";
            this.No.Name = "No";
            this.No.Visible = true;
            this.No.VisibleIndex = 0;
            this.No.Width = 70;
            // 
            // KodeItem
            // 
            this.KodeItem.AppearanceHeader.Options.UseTextOptions = true;
            this.KodeItem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.KodeItem.Caption = "Kode Item";
            this.KodeItem.FieldName = "KodeItem";
            this.KodeItem.Name = "KodeItem";
            this.KodeItem.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.KodeItem.Visible = true;
            this.KodeItem.VisibleIndex = 1;
            this.KodeItem.Width = 124;
            // 
            // NamaItem
            // 
            this.NamaItem.AppearanceHeader.Options.UseTextOptions = true;
            this.NamaItem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NamaItem.Caption = "Nama Item";
            this.NamaItem.FieldName = "NamaItem";
            this.NamaItem.Name = "NamaItem";
            this.NamaItem.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.NamaItem.Visible = true;
            this.NamaItem.VisibleIndex = 2;
            this.NamaItem.Width = 453;
            // 
            // JumlahBarang
            // 
            this.JumlahBarang.AppearanceHeader.Options.UseTextOptions = true;
            this.JumlahBarang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JumlahBarang.Caption = "Jumlah";
            this.JumlahBarang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.JumlahBarang.FieldName = "JumlahBarang";
            this.JumlahBarang.Name = "JumlahBarang";
            this.JumlahBarang.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.JumlahBarang.Visible = true;
            this.JumlahBarang.VisibleIndex = 3;
            this.JumlahBarang.Width = 96;
            // 
            // Satuan
            // 
            this.Satuan.AppearanceHeader.Options.UseTextOptions = true;
            this.Satuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Satuan.Caption = "Satuan";
            this.Satuan.FieldName = "Satuan";
            this.Satuan.Name = "Satuan";
            this.Satuan.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Satuan.Visible = true;
            this.Satuan.VisibleIndex = 4;
            this.Satuan.Width = 66;
            // 
            // HargaBarang
            // 
            this.HargaBarang.AppearanceHeader.Options.UseTextOptions = true;
            this.HargaBarang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HargaBarang.Caption = "Harga";
            this.HargaBarang.ColumnEdit = this.repositoryItemTextEdit1;
            this.HargaBarang.FieldName = "HargaBarang";
            this.HargaBarang.Name = "HargaBarang";
            this.HargaBarang.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.HargaBarang.Visible = true;
            this.HargaBarang.VisibleIndex = 5;
            this.HargaBarang.Width = 248;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n";
            this.repositoryItemTextEdit1.Mask.IgnoreMaskBlank = false;
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // Total
            // 
            this.Total.AppearanceHeader.Options.UseTextOptions = true;
            this.Total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Total.Caption = "Total";
            this.Total.ColumnEdit = this.repositoryItemTextEdit1;
            this.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Total.FieldName = "Total";
            this.Total.Name = "Total";
            this.Total.OptionsColumn.AllowEdit = false;
            this.Total.UnboundExpression = "[Jumlah] * [Harga]";
            this.Total.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Total.Visible = true;
            this.Total.VisibleIndex = 6;
            this.Total.Width = 251;
            // 
            // btnDaftarItem
            // 
            this.btnDaftarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDaftarItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDaftarItem.ImageOptions.Image")));
            this.btnDaftarItem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnDaftarItem.Location = new System.Drawing.Point(471, 128);
            this.btnDaftarItem.Name = "btnDaftarItem";
            this.btnDaftarItem.Size = new System.Drawing.Size(46, 20);
            this.btnDaftarItem.TabIndex = 39;
            this.btnDaftarItem.Click += new System.EventHandler(this.btnDaftarItem_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(206, 131);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 13);
            this.labelControl5.TabIndex = 38;
            this.labelControl5.Text = "Kode Item :";
            // 
            // txtKodeItem
            // 
            this.txtKodeItem.Location = new System.Drawing.Point(268, 128);
            this.txtKodeItem.Name = "txtKodeItem";
            this.txtKodeItem.Size = new System.Drawing.Size(197, 20);
            this.txtKodeItem.TabIndex = 37;
            this.txtKodeItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKodeItem_KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(49, 131);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 36;
            this.labelControl4.Text = "Jumlah :";
            // 
            // txtJumlah
            // 
            this.txtJumlah.EditValue = "1";
            this.txtJumlah.Location = new System.Drawing.Point(95, 128);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Properties.Appearance.Options.UseTextOptions = true;
            this.txtJumlah.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtJumlah.Properties.Mask.EditMask = "d";
            this.txtJumlah.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtJumlah.Size = new System.Drawing.Size(100, 20);
            this.txtJumlah.TabIndex = 35;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.EditValue = "";
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(345, 18);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.Appearance.Options.UseForeColor = true;
            this.txtTotal.Properties.AutoHeight = false;
            this.txtTotal.Properties.Mask.EditMask = "n0";
            this.txtTotal.Properties.Mask.IgnoreMaskBlank = false;
            this.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotal.Properties.NullText = "0";
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.Size = new System.Drawing.Size(993, 95);
            this.txtTotal.TabIndex = 40;
            // 
            // btnHapus
            // 
            this.btnHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHapus.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHapus.ImageOptions.Image")));
            this.btnHapus.Location = new System.Drawing.Point(95, 507);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(85, 25);
            this.btnHapus.TabIndex = 44;
            this.btnHapus.Text = "Hapus Item";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(186, 507);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(76, 25);
            this.simpleButton4.TabIndex = 43;
            this.simpleButton4.Text = "Bayar";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(10, 507);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 25);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Batal";
            // 
            // lookSupplier
            // 
            this.lookSupplier.Location = new System.Drawing.Point(95, 66);
            this.lookSupplier.Name = "lookSupplier";
            this.lookSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookSupplier.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KodeSupplier", "Kode Supplier", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NamaSupplier", "Nama Supplier", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookSupplier.Properties.DataSource = this.supplierBindingSource;
            this.lookSupplier.Properties.DisplayMember = "NamaSupplier";
            this.lookSupplier.Properties.NullText = "";
            this.lookSupplier.Properties.ValueMember = "Id";
            this.lookSupplier.Size = new System.Drawing.Size(134, 20);
            this.lookSupplier.TabIndex = 45;
            this.lookSupplier.EditValueChanged += new System.EventHandler(this.lookSupplier_EditValueChanged);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(MumtaazHerbal.Supplier);
            // 
            // lblAlamat
            // 
            this.lblAlamat.Location = new System.Drawing.Point(95, 90);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(43, 13);
            this.lblAlamat.TabIndex = 46;
            this.lblAlamat.Text = "lblAlamat";
            // 
            // lblNo
            // 
            this.lblNo.Location = new System.Drawing.Point(95, 109);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(23, 13);
            this.lblNo.TabIndex = 47;
            this.lblNo.Text = "lblNo";
            // 
            // pembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 539);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.lookSupplier);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnDaftarItem);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtKodeItem);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtTanggal);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtTransaksi);
            this.Controls.Add(this.labelControl1);
            this.Name = "pembelian";
            this.Text = "Pembelian";
            this.Load += new System.EventHandler(this.pembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTimer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtuser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransaksi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKodeItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJumlah.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtTimer;
        private DevExpress.XtraEditors.TextEdit txtuser;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit txtTanggal;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTransaksi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn No;
        private DevExpress.XtraGrid.Columns.GridColumn KodeItem;
        private DevExpress.XtraGrid.Columns.GridColumn NamaItem;
        private DevExpress.XtraGrid.Columns.GridColumn JumlahBarang;
        private DevExpress.XtraGrid.Columns.GridColumn Satuan;
        private DevExpress.XtraGrid.Columns.GridColumn HargaBarang;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraEditors.SimpleButton btnDaftarItem;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtKodeItem;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.TextEdit txtJumlah;
        public DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.SimpleButton btnHapus;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        public DevExpress.XtraEditors.LookUpEdit lookSupplier;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private DevExpress.XtraEditors.LabelControl lblAlamat;
        private DevExpress.XtraEditors.LabelControl lblNo;
    }
}