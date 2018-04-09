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
    public partial class dftrSupp : DevExpress.XtraEditors.XtraForm
    {
        SQLiteConnection con = new SQLiteConnection(@"Data Source =MumtaazDB.db; Version = 3;");
        public dftrSupp()
        {
            InitializeComponent();
        }

        private void dftrSupp_Load(object sender, EventArgs e)
        {
            SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROM [tb_daftar_supplier]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(tmbhSupp))
                {
                    form.Activate();
                    return;
                }
            }
            tmbhSupp supp = new tmbhSupp();
            supp.MdiParent = this.ParentForm;
            supp.Show();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}