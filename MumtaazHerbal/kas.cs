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
using DevExpress.XtraGrid.Views.Grid;

namespace MumtaazHerbal
{
    public partial class kas : DevExpress.XtraEditors.XtraForm
    {
        private DbHelper dbhelper;
        private dftrKasKeluar dftrKas;
        private GridView gridView;
        private bool edit;
        private string noTransaksi;
        public kas()
        {
            dbhelper = new DbHelper();
            InitializeComponent();
        }

        public kas(dftrKasKeluar dftrKas, GridView gridView, bool edit, string noTransaksi)
            :this()
        {
            this.dftrKas= dftrKas;
            this.gridView = gridView;
            this.edit = edit;
            this.noTransaksi = noTransaksi;
        }

        MumtaazContext mumtaaz;

        private void kas_Load(object sender, EventArgs e)
        {
            mumtaaz = new MumtaazContext(dbhelper.ConnectionString);

            txtTanggal.EditValue = DateTime.Now;
            txtTransaksi.Text = GetNoTransaksi();

            gridControl1.DataSource = GetTable();

            //edit piutang
            if (edit)
                GetData();
        }

        public string GetNoTransaksi()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var noTransaksi = mumtaaz.KasKeluars
                .OrderByDescending(x => x.Id)
                .Select(x => x.Id)
                .FirstOrDefault();

                if (!mumtaaz.KasKeluars.Any())
                    noTransaksi++;
                else
                    noTransaksi++;

                return noTransaksi.ToString().PadLeft(4, '0') + "/KASO/" + DateTime.Now.ToString("ddMM");
            }

        }

        public DataTable GetTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("No", typeof(int));
            dt.Columns.Add("Keterangan", typeof(string));
            dt.Columns.Add("Total", typeof(int));

            return dt;
        }

        public void GetNomor()
        {
            var b = 1;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                gridView1.SetRowCellValue(gridView1.GetRowHandle(i), "No", b++);
            }
        }

        public void GetTotalHarga()
        {
            int totalHarga = 0;
            for (int i = 0; i <= gridView1.DataRowCount; i++)
            {
                int rowHandle = gridView1.GetRowHandle(i);
                if (gridView1.GetRowCellValue(rowHandle, "Total") != DBNull.Value)
                    totalHarga += Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "Total"));

            }

            txtTotal.Text = totalHarga.ToString();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //for (int i = 0; i < gridView1.DataRowCount; i++)
            //{
            //    var namaItem = 0;

            //    var rowHandle = gridView1.GetRowHandle(i);
            //    if (gridView1.GetRowCellValue(rowHandle, "Total") != DBNull.Value)
            //        namaItem = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "Total"));

            //    if (namaItem <= 0)
            //        gridView1.DeleteRow(rowHandle);
            //}

            GetNomor();
            GetTotalHarga();
        }

        //HAPUS
        private void btnHapus_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
            GetNomor();
            GetTotalHarga();
        }

        //simpan
        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount == 0)
            {
                MessageBox.Show("Mohon keterangan terlebih dahulu.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (edit)
            {
                DeleteEditTransaksi();
                SimpanData();
                edit = false;
                dftrKas.LoadData();
                RefreshPage();
            }
            else
            {
                SimpanData();
                RefreshPage();
            }
            
        }

        //batal
        private void btnCancel_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }

        public void SimpanData()
        {
            if(gridView1.DataRowCount == 0)
            {
                MessageBox.Show("Mohon isi kolom yang ada terlebih dahulu", "Mumtaaz Herbal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Kas = new KasKeluar();
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                Kas.NoTransaksi = txtTransaksi.Text;
                Kas.Tanggal = DateTime.Now;
                Kas.Keterangan = txtKeterangan.Text;
                Kas.Total = int.Parse(txtTotal.Text.Replace(",", ""));


                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    var rowHandle = gridView1.GetRowHandle(i);
                    var detailKas = new DetailKasKeluar();

                    detailKas.KasKeluar = Kas;
                    detailKas.Keterangan = gridView1.GetRowCellValue(rowHandle, "Keterangan").ToString();
                    if (gridView1.GetRowCellValue(rowHandle, "Total") != DBNull.Value)
                        detailKas.Total = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "Total"));

                    mumtaaz.DetailKasKeluars.Add(detailKas);
                }

                mumtaaz.KasKeluars.Add(Kas);
                mumtaaz.SaveChanges();
                XtraMessageBox.Show("Transaksi Berhasil", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void GetData()
        {
            var rowHandle = gridView.FocusedRowHandle;
            var noTransaksi = gridView.GetRowCellValue(rowHandle, "NoTransaksi").ToString();

            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                //Get Informasi Penjualan
                var transaksi = mumtaaz.KasKeluars
                    .Where(x => x.NoTransaksi == noTransaksi)
                    .FirstOrDefault();

                txtTanggal.EditValue = transaksi.Tanggal;
                txtTransaksi.Text = transaksi.NoTransaksi.ToString();
                txtTotal.Text = transaksi.Total.ToString();
                txtKeterangan.Text = transaksi.Keterangan;

                //get list item
                var listItem = from o in mumtaaz.DetailKasKeluars
                               join a in mumtaaz.KasKeluars on o.KaskeluarId equals a.Id
                               where a.NoTransaksi == noTransaksi
                               select new
                               {
                                   o.Keterangan,
                                   o.Total

                               };

                //get Item
                int total = 0;
                foreach (var i in listItem.ToList())
                {
                    gridView1.AddNewRow();
                    var row = gridView1.GetRowHandle(gridView1.DataRowCount);

                    if (gridView1.IsNewItemRow(row))
                    {
                        gridView1.SetRowCellValue(row, gridView1.Columns[1], i.Keterangan);
                        gridView1.SetRowCellValue(row, gridView1.Columns[2], i.Total);
                    }

                    GetTotalHarga();
                    GetNomor();
                    gridView1.MoveLast();
                }

            }
        }

        //delete transaksi yang ingin di update
        public void DeleteEditTransaksi()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                //find id yang di edit
                var query = (from i in mumtaaz.KasKeluars
                             where i.NoTransaksi == txtTransaksi.Text
                             select i).FirstOrDefault();

                //get related kas (detail kaskeluar)
                var query1 = (from o in mumtaaz.DetailKasKeluars
                              where o.KaskeluarId == query.Id
                              select o).ToList();

                //hapus related pembelian (detail pembelian)
                foreach (var i in query1)
                    mumtaaz.DetailKasKeluars.Remove(i);


                mumtaaz.KasKeluars.Remove(query);
                mumtaaz.SaveChanges();
            }
        }

        public void RefreshPage()
        {
            edit = false;
            kas_Load(null, EventArgs.Empty);
            txtTotal.Text = "0";
            txtKeterangan.Text = string.Empty;
        }

        private void kas_FormClosing(object sender, FormClosingEventArgs e)
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