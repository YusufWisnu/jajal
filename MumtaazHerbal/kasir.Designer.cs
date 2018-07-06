namespace MumtaazHerbal
{
    partial class kasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kasir));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTransaksi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTanggal = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtuser = new DevExpress.XtraEditors.TextEdit();
            this.txtTimer = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtJumlah = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtKodeItem = new DevExpress.XtraEditors.TextEdit();
            this.btnDaftarItem = new DevExpress.XtraEditors.SimpleButton();
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.btnHapus = new DevExpress.XtraEditors.SimpleButton();
            this.btnPending = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.lookPelanggan = new DevExpress.XtraEditors.LookUpEdit();
            this.pelangganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtTransaksi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtuser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJumlah.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKodeItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookPelanggan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "No Transaksi :";
            // 
            // txtTransaksi
            // 
            this.txtTransaksi.Location = new System.Drawing.Point(95, 18);
            this.txtTransaksi.Name = "txtTransaksi";
            this.txtTransaksi.Size = new System.Drawing.Size(134, 20);
            this.txtTransaksi.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(47, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tanggal :";
            // 
            // txtTanggal
            // 
            this.txtTanggal.EditValue = null;
            this.txtTanggal.Location = new System.Drawing.Point(95, 41);
            this.txtTanggal.Name = "txtTanggal";
            this.txtTanggal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTanggal.Size = new System.Drawing.Size(134, 20);
            this.txtTanggal.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(35, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Pelanggan :";
            // 
            // txtuser
            // 
            this.txtuser.EditValue = "";
            this.txtuser.Enabled = false;
            this.txtuser.Location = new System.Drawing.Point(235, 18);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(71, 20);
            this.txtuser.TabIndex = 7;
            // 
            // txtTimer
            // 
            this.txtTimer.Enabled = false;
            this.txtTimer.Location = new System.Drawing.Point(235, 41);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Properties.Mask.EditMask = "T";
            this.txtTimer.Size = new System.Drawing.Size(71, 20);
            this.txtTimer.TabIndex = 8;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(312, 18);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(0, 20);
            this.textEdit3.TabIndex = 25;
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
            this.txtTotal.TabIndex = 26;
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
            this.txtJumlah.TabIndex = 28;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(52, 131);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 29;
            this.labelControl4.Text = "Jumlah :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(206, 131);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 13);
            this.labelControl5.TabIndex = 31;
            this.labelControl5.Text = "Kode Item :";
            // 
            // txtKodeItem
            // 
            this.txtKodeItem.Location = new System.Drawing.Point(268, 128);
            this.txtKodeItem.Name = "txtKodeItem";
            this.txtKodeItem.Size = new System.Drawing.Size(197, 20);
            this.txtKodeItem.TabIndex = 30;
            this.txtKodeItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit6_KeyPress);
            // 
            // btnDaftarItem
            // 
            this.btnDaftarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDaftarItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDaftarItem.ImageOptions.Image")));
            this.btnDaftarItem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnDaftarItem.Location = new System.Drawing.Point(471, 128);
            this.btnDaftarItem.Name = "btnDaftarItem";
            this.btnDaftarItem.Size = new System.Drawing.Size(46, 20);
            this.btnDaftarItem.TabIndex = 32;
            this.btnDaftarItem.Click += new System.EventHandler(this.btnDaftarItem_Click);
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
            this.gridControl1.TabIndex = 33;
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
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(10, 507);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 25);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Batal";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(186, 507);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(76, 25);
            this.simpleButton4.TabIndex = 38;
            this.simpleButton4.Text = "Bayar";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHapus.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHapus.ImageOptions.Image")));
            this.btnHapus.Location = new System.Drawing.Point(95, 507);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(85, 25);
            this.btnHapus.TabIndex = 39;
            this.btnHapus.Text = "Hapus Item";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnPending
            // 
            this.btnPending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPending.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPending.ImageOptions.Image")));
            this.btnPending.Location = new System.Drawing.Point(268, 507);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(76, 25);
            this.btnPending.TabIndex = 40;
            this.btnPending.Text = "Pending";
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            this.simpleButton6.Location = new System.Drawing.Point(350, 507);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(104, 25);
            this.simpleButton6.TabIndex = 41;
            this.simpleButton6.Text = "Dft. Pending";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // lookPelanggan
            // 
            this.lookPelanggan.Location = new System.Drawing.Point(95, 67);
            this.lookPelanggan.Name = "lookPelanggan";
            this.lookPelanggan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookPelanggan.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KodePelanggan", "Kode Pelanggan", 87, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookPelanggan.Properties.DataSource = this.pelangganBindingSource;
            this.lookPelanggan.Properties.DisplayMember = "Nama";
            this.lookPelanggan.Properties.NullText = "";
            this.lookPelanggan.Properties.ValueMember = "Id";
            this.lookPelanggan.Size = new System.Drawing.Size(134, 20);
            this.lookPelanggan.TabIndex = 42;
            this.lookPelanggan.EditValueChanged += new System.EventHandler(this.lookPelanggan_EditValueChanged);
            // 
            // pelangganBindingSource
            // 
            this.pelangganBindingSource.DataSource = typeof(MumtaazHerbal.Pelanggan);
            // 
            // kasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 539);
            this.Controls.Add(this.lookPelanggan);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.btnPending);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnDaftarItem);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtKodeItem);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtTanggal);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtTransaksi);
            this.Controls.Add(this.labelControl1);
            this.Name = "kasir";
            this.Text = "Kasir";
            this.Load += new System.EventHandler(this.kasir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTransaksi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtuser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJumlah.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKodeItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookPelanggan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtuser;
        private DevExpress.XtraEditors.TextEdit txtTimer;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtKodeItem;
        private DevExpress.XtraEditors.SimpleButton btnDaftarItem;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton btnHapus;
        private DevExpress.XtraEditors.SimpleButton btnPending;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraGrid.Columns.GridColumn No;
        private DevExpress.XtraGrid.Columns.GridColumn KodeItem;
        private DevExpress.XtraGrid.Columns.GridColumn NamaItem;
        private DevExpress.XtraGrid.Columns.GridColumn JumlahBarang;
        private DevExpress.XtraGrid.Columns.GridColumn Satuan;
        private DevExpress.XtraGrid.Columns.GridColumn HargaBarang;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private System.Windows.Forms.BindingSource pelangganBindingSource;
        public DevExpress.XtraEditors.LookUpEdit lookPelanggan;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        public DevExpress.XtraEditors.TextEdit txtTotal;
        public DevExpress.XtraEditors.TextEdit txtTransaksi;
        public DevExpress.XtraEditors.TextEdit txtJumlah;
        public DevExpress.XtraEditors.DateEdit txtTanggal;
    }
}