using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MumtaazHerbal
{
    class DatabaseHelper
    {
        /*Database File name*/
        //public string databaseName = "MumtaazDB.mdf";
        //string path = Path.GetFullPath(Environment.CurrentDirectory);

        public string GetConnection()
        {
            return @"Data Source=DESKTOP-J5QHE7L\SQLEXPRESS;Initial Catalog=MumtaazDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //return @"Data Source=(localdb)\v11.0;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True";
        }
        /*

        // membuat database beserta tabel, kolom, dan relasi terhadap tabel lain
        public void CreateDatabase()
        {
            using(SQLiteConnection con = new SQLiteConnection(GetConnection()))
            {
                SQLiteCommand cmd = new SQLiteCommand();
                con.Open();
                cmd.Connection = con;

                string tb_daftar_item = @"CREATE TABLE tb_daftar_item (kode_item Text(50) PRIMARY KEY, nama_item Text(50), stok INTEGER, jenis Text(50), harga_pokok INTEGER, harga_jual INTEGER, stok_min INTEGER, kode_sup Text(50), nama_sup Text(50))";
                cmd.CommandText = tb_daftar_item;
                cmd.ExecuteNonQuery();

                string tb_daftar_pelanggan = @"CREATE TABLE tb_daftar_pelanggan (kode_pel Text(50) PRIMARY KEY, nama_pel Text(50), grup_pel Text(50), alamat_pel Text(50), nohp_pel Text(50), email_pel Text(50))";
                cmd.CommandText = tb_daftar_pelanggan;
                cmd.ExecuteNonQuery();

                string tb_daftar_pembelian = @"CREATE TABLE tb_daftar_pembelian (no_trans_pemb Text(50) PRIMARY KEY, tgl_pemb Text(50), kode_supp Text(50), nama_supp Text(50), total INTEGER)";
                cmd.CommandText = tb_daftar_pembelian;
                cmd.ExecuteNonQuery();

                string tb_daftar_supplier = @"CREATE TABLE tb_daftar_supplier (kode_supp Text(50) PRIMARY KEY, nama_supp Text(50), alamat_supp Text(50), nohp_supp Text(50), email_supp Text(50))";
                cmd.CommandText = tb_daftar_supplier;
                cmd.ExecuteNonQuery();

                string tb_daftar_pemb_piutang = @"CREATE TABLE tb_daftar_pemb_piutang (no_trans_piutang Text(50) PRIMARY KEY, tgl_piutang Text(50), kode_pelanggan Text(50), nama_piutang Text(50), total INTEGER)";
                cmd.CommandText = tb_daftar_pemb_piutang;
                cmd.ExecuteNonQuery();

                string tb_penj_kasir = @"CREATE TABLE tb_penj_kasir (no_trans_ksr Text(50) PRIMARY KEY, tgl_kasir Text(50), kode_pelanggan Text(50), nama_pel Text(50), kode_item Text(50), nama_item Text(50), jumlah INTEGER, satuan TEXT(20), harga INTEGER, total INTEGER)";
                cmd.CommandText = tb_penj_kasir;
                cmd.ExecuteNonQuery();

                string tb_user = @"CREATE TABLE tb_user (id INTEGER PRIMARY KEY AUTOINCREMENT, username Text(50), password Text(50), tipe Text(50))";
                cmd.CommandText = tb_user;
                cmd.ExecuteNonQuery();

                string FK_daftarItem = @"ALTER TABLE tb_daftar_item ADD FOREIGN KEY (kode_supp) REFERENCE tb_daftar_supplier(kode_supp)";
                cmd.CommandText = FK_daftarItem;
                cmd.ExecuteNonQuery();

                string FK_daftarPembelian = @"ALTER TABLE tb_daftar_pembelian ADD FOREIGN KEY (kode_supp) REFERENCE tb_daftar_supplier(kode_supp)";
                cmd.CommandText = FK_daftarPembelian;
                cmd.ExecuteNonQuery();

                con.Close();
                
                
            }
        }*/
    }
}
