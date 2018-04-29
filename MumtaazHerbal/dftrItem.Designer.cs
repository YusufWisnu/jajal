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
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNamaItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKodeItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHargaGrosir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHargaEceran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHargaJual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource();
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
            this.gridControl1.DataSource = this.itemBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(895, 450);
            this.gridControl1.TabIndex = 40;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colNamaItem,
            this.colKodeItem,
            this.colStok,
            this.colSatuan,
            this.colHargaGrosir,
            this.colHargaEceran,
            this.colHargaJual,
            this.colSupplierId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colNamaItem
            // 
            this.colNamaItem.FieldName = "NamaItem";
            this.colNamaItem.Name = "colNamaItem";
            this.colNamaItem.Visible = true;
            this.colNamaItem.VisibleIndex = 1;
            // 
            // colKodeItem
            // 
            this.colKodeItem.FieldName = "KodeItem";
            this.colKodeItem.Name = "colKodeItem";
            this.colKodeItem.Visible = true;
            this.colKodeItem.VisibleIndex = 2;
            // 
            // colStok
            // 
            this.colStok.FieldName = "Stok";
            this.colStok.Name = "colStok";
            this.colStok.Visible = true;
            this.colStok.VisibleIndex = 3;
            // 
            // colSatuan
            // 
            this.colSatuan.FieldName = "Satuan";
            this.colSatuan.Name = "colSatuan";
            this.colSatuan.Visible = true;
            this.colSatuan.VisibleIndex = 4;
            // 
            // colHargaGrosir
            // 
            this.colHargaGrosir.FieldName = "HargaGrosir";
            this.colHargaGrosir.Name = "colHargaGrosir";
            this.colHargaGrosir.Visible = true;
            this.colHargaGrosir.VisibleIndex = 5;
            // 
            // colHargaEceran
            // 
            this.colHargaEceran.FieldName = "HargaEceran";
            this.colHargaEceran.Name = "colHargaEceran";
            this.colHargaEceran.Visible = true;
            this.colHargaEceran.VisibleIndex = 6;
            // 
            // colHargaJual
            // 
            this.colHargaJual.FieldName = "HargaJual";
            this.colHargaJual.Name = "colHargaJual";
            this.colHargaJual.Visible = true;
            this.colHargaJual.VisibleIndex = 7;
            // 
            // colSupplierId
            // 
            this.colSupplierId.FieldName = "SupplierId";
            this.colSupplierId.Name = "colSupplierId";
            this.colSupplierId.Visible = true;
            this.colSupplierId.VisibleIndex = 8;
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
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNamaItem;
        private DevExpress.XtraGrid.Columns.GridColumn colKodeItem;
        private DevExpress.XtraGrid.Columns.GridColumn colStok;
        private DevExpress.XtraGrid.Columns.GridColumn colSatuan;
        private DevExpress.XtraGrid.Columns.GridColumn colHargaGrosir;
        private DevExpress.XtraGrid.Columns.GridColumn colHargaEceran;
        private DevExpress.XtraGrid.Columns.GridColumn colHargaJual;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierId;
        private System.Windows.Forms.BindingSource itemBindingSource;
    }
}