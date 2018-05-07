namespace MumtaazHerbal
{
    partial class dftrItem
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
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnHapus = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnTutup = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NamaItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KodeItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Stok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Satuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HargaGrosir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HargaEceran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HargaJual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NamaSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.ImageOptions.Image = global::MumtaazHerbal.Properties.Resources.search11;
            this.btnSearch.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSearch.Location = new System.Drawing.Point(379, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 20);
            this.btnSearch.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kata Kunci:";
            // 
            // btnHapus
            // 
            this.btnHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHapus.ImageOptions.Image = global::MumtaazHerbal.Properties.Resources.substract__1_;
            this.btnHapus.Location = new System.Drawing.Point(188, 499);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(82, 26);
            this.btnHapus.TabIndex = 12;
            this.btnHapus.Text = "Hapus Item";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.ImageOptions.Image = global::MumtaazHerbal.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(100, 499);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 26);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit Item";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.ImageOptions.Image = global::MumtaazHerbal.Properties.Resources.plus__1_;
            this.btnAdd.Location = new System.Drawing.Point(12, 499);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 26);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Item Baru";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(72, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(301, 20);
            this.txtSearch.TabIndex = 14;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.Image = global::MumtaazHerbal.Properties.Resources.reload;
            this.simpleButton1.Location = new System.Drawing.Point(1001, 501);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(82, 26);
            this.simpleButton1.TabIndex = 31;
            this.simpleButton1.Text = "&Tutup";
            // 
            // btnTutup
            // 
            this.btnTutup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTutup.ImageOptions.Image = global::MumtaazHerbal.Properties.Resources.back;
            this.btnTutup.Location = new System.Drawing.Point(830, 499);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(82, 26);
            this.btnTutup.TabIndex = 39;
            this.btnTutup.Text = "&Tutup";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(12, 39);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(895, 454);
            this.gridControl1.TabIndex = 40;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NamaItem,
            this.KodeItem,
            this.Stok,
            this.Satuan,
            this.HargaGrosir,
            this.HargaEceran,
            this.HargaJual,
            this.NamaSupplier});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
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
            this.NamaItem.VisibleIndex = 0;
            this.NamaItem.Width = 236;
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
            this.KodeItem.Width = 83;
            // 
            // Stok
            // 
            this.Stok.AppearanceCell.Options.UseTextOptions = true;
            this.Stok.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.Stok.AppearanceHeader.Options.UseTextOptions = true;
            this.Stok.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Stok.Caption = "Stok";
            this.Stok.FieldName = "Stok";
            this.Stok.Name = "Stok";
            this.Stok.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Stok.Visible = true;
            this.Stok.VisibleIndex = 2;
            this.Stok.Width = 83;
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
            this.Satuan.VisibleIndex = 3;
            this.Satuan.Width = 83;
            // 
            // HargaGrosir
            // 
            this.HargaGrosir.AppearanceCell.Options.UseTextOptions = true;
            this.HargaGrosir.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.HargaGrosir.AppearanceHeader.Options.UseTextOptions = true;
            this.HargaGrosir.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HargaGrosir.Caption = "Harga Grosir";
            this.HargaGrosir.FieldName = "HargaGrosir";
            this.HargaGrosir.Name = "HargaGrosir";
            this.HargaGrosir.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.HargaGrosir.Visible = true;
            this.HargaGrosir.VisibleIndex = 4;
            this.HargaGrosir.Width = 50;
            // 
            // HargaEceran
            // 
            this.HargaEceran.AppearanceCell.Options.UseTextOptions = true;
            this.HargaEceran.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.HargaEceran.AppearanceHeader.Options.UseTextOptions = true;
            this.HargaEceran.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HargaEceran.Caption = "Harga Eceran";
            this.HargaEceran.FieldName = "HargaEceran";
            this.HargaEceran.Name = "HargaEceran";
            this.HargaEceran.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.HargaEceran.Visible = true;
            this.HargaEceran.VisibleIndex = 5;
            this.HargaEceran.Width = 50;
            // 
            // HargaJual
            // 
            this.HargaJual.AppearanceCell.Options.UseTextOptions = true;
            this.HargaJual.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.HargaJual.AppearanceHeader.Options.UseTextOptions = true;
            this.HargaJual.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HargaJual.Caption = "Harga Jual";
            this.HargaJual.FieldName = "HargaJual";
            this.HargaJual.Name = "HargaJual";
            this.HargaJual.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.HargaJual.Visible = true;
            this.HargaJual.VisibleIndex = 6;
            this.HargaJual.Width = 63;
            // 
            // NamaSupplier
            // 
            this.NamaSupplier.AppearanceHeader.Options.UseTextOptions = true;
            this.NamaSupplier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NamaSupplier.Caption = "Nama Supplier";
            this.NamaSupplier.FieldName = "NamaSupplier";
            this.NamaSupplier.Name = "NamaSupplier";
            this.NamaSupplier.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.NamaSupplier.Visible = true;
            this.NamaSupplier.VisibleIndex = 7;
            this.NamaSupplier.Width = 229;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(MumtaazHerbal.Item);
            // 
            // dftrItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 539);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labelControl1);
            this.Name = "dftrItem";
            this.Text = " Daftar Item";
            this.Load += new System.EventHandler(this.dftrItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnHapus;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnTutup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn NamaItem;
        private DevExpress.XtraGrid.Columns.GridColumn KodeItem;
        private DevExpress.XtraGrid.Columns.GridColumn Stok;
        private DevExpress.XtraGrid.Columns.GridColumn Satuan;
        private DevExpress.XtraGrid.Columns.GridColumn HargaGrosir;
        private DevExpress.XtraGrid.Columns.GridColumn HargaEceran;
        private DevExpress.XtraGrid.Columns.GridColumn HargaJual;
        private DevExpress.XtraGrid.Columns.GridColumn NamaSupplier;
        private DevExpress.XtraGrid.GridControl gridControl1;
    }
}