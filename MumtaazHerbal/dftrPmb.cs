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
    public partial class dftrPmb : DevExpress.XtraEditors.XtraForm
    {
        DatabaseHelper myDB = new DatabaseHelper();
        public dftrPmb()
        {
            InitializeComponent();
        }

        private void dftrPmb_Load(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(myDB.GetConnection()); 
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [tb_daftar_pembelian]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}