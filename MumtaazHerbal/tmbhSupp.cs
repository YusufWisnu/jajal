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
    public partial class tmbhSupp : DevExpress.XtraEditors.XtraForm
    {

        public tmbhSupp()
        {
            InitializeComponent();
        }

        private void tmbhSupp_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J5QHE7L\SQLEXPRESS;Initial Catalog=MumtaazFixV1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Suppliers where KodeSupplier = '" + textEdit1.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if()
        }

    }
}