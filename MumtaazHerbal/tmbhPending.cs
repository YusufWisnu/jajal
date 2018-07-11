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
using MumtaazHerbal.Function;

namespace MumtaazHerbal
{
    public partial class tmbhPending : DevExpress.XtraEditors.XtraForm
    {

        private GridView gridView;
        private string total;
        private kasir kasir;
        public List<Receipt> receipt;

        public tmbhPending()
        {
            InitializeComponent();
        }

        public tmbhPending(kasir kasir, string total, GridView gridView, List<Receipt
           > receipt)
           : this()
        {
            this.total = total;
            this.gridView = gridView;   
            this.kasir = kasir;
            this.receipt = receipt;
        }

        DbHelper dbhelper = new DbHelper();


        private void tmbhPending_Load(object sender, EventArgs e)
        {
            txtNoTransaksi.Text = kasir.txtTransaksi.Text;
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            Pending();
        }

        public void Pending()
        {
            if (MessageBox.Show("Masukan ke daftar pending ?", "Pending", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Penjualan penjualan = new Penjualan();

                //cek jika transaksi sudah di pending
                using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
                {
                        penjualan.NoTransaksi = kasir.txtTransaksi.Text;
                        penjualan.Tanggal = DateTime.Today;
                        penjualan.PelangganId = int.Parse(kasir.lookPelanggan.EditValue.ToString());
                        penjualan.TotalHarga = int.Parse(kasir.txtTotal.Text.Replace(",", ""));
                        penjualan.IsPending = true;
                        penjualan.Keterangan = txtKeterangan.Text;

                        for (int i = 0; i < gridView.DataRowCount; i++)
                        {
                            var rowHandle = gridView.GetRowHandle(i);
                            var kodeItem = gridView.GetRowCellValue(rowHandle, "KodeItem").ToString();

                            var itemId = mumtaaz.Items
                                .Where(x => x.KodeItem == kodeItem)
                                .SingleOrDefault();

                            var detailPenjualan = new DetailPenjualan()
                            {
                                JumlahBarang = Convert.ToInt32(gridView.GetRowCellValue(rowHandle, gridView.Columns[3])),
                                Penjualan = penjualan,
                                ItemId = itemId.Id,
                                HargaBarang = Convert.ToInt32(gridView.GetRowCellValue(rowHandle, gridView.Columns[5]))

                            };

                            mumtaaz.DetailPenjualans.Add(detailPenjualan);

                        }

                        mumtaaz.Penjualan.Add(penjualan);
                        mumtaaz.SaveChanges();
                        this.Close();
                        kasir.RefreshPage();
                }
            }
        }
    }
}

