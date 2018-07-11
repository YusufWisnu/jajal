using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using MumtaazHerbal.Function;

namespace MumtaazHerbal
{
    public partial class dftrPending : DevExpress.XtraEditors.XtraForm
    {

        private kasir kasir;
        private  GridControl gridControl;
       private GridView gridView;

        public dftrPending()
        {
            InitializeComponent();
        }

        public dftrPending(kasir kasir, GridControl gridControl, GridView gridView)
            :this()
        {
            this.kasir = kasir;
            this.gridControl = gridControl;
            this.gridView = gridView;
        }

        DbHelper dbhelper = new DbHelper();


        private void dftrPending_Load(object sender, EventArgs e)
        {

            DisplayData();
        }

        
        public void DisplayData()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                //var query = from o in mumtaaz.DetailPenjualans
                //            join a in mumtaaz.Penjualan on o.PenjualanId equals a.Id
                //            where o.IsPending == true
                //            select new
                //            {
                //                a.NoTransaksi,
                //                a.Tanggal,
                //                o.Keterangan

                //            };

                var query = from o in mumtaaz.Penjualan
                            where o.IsPending == true
                            select new
                            {
                                o.NoTransaksi,
                                o.Tanggal,
                                o.Keterangan
                            };


                detailPenjualanBindingSource.DataSource = query.ToList();

            }
        }

        //double klik
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GetData();
            removePending();
            this.Close();
        }

        //buton Ok
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            GetData();
            removePending();
            this.Close();
        }

        public void GetData()
        {
            var rowHandle = gridView1.FocusedRowHandle;
            var noTransaksi = gridView1.GetRowCellValue(rowHandle, "NoTransaksi").ToString();

            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                //Get Informasi Penjualan
                var transaksi = mumtaaz.Penjualan
                    .Where(x => x.NoTransaksi == noTransaksi)
                    .FirstOrDefault();

                kasir.txtTanggal.EditValue = transaksi.Tanggal;
                kasir.txtTransaksi.Text = transaksi.NoTransaksi.ToString();
                kasir.lookPelanggan.EditValue = transaksi.PelangganId;
                kasir.txtTotal.Text = transaksi.TotalHarga.ToString();

                string nama = string.Empty;

                var listItem =  from o in mumtaaz.DetailPenjualans
                                join a in mumtaaz.Penjualan on o.PenjualanId equals a.Id
                                join i in mumtaaz.Items on o.ItemId equals i.Id
                                where a.NoTransaksi == noTransaksi
                                select new
                                {
                                    i.NamaItem,
                                    i.KodeItem,
                                    o.JumlahBarang,
                                    i.Satuan,
                                    o.HargaBarang

                                };

                //get Item
                int total = 0;
                foreach (var i in listItem.ToList())
                {
                    gridView.AddNewRow();
                    var row = gridView.GetRowHandle(gridView.DataRowCount);

                    if (gridView.IsNewItemRow(row))
                    {

                        gridView.SetRowCellValue(row, gridView.Columns[1], i.KodeItem);
                        gridView.SetRowCellValue(row, gridView.Columns[2], i.NamaItem);
                        gridView.SetRowCellValue(row, gridView.Columns[3], i.JumlahBarang);
                        gridView.SetRowCellValue(row, gridView.Columns[4], i.Satuan);
                        gridView.SetRowCellValue(row, gridView.Columns[5], i.HargaBarang);

                        int jumlah = Convert.ToInt32(gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns[3]));
                        int harga = Convert.ToInt32(gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns[5]));

                        total = jumlah * harga;
                        gridView.SetRowCellValue(row, gridView.Columns[6], total);

                    }

                    kasir.GetTotalHarga();
                    gridView.MoveLast();
                }  

            }
        }

        //hapus pending
        public void removePending()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var rowHandle = gridView1.FocusedRowHandle;
                var noTransaksi = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[0]).ToString();
                
                //get penjualan
                var query = (from i in mumtaaz.Penjualan
                             where i.NoTransaksi == noTransaksi
                             select i).FirstOrDefault();

                //get related penjualan (detail penjualan)
                var query1 = (from o in mumtaaz.DetailPenjualans
                              where o.PenjualanId == query.Id
                              select o).ToList();

                foreach (var i in query1)
                    mumtaaz.DetailPenjualans.Remove(i);


                mumtaaz.Penjualan.Remove(query);
                mumtaaz.SaveChanges();
                MessageBox.Show("success");
            }
        }

        //button close
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}