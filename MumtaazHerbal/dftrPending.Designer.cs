namespace MumtaazHerbal
{
    partial class dftrPending
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.detailPenjualanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NoTransaksi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tanggal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Keterangan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailPenjualanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.detailPenjualanBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(391, 203);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // detailPenjualanBindingSource
            // 
            this.detailPenjualanBindingSource.DataSource = typeof(MumtaazHerbal.DetailPenjualan);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NoTransaksi,
            this.Tanggal,
            this.Keterangan});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // NoTransaksi
            // 
            this.NoTransaksi.Caption = "No Transaksi";
            this.NoTransaksi.FieldName = "NoTransaksi";
            this.NoTransaksi.Name = "NoTransaksi";
            this.NoTransaksi.Visible = true;
            this.NoTransaksi.VisibleIndex = 0;
            // 
            // Tanggal
            // 
            this.Tanggal.Caption = "Tanggal";
            this.Tanggal.FieldName = "Tanggal";
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Visible = true;
            this.Tanggal.VisibleIndex = 1;
            // 
            // Keterangan
            // 
            this.Keterangan.Caption = "Keterangan";
            this.Keterangan.FieldName = "Keterangan";
            this.Keterangan.Name = "Keterangan";
            this.Keterangan.Visible = true;
            this.Keterangan.VisibleIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::MumtaazHerbal.Properties.Resources.reload;
            this.simpleButton1.Location = new System.Drawing.Point(340, 221);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(63, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Cancel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = global::MumtaazHerbal.Properties.Resources.maps_and_flags;
            this.simpleButton2.Location = new System.Drawing.Point(271, 221);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(63, 23);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Ok";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // dftrPending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 249);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "dftrPending";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daftar Pending";
            this.Load += new System.EventHandler(this.dftrPending_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailPenjualanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn NoTransaksi;
        private DevExpress.XtraGrid.Columns.GridColumn Tanggal;
        private DevExpress.XtraGrid.Columns.GridColumn Keterangan;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.BindingSource detailPenjualanBindingSource;
    }
}