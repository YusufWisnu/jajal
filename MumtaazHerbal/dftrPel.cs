using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace MumtaazHerbal
{
    public partial class dftrPel : DevExpress.XtraEditors.XtraForm
    {
        DatabaseHelper myDB = new DatabaseHelper();
        
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
            SqlConnection con = new SqlConnection(myDB.GetConnection());
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROm [tb_daftar_pelanggan]", con);
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