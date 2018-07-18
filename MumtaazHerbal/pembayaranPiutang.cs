using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MumtaazHerbal.Function;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace MumtaazHerbal
{
    public partial class pembayaranPiutang : DevExpress.XtraEditors.XtraForm
    {
        private DbHelper dbhelper;
        private dftrPembayaranPiutang dftrPiutang;
        private GridView gridView;
        private bool edit;
        private string noTransaksi;


        public pembayaranPiutang()
        {
            InitializeComponent();
            dbhelper = new DbHelper();
        }

        public pembayaranPiutang(dftrPembayaranPiutang dftrPiutang, GridView gridView, bool edit, string noTransaksi)
            :this()
        {
            this.dftrPiutang = dftrPiutang;
            this.gridView = gridView;
            this.edit = edit;
            this.noTransaksi = noTransaksi;
        }

        //public int FocusRowHandle { get { return gridView1.FocusedRowHandle; } }
        //public string FocusNoTransaksi{ get { return gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString(); } }

        MumtaazContext mumtaaz;

        private void pembayaranPiutang_Load(object sender, EventArgs e)
        {
            mumtaaz = new MumtaazContext(dbhelper.ConnectionString);

            txtTanggal.EditValue = DateTime.Now;
            txtuser.Text = "ADMIN";
            txtTransaksi.Text = GetNoTransaksi();
            pelangganBindingSource.DataSource = mumtaaz.Pelanggans.ToList();

            LoadData(lookPelanggan.Text);

            //edit piutang
            if (edit)
                GetData();

        }



        public string GetNoTransaksi()
        {
            using(var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var noTransaksi = mumtaaz.Piutangs
                .OrderByDescending(x => x.Id)
                .Select(x => x.Id)
                .FirstOrDefault();

                if (!mumtaaz.Piutangs.Any())
                    noTransaksi++;
                else
                    noTransaksi++;

                return noTransaksi.ToString().PadLeft(4, '0') + "/BP/" + DateTime.Now.ToString("ddMM");
            }
            
        }

        public void LoadData(string namaPelanggan)
        {
            
            using (var cn = new SqlConnection(dbhelper.ConnectionString))
            {
                cn.Open();
                var query = "SELECT Penjualans.NoTransaksi, Penjualans.Tanggal, Pelanggans.Nama, Penjualans.TanggalJT, Penjualans.Sisa " +
                            "FROM Penjualans INNER JOIN Pelanggans on Pelanggans.Id = Penjualans.PelangganId " +
                            "WHERE Penjualans.Sisa > 0";

                if (!string.IsNullOrEmpty(lookPelanggan.Text))
                    query += "AND Pelanggans.Nama = '"+namaPelanggan+"'";

                var cmd = new SqlCommand(query, cn);
                var ada = new SqlDataAdapter(cmd);
                var dt = GetTable();
                ada.Fill(dt);

                gridControl1.DataSource = dt ;
                     
            }

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            if (e.Column.FieldName == "JumlahBayar")
            {

                var JumlahBayar = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6]));
                var total = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]));

                if (string.IsNullOrEmpty(lookPelanggan.Text) && JumlahBayar > 0)
                {
                    MessageBox.Show("Silahkan isi nama pelanggan terlebih dahulu", "Mumtaaz Herbal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "JumlahBayar", 0);
                    return;
                }

                var noTransaksi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();

                var query = mumtaaz.Penjualan
                    .Where(x => x.NoTransaksi == noTransaksi)
                    .FirstOrDefault();

                if(JumlahBayar > total)
                {
                    MessageBox.Show("Jumlah bayar yang diinput lebih besar dari Total.\n" +
                                    "Jumlah Total = " + total + "\n" +
                                    "Jumlah diketik = '" + JumlahBayar + "'" +
                                    "Jumlah bayar akan diotomatis dirubah sesuai jumlah total", "Mumtaaz Herbal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6], total);
                }
                GetTotalHarga();
            }
        }

        public void GetTotalHarga()
        {
            int totalHarga = 0;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                var jumlahBayar = 0;
                var rowHandle = gridView1.GetRowHandle(i);

                if (gridView1.GetRowCellValue(rowHandle, "JumlahBayar") != DBNull.Value)
                    jumlahBayar = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "JumlahBayar"));

                totalHarga += jumlahBayar;
            }
            txtTotal.Text = totalHarga.ToString();
        }

        public DataTable GetTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("NoTransaksi", typeof(string));
            dt.Columns.Add("Tanggal", typeof(DateTime));
            dt.Columns.Add("Nama", typeof(string));
            dt.Columns.Add("TanggalJT", typeof(DateTime));
            dt.Columns.Add("Sisa", typeof(int));
            //dt.Columns.Add("Total", typeof(int));
            dt.Columns.Add("JumlahBayar", typeof(int));

            return dt;
        }

        private void lookPelanggan_EditValueChanged(object sender, EventArgs e)
        {
            LoadData(lookPelanggan.Text);
        }

        //mengapus text di looksupplier
        private void lookPelanggan_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Back || e.KeyData == Keys.Delete))
            {
                ((LookUpEdit)sender).EditValue = null;
                e.Handled = true;
            }
        }

        public bool IsJumlahBayarFill()
        {
            for(int i = 0; i < gridView1.DataRowCount; i++)
            {
                var jumlahBayar = 0;
                var rowHandle = gridView1.GetRowHandle(i);
                if (gridView1.GetRowCellValue(rowHandle, "JumlahBayar") != DBNull.Value)
                    jumlahBayar = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "JumlahBayar"));

                if (jumlahBayar > 0)
                    return true;
            }
            return false;
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                DeleteEditTransaksi();
                edit = false;
                SimpanData();
                dftrPiutang.LoadData();
            }
            else
            {
                SimpanData();
                RefreshPage();
            }
        }

        public void RefreshPage()
        {
            edit = false;
            pembayaranPiutang_Load(null, EventArgs.Empty);
            txtTotal.Text = "0";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(gridView1.DataRowCount > 0)
            {
                MessageBox.Show("Batalkan transaksi ini ?", "Mumtaaz Herbal", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                RefreshPage();
            }
        }

        //get informasi daftar pembelian
        public void SimpanData()
        {
            if (!IsJumlahBayarFill())
            {
                MessageBox.Show("Jumlah bayar transaksi belum diisi.", "Mumtaaz Herbal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var piutang = new Piutang()
                {
                    NoTransaksi = txtTransaksi.Text,
                    Tanggal = DateTime.Now,
                    Total = int.Parse(txtTotal.Text.Replace(",", "")),
                    PelangganId = int.Parse(lookPelanggan.EditValue.ToString()),
                };

                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    var rowHandle = gridView1.GetRowHandle(i);
                    var jumlahBayar = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, gridView1.Columns[6]));

                    if (jumlahBayar <= 0)
                        continue;

                    var noTransaksi = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[0]).ToString();

                    var penjualan = mumtaaz.Penjualan
                    .Where(x => x.NoTransaksi == noTransaksi)
                    .FirstOrDefault();

                    var detailPiutang = new DetailPiutang()
                    {
                        JumlahBayar = jumlahBayar,
                        Penjualan = penjualan,
                        Sisa = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "Sisa")),
                        Piutang = piutang,
                    };

                    penjualan.Sisa -= jumlahBayar;
                    //penjualan.Piutang = piutang;

                    if (penjualan.Sisa == 0)
                        penjualan.TanggalJT = null;

                    mumtaaz.DetailPiutangs.Add(detailPiutang);
                    mumtaaz.Entry(penjualan).State = System.Data.Entity.EntityState.Modified;
                }
                mumtaaz.Piutangs.Add(piutang);
                mumtaaz.SaveChanges();
                MessageBox.Show("Transaksi berhasil", "Mumtaaz Herbal", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (checkPrint.Checked == true)
                    CetakPiutang();
                
            }
        }

        public void GetData()
        {
            var rowHandle = gridView.FocusedRowHandle;
            var noTransaksi = gridView.GetRowCellValue(rowHandle, "NoTransaksi").ToString();

            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                //Get Informasi Penjualan
                var transaksi = mumtaaz.Piutangs
                    .Where(x => x.NoTransaksi == noTransaksi)
                    .FirstOrDefault();

                txtTanggal.EditValue = transaksi.Tanggal;
                txtTransaksi.Text = transaksi.NoTransaksi.ToString();
                lookPelanggan.EditValue = transaksi.PelangganId;
                txtTotal.Text = transaksi.Total.ToString();

                //get list piutang
                var cn = new SqlConnection(dbhelper.ConnectionString);
                cn.Open();
                var listTransaksi = @"SELECT Penjualans.NoTransaksi, Penjualans.Tanggal, Pelanggans.Nama, Penjualans.TanggalJT, DetailPiutangs.Sisa, DetailPiutangs.JumlahBayar
                                    FROM DetailPiutangs
                                    INNER JOIN Piutangs ON Piutangs.Id = DetailPiutangs.PiutangId
                                    INNER JOIN Penjualans ON Penjualans.Id = DetailPiutangs.PenjualanId
                                    INNER JOIN Pelanggans ON Pelanggans.Id = Penjualans.pelangganId
                                    WHERE Piutangs.NoTransaksi = '"+noTransaksi+"'";

                var cmd = new SqlCommand(listTransaksi, cn);
                var ada = new SqlDataAdapter(cmd);
                var dt = GetTable();
                ada.Fill(dt);
                gridControl1.DataSource = dt;
                cn.Close();

            }
        }

        //delete transaksi yang ingin di update
        public void DeleteEditTransaksi()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                //find id yang di edit
                var query = (from i in mumtaaz.Piutangs
                             where i.NoTransaksi == txtTransaksi.Text
                             select i).FirstOrDefault();

                //get related pembelian (detail pembelian)
                var query1 = (from o in mumtaaz.DetailPiutangs
                              where o.PiutangId == query.Id
                              select o).ToList();

                //update item
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    var rowHandle = gridView1.GetRowHandle(i);
                    var noTransaksiPenjualan = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[0]).ToString();

                    var stok = (from o in mumtaaz.DetailPiutangs
                                join a in mumtaaz.Penjualan on o.PenjualanId equals a.Id
                                where a.NoTransaksi == noTransaksiPenjualan
                                select o.JumlahBayar).ToList();

                    var penjualanList = mumtaaz.Penjualan.Where(x => x.NoTransaksi == noTransaksiPenjualan).FirstOrDefault();

                    penjualanList.Sisa += stok[i];
                    mumtaaz.Entry(penjualanList).State = System.Data.Entity.EntityState.Modified;
                }

                //hapus related pembelian (detail pembelian)
                foreach (var i in query1)
                    mumtaaz.DetailPiutangs.Remove(i);

                mumtaaz.Piutangs.Remove(query);
                mumtaaz.SaveChanges();
            }
        }


        //get informasi piutang untuk di pass ke nota
        List<NotaPembayaranPiutang> piutangs = new List<NotaPembayaranPiutang>();
        public void GetInformasiPiutang()
        {
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                var rowHandle = gridView1.GetRowHandle(i);
                var jumlahBayar = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "JumlahBayar"));

                if (jumlahBayar <= 0)
                    continue;
                

                var piutang = new NotaPembayaranPiutang()
                {
                    NoTransaksi = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[0]).ToString().ToUpper(),
                    TanggalTrs = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[1]).ToString(),
                    Jumlah = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, gridView1.Columns[4])),
                    JumlahBayar = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, gridView1.Columns[6]))
                };

                piutangs.Add(piutang);
            }
        }

        public void CetakPiutang()
        {
            using (var printPiutang = new NotaPiutangViewer())
            {
                GetInformasiPiutang();
                printPiutang.PrintInvoicePiutang(this, piutangs);
                printPiutang.ShowDialog();
                piutangs.Clear();
            }
        }

        private void pembayaranPiutang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gridView1.DataRowCount != 0)
            {
                if (MessageBox.Show("Transaksi " + txtTransaksi.Text + " belum selesai, batalkan transaksi ?.", "Mumtaaz Herbal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }
    }
}