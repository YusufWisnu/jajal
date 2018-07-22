namespace MumtaazHerbal
{
    partial class lprLabaRugi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lprLabaRugi));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tglSesudah = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tglSebelum = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnBayar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglSesudah.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglSesudah.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglSebelum.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglSebelum.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tglSesudah);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.tglSebelum);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(444, 206);
            this.groupControl1.TabIndex = 52;
            this.groupControl1.Text = "groupControl1";
            // 
            // tglSesudah
            // 
            this.tglSesudah.EditValue = null;
            this.tglSesudah.Location = new System.Drawing.Point(205, 37);
            this.tglSesudah.Name = "tglSesudah";
            this.tglSesudah.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglSesudah.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglSesudah.Size = new System.Drawing.Size(100, 20);
            this.tglSesudah.TabIndex = 50;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(176, 40);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 49;
            this.labelControl3.Text = "S/d :";
            // 
            // tglSebelum
            // 
            this.tglSebelum.EditValue = null;
            this.tglSebelum.Location = new System.Drawing.Point(71, 37);
            this.tglSebelum.Name = "tglSebelum";
            this.tglSebelum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglSebelum.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglSebelum.Size = new System.Drawing.Size(100, 20);
            this.tglSebelum.TabIndex = 48;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 47;
            this.labelControl2.Text = "Dari Tgl :";
            // 
            // btnBayar
            // 
            this.btnBayar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBayar.ImageOptions.Image")));
            this.btnBayar.Location = new System.Drawing.Point(471, 44);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(76, 25);
            this.btnBayar.TabIndex = 53;
            this.btnBayar.Text = "Print";
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // lprLabaRugi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 332);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.groupControl1);
            this.Name = "lprLabaRugi";
            this.Text = "Laporan Laba Rugi";
            this.Load += new System.EventHandler(this.lprLabaRugi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglSesudah.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglSesudah.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglSebelum.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglSebelum.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBayar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.DateEdit tglSesudah;
        public DevExpress.XtraEditors.DateEdit tglSebelum;
    }
}