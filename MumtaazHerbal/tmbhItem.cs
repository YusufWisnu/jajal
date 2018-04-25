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

        // Untuk AutoFill kode Supplier
        private void comboBoxEdit2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myDB.GetConnection());
            SqlCommand cmd = new SqlCommand("SELECT * FROM [tb_daftar_supplier] where [nama_supp] ='"+comboBoxEdit2.Text+"'", con);
            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string temp_kode;
                    temp_kode = sdr.GetString(sdr.GetOrdinal("kode_supp"));
                    textEdit8.Text = temp_kode;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //untuk menampilkan nama supplier di comboBox
        void fillCombo()
        {
            SqlConnection con = new SqlConnection(myDB.GetConnection());
            SqlCommand cmd = new SqlCommand("SELECT * FROM [tb_daftar_supplier]", con);
            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string temp_supp, temp_kode;
                    temp_supp = sdr.GetString(sdr.GetOrdinal("nama_supp"));
                    temp_kode = sdr.GetString(sdr.GetOrdinal("kode_supp"));  
                    comboBoxEdit2.Properties.Items.Add(temp_supp);
                    

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myDB.GetConnection());
           
            try
            {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tb_daftar_item (kode_item, nama_item, stok, satuan, harga_grosir, harga_eceran, harga_jual, kode_supp, nama_supp) VALUES (@kode_item, @nama_item, @stok, @satuan, @harga_grosir, @harga_eceran, @harga_jual, @kode_supp, @nama_supp)", con);
                    cmd.Parameters.AddWithValue("@kode_item", textEdit1.Text.Trim());
                    cmd.Parameters.AddWithValue("@nama_item", textEdit2.Text.Trim());
                    cmd.Parameters.AddWithValue("@stok", textEdit3.Text.Trim());
                    cmd.Parameters.AddWithValue("@satuan", textEdit7.Text.Trim());
                    cmd.Parameters.AddWithValue("@harga_grosir", textEdit6.Text.Trim());
                    cmd.Parameters.AddWithValue("@harga_eceran", textEdit5.Text.Trim());
                    cmd.Parameters.AddWithValue("@harga_jual", textEdit4.Text.Trim());
                    cmd.Parameters.AddWithValue("@kode_supp", textEdit8.Text.Trim());
                    cmd.Parameters.AddWithValue("@nama_supp", comboBoxEdit2.Text.Trim());
                    cmd.ExecuteNonQuery();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Barang Berhasil Ditambahkan", "Mumtaaz Herbal", MessageBoxButtons.OK);
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       // }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void textEdit8_EditValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}