namespace MumtaazHerbal
{
    partial class historyPenjualan
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
            this.lookPelanggan = new DevExpress.XtraEditors.LookUpEdit();
            this.pelangganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KodePelanggan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoTransaksi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tanggal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.KodeItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NamaItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Satuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HargaBarang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tglSesudah = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tglSebelum = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lookPelanggan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglSesudah.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglSesudah.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglSebelum.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglSebelum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookPelanggan
            // 
            this.lookPelanggan.Location = new System.Drawing.Point(69, 64);
            this.lookPelanggan.Name = "lookPelanggan";
            this.lookPelanggan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookPelanggan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookPelanggan.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KodePelanggan", "Kode Pelanggan", 87, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookPelanggan.Properties.DataSource = this.pelangganBindingSource;
            this.lookPelanggan.Properties.DisplayMember = "Nama";
            this.lookPelanggan.Properties.NullText = "";
            this.lookPelanggan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookPelanggan.Properties.ValueMember = "Id";
            this.lookPelanggan.Size = new System.Drawing.Size(100, 20);
            this.lookPelanggan.TabIndex = 60;
            this.lookPelanggan.EditValueChanged += new System.EventHandler(this.lookPelanggan_EditValueChanged);
            this.lookPelanggan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lookPelanggan_KeyDown);
            // 
            // pelangganBindingSource
            // 
            this.pelangganBindingSource.DataSource = typeof(MumtaazHerbal.Pelanggan);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(18, 90);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemDateEdit1});
            this.gridControl1.Size = new System.Drawing.Size(749, 262);
            this.gridControl1.TabIndex = 59;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.KodePelanggan,
            this.Nama,
            this.NoTransaksi,
            this.Tanggal,
            this.KodeItem,
            this.NamaItem,
            this.Satuan,
            this.HargaBarang});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // KodePelanggan
            // 
            this.KodePelanggan.Caption = "Kode Pelanggan";
            this.KodePelanggan.FieldName = "KodePelanggan";
            this.KodePelanggan.Name = "KodePelanggan";
            this.KodePelanggan.Visible = true;
            this.KodePelanggan.VisibleIndex = 0;
            this.KodePelanggan.Width = 94;
            // 
            // Nama
            // 
            this.Nama.Caption = "Nama Pelanggan";
            this.Nama.FieldName = "Nama";
            this.Nama.Name = "Nama";
            this.Nama.Visible = true;
            this.Nama.VisibleIndex = 1;
            this.Nama.Width = 100;
            // 
            // NoTransaksi
            // 
            this.NoTransaksi.Caption = "No Transaksi";
            this.NoTransaksi.FieldName = "NoTransaksi";
            this.NoTransaksi.Name = "NoTransaksi";
            this.NoTransaksi.Visible = true;
            this.NoTransaksi.VisibleIndex = 2;
            this.NoTransaksi.Width = 94;
            // 
            // Tanggal
            // 
            this.Tanggal.Caption = "Tanggal";
            this.Tanggal.ColumnEdit = this.repositoryItemDateEdit1;
            this.Tanggal.FieldName = "Tanggal";
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Visible = true;
            this.Tanggal.VisibleIndex = 3;
            this.Tanggal.Width = 91;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Mask.EditMask = "G";
            this.repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // KodeItem
            // 
            this.KodeItem.Caption = "Kode Item";
            this.KodeItem.FieldName = "KodeItem";
            this.KodeItem.Name = "KodeItem";
            this.KodeItem.Visible = true;
            this.KodeItem.VisibleIndex = 4;
            this.KodeItem.Width = 78;
            // 
            // NamaItem
            // 
            this.NamaItem.Caption = "Nama Item";
            this.NamaItem.FieldName = "NamaItem";
            this.NamaItem.Name = "NamaItem";
            this.NamaItem.Visible = true;
            this.NamaItem.VisibleIndex = 5;
            this.NamaItem.Width = 229;
            // 
            // Satuan
            // 
            this.Satuan.Caption = "Satuan";
            this.Satuan.FieldName = "Satuan";
            this.Satuan.Name = "Satuan";
            this.Satuan.Visible = true;
            this.Satuan.VisibleIndex = 6;
            this.Satuan.Width = 51;
            // 
            // HargaBarang
            // 
            this.HargaBarang.Caption = "Harga";
            this.HargaBarang.ColumnEdit = this.repositoryItemTextEdit1;
            this.HargaBarang.FieldName = "HargaBarang";
            this.HargaBarang.Name = "HargaBarang";
            this.HargaBarang.Visible = true;
            this.HargaBarang.VisibleIndex = 7;
            this.HargaBarang.Width = 74;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n0";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 67);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 13);
            this.labelControl4.TabIndex = 58;
            this.labelControl4.Text = "Pelanggan :";
            // 
            // tglSesudah
            // 
            this.tglSesudah.EditValue = null;
            this.tglSesudah.Location = new System.Drawing.Point(203, 38);
            this.tglSesudah.Name = "tglSesudah";
            this.tglSesudah.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglSesudah.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglSesudah.Size = new System.Drawing.Size(100, 20);
            this.tglSesudah.TabIndex = 57;
            this.tglSesudah.EditValueChanged += new System.EventHandler(this.tglSesudah_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(174, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 56;
            this.labelControl3.Text = "S/d :";
            // 
            // tglSebelum
            // 
            this.tglSebelum.EditValue = null;
            this.tglSebelum.Location = new System.Drawing.Point(69, 38);
            this.tglSebelum.Name = "tglSebelum";
            this.tglSebelum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglSebelum.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglSebelum.Size = new System.Drawing.Size(100, 20);
            this.tglSebelum.TabIndex = 55;
            this.tglSebelum.EditValueChanged += new System.EventHandler(this.tglSebelum_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 54;
            this.labelControl2.Text = "Dari Tgl :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(69, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(301, 20);
            this.txtSearch.TabIndex = 53;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.ImageOptions.Image = global::MumtaazHerbal.Properties.Resources.search11;
            this.btnSearch.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSearch.Location = new System.Drawing.Point(376, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 20);
            this.btnSearch.TabIndex = 52;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 51;
            this.labelControl1.Text = "Kata Kunci:";
            // 
            // historyPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 364);
            this.Controls.Add(this.lookPelanggan);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.tglSesudah);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.tglSebelum);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labelControl1);
            this.Name = "historyPenjualan";
            this.Text = "History Penjualan";
            this.Load += new System.EventHandler(this.historyPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookPelanggan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglSesudah.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglSesudah.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglSebelum.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglSebelum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.LookUpEdit lookPelanggan;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn KodePelanggan;
        private DevExpress.XtraGrid.Columns.GridColumn Nama;
        private DevExpress.XtraGrid.Columns.GridColumn NoTransaksi;
        private DevExpress.XtraGrid.Columns.GridColumn Tanggal;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn KodeItem;
        private DevExpress.XtraGrid.Columns.GridColumn NamaItem;
        private DevExpress.XtraGrid.Columns.GridColumn Satuan;
        private DevExpress.XtraGrid.Columns.GridColumn HargaBarang;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit tglSesudah;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit tglSebelum;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource pelangganBindingSource;
    }
}