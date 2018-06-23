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
using MumtaazHerbal.Function;   //buat bisa manggil class dari Folder Function
using DevExpress.XtraGrid;      //biar bisa make GridControl

namespace MumtaazHerbal
{
    public partial class tmbhSupp : DevExpress.XtraEditors.XtraForm
    {
        private Query query;
        private bool edit;
        private GridControl gridControl1 = new GridControl();
        public tmbhSupp()
        {
            InitializeComponent();
        }

        public tmbhSupp(Query query, bool edit)
            : this()
        {
            this.query = query;
            this.edit = edit;
        }

        public tmbhSupp(GridControl gridControl1)
            : this()
        {
            this.gridControl1 = gridControl1;
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
            if (textEdit1.Text == string.Empty && textEdit2.Text == string.Empty)
            {
                XtraMessageBox.Show("Kode Supplier Harus Diisi", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if(textEdit2.Text == string.Empty)
            {
                XtraMessageBox.Show("Nama Supplier Harus Diisi", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dt.Rows.Count == 0)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Suppliers (KodeSupplier, NamaSupplier, Alamat, NoHP, Email) VALUES (@KodeSupplier, @NamaSupplier, @Alamat, @NoHP, @Email)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@KodeSupplier", textEdit1.Text.Trim());
                    cmd.Parameters.AddWithValue("@NamaSupplier", textEdit2.Text.Trim());
                    cmd.Parameters.AddWithValue("@Alamat", memoEdit1.Text.Trim());
                    cmd.Parameters.AddWithValue("@NoHP", textEdit3.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", textEdit4.Text.Trim());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    XtraMessageBox.Show("Supplier Berhasil Ditambahkan", "Success", MessageBoxButtons.OK);
                    textEdit1.Text = textEdit2.Text = textEdit3.Text = textEdit4.Text = memoEdit1.Text = "";
                }
                catch (Exception ee)
                {
                    XtraMessageBox.Show(ee.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                XtraMessageBox.Show("Maaf Supplier Sudah Ada", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}