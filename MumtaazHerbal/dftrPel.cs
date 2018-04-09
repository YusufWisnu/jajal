using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SQLite;

namespace MumtaazHerbal
{
    public partial class dftrPel : DevExpress.XtraEditors.XtraForm
    {
        SQLiteConnection con = new SQLiteConnection(@"Data Source = C:\Users\YUSUF WISNU P\Source\Repos\jajal\MumtaazDB.db; Version = 3;");
        public dftrPel()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(tmbhPel))
                {
                    form.Activate();
                    return;
                }
            }

            tmbhPel tmbh = new tmbhPel();
            tmbh.MdiParent = this.ParentForm;
            tmbh.Show();
        }

        private void dftrPel_Load(object sender, EventArgs e)
        {
            SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROm [tb_daftar_pelanggan]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}