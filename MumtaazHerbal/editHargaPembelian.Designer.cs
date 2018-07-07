namespace MumtaazHerbal
{
    partial class editHargaPembelian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editHargaPembelian));
            this.txtNamaItem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtHargaPokok = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtHargaRetail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtHargaGrosir = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnBatal = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamaItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHargaPokok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHargaRetail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHargaGrosir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNamaItem
            // 
            this.txtNamaItem.Enabled = false;
            this.txtNamaItem.Location = new System.Drawing.Point(75, 5);
            this.txtNamaItem.Name = "txtNamaItem";
            this.txtNamaItem.Size = new System.Drawing.Size(246, 20);
            this.txtNamaItem.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nama Item :";
            // 
            // txtHargaPokok
            // 
            this.txtHargaPokok.Location = new System.Drawing.Point(75, 31);
            this.txtHargaPokok.Name = "txtHargaPokok";
            this.txtHargaPokok.Size = new System.Drawing.Size(100, 20);
            this.txtHargaPokok.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Harga Pokok :";
            // 
            // txtHargaRetail
            // 
            this.txtHargaRetail.Location = new System.Drawing.Point(75, 57);
            this.txtHargaRetail.Name = "txtHargaRetail";
            this.txtHargaRetail.Size = new System.Drawing.Size(100, 20);
            this.txtHargaRetail.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 60);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Harga Retail :";
            // 
            // txtHargaGrosir
            // 
            this.txtHargaGrosir.Location = new System.Drawing.Point(75, 83);
            this.txtHargaGrosir.Name = "txtHargaGrosir";
            this.txtHargaGrosir.Size = new System.Drawing.Size(100, 20);
            this.txtHargaGrosir.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 86);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(67, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Harga Grosir :";
            // 
            // btnOk
            // 
            this.btnOk.ImageOptions.Image = global::MumtaazHerbal.Properties.Resources.maps_and_flags;
            this.btnOk.Location = new System.Drawing.Point(215, 128);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(63, 23);
            this.btnOk.TabIndex = 44;
            this.btnOk.Text = "&Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBatal.ImageOptions.Image")));
            this.btnBatal.Location = new System.Drawing.Point(284, 128);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(61, 23);
            this.btnBatal.TabIndex = 43;
            this.btnBatal.Text = "&Batal";
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtNamaItem);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtHargaRetail);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtHargaGrosir);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtHargaPokok);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(333, 110);
            this.groupControl1.TabIndex = 46;
            // 
            // editHargaPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 159);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnBatal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "editHargaPembelian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Harga";
            this.Load += new System.EventHandler(this.editHargaPembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNamaItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHargaPokok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHargaRetail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHargaGrosir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNamaItem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtHargaPokok;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtHargaRetail;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtHargaGrosir;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnBatal;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}