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
    public partial class tmbhItem : DevExpress.XtraEditors.XtraForm
    {
        DatabaseHelper myDB = new DatabaseHelper();
        
        public tmbhItem()
        {
            InitializeComponent();
            fillCombo();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tmbhItem_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxEdit2_SelectedIndexChanged(object sender, EventArgs e)
        { 

        }

        //untuk menampilkan nama supplier di comboBox
        void fillCombo()
        {
            SqlConnection con = new SqlConnection(myDB.GetConnection());
            SqlCommand cmd = new SqlCommand("SELECT * FROM tb_daftar_supplier", con);
            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string temp_supp;
                    temp_supp = sdr.GetString(sdr.GetOrdinal("nama_supp"));
                    comboBoxEdit2.Properties.Items.Add(temp_supp);
                }
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myDB.GetConnection());
            //SqlCommand cmd = new SqlCommand("INSERT INTO [tb_daftar_item] (kode_item, nama_item, stok, jenis_stok)")
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void textEdit8_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}