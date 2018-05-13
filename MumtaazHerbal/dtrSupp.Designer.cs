namespace MumtaazHerbal
{
    partial class dftrSupp
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
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnHapus = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnTutup = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKodeSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNamaSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlamat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoHP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(84, 21);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(351, 22);
            this.txtSearch.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.ImageOptions.Image = global::MumtaazHerbal.Properties.Resources.search11;
            this.btnSearch.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSearch.Location = new System.Drawing.Point(442, 21);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(54, 25);
            this.btnSearch.TabIndex = 16;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 25);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 16);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Kata Kunci:";
            // 
            // btnHapus
            // 
            this.btnHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHapus.ImageOptions.Image = global::MumtaazHerbal.Properties.Resources.substract__1_;
            this.btnHapus.Location = new System.Drawing.Point(219, 614);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(96, 32);
            this.btnHapus.TabIndex = 21;
            this.btnHapus.Text = "Hapus Item";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.ImageOptions.Image = global::MumtaazHerbal.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(117, 614);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 32);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Edit Item";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.ImageOptions.Image = global::MumtaazHerbal.Properties.Resources.plus__1_;
            this.btnAdd.Location = new System.Drawing.Point(14, 614);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 32);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Item Baru";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Supplier";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Width = 141;
            // 
            // btnTutup
            // 
            this.btnTutup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTutup.ImageOptions.Image = global::MumtaazHerbal.Properties.Resources.back;
            this.btnTutup.Location = new System.Drawing.Point(750, 617);
            this.btnTutup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(96, 32);
            this.btnTutup.TabIndex = 39;
            this.btnTutup.Text = "&Tutup";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.supplierBindingSource;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(14, 71);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(832, 535);
            this.gridControl1.TabIndex = 40;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(MumtaazHerbal.Supplier);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKodeSupplier,
            this.colNamaSupplier,
            this.colAlamat,
            this.colNoHP,
            this.colEmail});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colKodeSupplier
            // 
            this.colKodeSupplier.FieldName = "KodeSupplier";
            this.colKodeSupplier.Name = "colKodeSupplier";
            this.colKodeSupplier.Visible = true;
            this.colKodeSupplier.VisibleIndex = 1;
            // 
            // colNamaSupplier
            // 
            this.colNamaSupplier.AppearanceCell.Options.UseTextOptions = true;
            this.colNamaSupplier.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNamaSupplier.FieldName = "NamaSupplier";
            this.colNamaSupplier.Name = "colNamaSupplier";
            this.colNamaSupplier.Visible = true;
            this.colNamaSupplier.VisibleIndex = 2;
            // 
            // colAlamat
            // 
            this.colAlamat.FieldName = "Alamat";
            this.colAlamat.Name = "colAlamat";
            this.colAlamat.Visible = true;
            this.colAlamat.VisibleIndex = 3;
            // 
            // colNoHP
            // 
            this.colNoHP.FieldName = "NoHP";
            this.colNoHP.Name = "colNoHP";
            this.colNoHP.Visible = true;
            this.colNoHP.VisibleIndex = 4;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
            // 
            // dftrSupp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 663);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "dftrSupp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daftar Supplier";
            this.Load += new System.EventHandler(this.dftrSupp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnHapus;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.SimpleButton btnTutup;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colKodeSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn colNamaSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn colAlamat;
        private DevExpress.XtraGrid.Columns.GridColumn colNoHP;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private System.Windows.Forms.BindingSource supplierBindingSource;
    }
}