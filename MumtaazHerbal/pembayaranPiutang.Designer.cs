namespace MumtaazHerbal
{
    partial class pembayaranPiutang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pembayaranPiutang));
            this.lookPelanggan = new DevExpress.XtraEditors.LookUpEdit();
            this.pelangganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTransaksi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NoTransaksi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tanggal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.Nama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TanggalJT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sisa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.JumlahBayar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.btnBayar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtTanggal = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTimer = new DevExpress.XtraEditors.TextEdit();
            this.txtuser = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.checkPrint = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lookPelanggan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransaksi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtuser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPrint.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookPelanggan
            // 
            this.lookPelanggan.Location = new System.Drawing.Point(91, 58);
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
            this.lookPelanggan.Properties.ValueMember = "Id";
            this.lookPelanggan.Size = new System.Drawing.Size(134, 20);
            this.lookPelanggan.TabIndex = 46;
            this.lookPelanggan.EditValueChanged += new System.EventHandler(this.lookPelanggan_EditValueChanged);
            this.lookPelanggan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lookPelanggan_KeyDown);
            // 
            // pelangganBindingSource
            // 
            this.pelangganBindingSource.DataSource = typeof(MumtaazHerbal.Pelanggan);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(31, 59);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 13);
            this.labelControl3.TabIndex = 45;
            this.labelControl3.Text = "Pelanggan :";
            // 
            // txtTransaksi
            // 
            this.txtTransaksi.Location = new System.Drawing.Point(91, 12);
            this.txtTransaksi.Name = "txtTransaksi";
            this.txtTransaksi.Size = new System.Drawing.Size(134, 20);
            this.txtTransaksi.TabIndex = 44;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "No Transaksi :";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(12, 108);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemDateEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit4,
            this.repositoryItemTextEdit5});
            this.gridControl1.Size = new System.Drawing.Size(794, 246);
            this.gridControl1.TabIndex = 47;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NoTransaksi,
            this.Tanggal,
            this.Nama,
            this.TanggalJT,
            this.Sisa,
            this.Total,
            this.JumlahBayar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // NoTransaksi
            // 
            this.NoTransaksi.Caption = "No Transaksi";
            this.NoTransaksi.FieldName = "NoTransaksi";
            this.NoTransaksi.Name = "NoTransaksi";
            this.NoTransaksi.OptionsColumn.AllowEdit = false;
            this.NoTransaksi.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.NoTransaksi.Visible = true;
            this.NoTransaksi.VisibleIndex = 0;
            this.NoTransaksi.Width = 100;
            // 
            // Tanggal
            // 
            this.Tanggal.Caption = "Tanggal";
            this.Tanggal.ColumnEdit = this.repositoryItemDateEdit1;
            this.Tanggal.DisplayFormat.FormatString = "g";
            this.Tanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Tanggal.FieldName = "Tanggal";
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.OptionsColumn.AllowEdit = false;
            this.Tanggal.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.Tanggal.Visible = true;
            this.Tanggal.VisibleIndex = 1;
            this.Tanggal.Width = 100;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Mask.EditMask = "g";
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // Nama
            // 
            this.Nama.Caption = "Nama";
            this.Nama.FieldName = "Nama";
            this.Nama.Name = "Nama";
            this.Nama.OptionsColumn.AllowEdit = false;
            this.Nama.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Nama.Visible = true;
            this.Nama.VisibleIndex = 2;
            this.Nama.Width = 125;
            // 
            // TanggalJT
            // 
            this.TanggalJT.Caption = "Tanggal JT";
            this.TanggalJT.FieldName = "TanggalJT";
            this.TanggalJT.Name = "TanggalJT";
            this.TanggalJT.OptionsColumn.AllowEdit = false;
            this.TanggalJT.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.TanggalJT.Visible = true;
            this.TanggalJT.VisibleIndex = 3;
            this.TanggalJT.Width = 80;
            // 
            // Sisa
            // 
            this.Sisa.Caption = "Sisa";
            this.Sisa.ColumnEdit = this.repositoryItemTextEdit1;
            this.Sisa.DisplayFormat.FormatString = "n0";
            this.Sisa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Sisa.FieldName = "Sisa";
            this.Sisa.Name = "Sisa";
            this.Sisa.OptionsColumn.AllowEdit = false;
            this.Sisa.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Sisa.Visible = true;
            this.Sisa.VisibleIndex = 4;
            this.Sisa.Width = 80;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n0";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // Total
            // 
            this.Total.Caption = "Total";
            this.Total.ColumnEdit = this.repositoryItemTextEdit4;
            this.Total.FieldName = "Total";
            this.Total.Name = "Total";
            this.Total.OptionsColumn.AllowEdit = false;
            this.Total.UnboundExpression = "[Sisa]";
            this.Total.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Total.Visible = true;
            this.Total.VisibleIndex = 5;
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Mask.EditMask = "n0";
            this.repositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // JumlahBayar
            // 
            this.JumlahBayar.Caption = "Jumlah Bayar";
            this.JumlahBayar.ColumnEdit = this.repositoryItemTextEdit5;
            this.JumlahBayar.DisplayFormat.FormatString = "n0";
            this.JumlahBayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.JumlahBayar.FieldName = "JumlahBayar";
            this.JumlahBayar.Name = "JumlahBayar";
            this.JumlahBayar.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.JumlahBayar.Visible = true;
            this.JumlahBayar.VisibleIndex = 6;
            // 
            // repositoryItemTextEdit5
            // 
            this.repositoryItemTextEdit5.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemTextEdit5.AutoHeight = false;
            this.repositoryItemTextEdit5.DisplayFormat.FormatString = "n0";
            this.repositoryItemTextEdit5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit5.Mask.EditMask = "n0";
            this.repositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit5.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit5.Name = "repositoryItemTextEdit5";
            this.repositoryItemTextEdit5.NullText = "0";
            this.repositoryItemTextEdit5.UseReadOnlyAppearance = false;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Mask.EditMask = "n0";
            this.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Mask.EditMask = "n0";
            this.repositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.EditValue = "";
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(317, 9);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtTotal.Size = new System.Drawing.Size(489, 69);
            this.txtTotal.TabIndex = 48;
            // 
            // btnBayar
            // 
            this.btnBayar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBayar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBayar.ImageOptions.Image")));
            this.btnBayar.Location = new System.Drawing.Point(97, 360);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(76, 25);
            this.btnBayar.TabIndex = 49;
            this.btnBayar.Text = "Simpan";
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(12, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 25);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Batal";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtTanggal
            // 
            this.txtTanggal.EditValue = null;
            this.txtTanggal.Location = new System.Drawing.Point(91, 35);
            this.txtTanggal.Name = "txtTanggal";
            this.txtTanggal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTanggal.Size = new System.Drawing.Size(134, 20);
            this.txtTanggal.TabIndex = 53;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(40, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 52;
            this.labelControl2.Text = "Tanggal :";
            // 
            // txtTimer
            // 
            this.txtTimer.Enabled = false;
            this.txtTimer.Location = new System.Drawing.Point(231, 35);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(71, 20);
            this.txtTimer.TabIndex = 55;
            // 
            // txtuser
            // 
            this.txtuser.EditValue = "";
            this.txtuser.Enabled = false;
            this.txtuser.Location = new System.Drawing.Point(231, 12);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(71, 20);
            this.txtuser.TabIndex = 54;
            // 
            // checkPrint
            // 
            this.checkPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkPrint.Location = new System.Drawing.Point(179, 363);
            this.checkPrint.Name = "checkPrint";
            this.checkPrint.Properties.Caption = "Print";
            this.checkPrint.Size = new System.Drawing.Size(75, 19);
            this.checkPrint.TabIndex = 56;
            // 
            // pembayaranPiutang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 388);
            this.Controls.Add(this.checkPrint);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txtTanggal);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lookPelanggan);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtTransaksi);
            this.Controls.Add(this.labelControl1);
            this.Name = "pembayaranPiutang";
            this.Text = "Pembayaran Piutang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.pembayaranPiutang_FormClosing);
            this.Load += new System.EventHandler(this.pembayaranPiutang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookPelanggan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransaksi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtuser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPrint.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.LookUpEdit lookPelanggan;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.TextEdit txtTransaksi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn NoTransaksi;
        private DevExpress.XtraGrid.Columns.GridColumn Tanggal;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Nama;
        private DevExpress.XtraGrid.Columns.GridColumn TanggalJT;
        private DevExpress.XtraGrid.Columns.GridColumn Sisa;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        public DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.SimpleButton btnBayar;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.DateEdit txtTanggal;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTimer;
        private DevExpress.XtraEditors.TextEdit txtuser;
        private System.Windows.Forms.BindingSource pelangganBindingSource;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private DevExpress.XtraGrid.Columns.GridColumn JumlahBayar;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit5;
        private DevExpress.XtraEditors.CheckEdit checkPrint;
    }
}