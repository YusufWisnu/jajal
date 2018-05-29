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
using System.Drawing.Printing;

namespace MumtaazHerbal
{
    public partial class pembayaran : DevExpress.XtraEditors.XtraForm
    {
        private GridView gridView;
        private string total;
        private kasir kasir;


        public pembayaran()
        {
            InitializeComponent();
        }

        public pembayaran(kasir kasir, string total, GridView gridView)
            : this()
        {
            this.total = total;
            this.gridView = gridView;
            this.kasir = kasir;
        }

        private void pembayaran_Load(object sender, EventArgs e)
        {
            txtTotal.Text = total;
            txtTunai.Focus();
        }

        private void txtTunai_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTotal.Text) && !string.IsNullOrEmpty(txtTunai.Text))
            {

                if (Convert.ToInt32(txtKredit.Text.Replace(",", "")) > 0)
                {
                    int total = int.Parse(txtTotal.Text.Replace(",", ""));
                    int tunai = int.Parse(txtTunai.Text.Replace(",", ""));
                    txtKredit.Text = (total - tunai).ToString();


                }
                else
                {
                    int total = int.Parse(txtTotal.Text.Replace(",", ""));
                    int tunai = int.Parse(txtTunai.Text.Replace(",", ""));
                    txtKekurangan.Text = (tunai - total).ToString();
                    if (Convert.ToInt32(txtKekurangan.Text.Replace(",", "")) >= 0)
                        lblKekurangan.Text = " Kembalian  :";
                    else
                        lblKekurangan.Text = "Kekurangan :";

                    txtTotalBayar.Text = txtTunai.Text;
                }
            }
        }

        private void txtKredit_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtKredit.Text.Replace(",", "")) <= 0)
                txtKredit.Text = "0";
            else
            {
                txtKekurangan.Text = "0";
                lblKekurangan.Text = "Kembalian  :";
            }
        }

        private void txtKredit_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtKredit.Text.Replace(",", "")) > 0)
            {
                txtKredit.Text = txtTotal.Text;
                txtTotalBayar.Text = txtTotal.Text;

            }

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtKekurangan.Text.Replace(",", "")) < 0)
            {
                XtraMessageBox.Show("Jumlah Pembayaran Belum Selesai.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Penjualan penjualan = new Penjualan();
            using (var mumtaaz = new MumtaazContext())
            {
                penjualan.NoTransaksi = kasir.txtTransaksi.Text;
                penjualan.Tanggal = DateTime.Today;
                penjualan.PelangganId = int.Parse(kasir.lookPelanggan.EditValue.ToString());
                penjualan.TotalHarga = int.Parse(txtTotal.Text.Replace(",", ""));

                for (int i = 0; i < gridView.DataRowCount; i++)
                {
                    var rowHandle = gridView.GetRowHandle(i);
                    var kodeItem = gridView.GetRowCellValue(rowHandle, "KodeItem").ToString();

                    var itemId = mumtaaz.Items
                        .Where(x => x.KodeItem == kodeItem)
                        .SingleOrDefault();


                    var detailPenjualan = new DetailPenjualan()
                    {
                        JumlahBarang = Convert.ToInt32(gridView.GetRowCellValue(rowHandle, "Total")),
                        Penjualan = penjualan,
                        ItemId = itemId.Id
                    };

                    mumtaaz.DetailPenjualans.Add(detailPenjualan);

                    //update Jumlah Barang
                    int jumlahBaru = itemId.Stok - Convert.ToInt32(gridView.GetRowCellValue(rowHandle, "Jumlah"));
                    itemId.Stok = jumlahBaru;
                    mumtaaz.Entry(itemId).State = System.Data.Entity.EntityState.Modified;
                }

                mumtaaz.Penjualan.Add(penjualan);
                mumtaaz.SaveChanges();
                XtraMessageBox.Show("Transaksi Berhasil.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PrintReceipt();
            }
        }

        //select * from Penjualans where Tanggal between '2018/05/27' and '2018/05/27 23:59:59.999'



        //cetak nota

        private void PrintReceipt()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            printDocument.PrintPage += PrintDocument_PrintPage;

            DialogResult result = printDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 6);

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("Toko Mumtaz Herbal".PadLeft(40), new Font("Courier New", 6), new SolidBrush(Color.Black), startX, startY);
            graphic.DrawString("Jl. Raya Serang, Km 13,8 Pengkolan Pasir Gadung", new Font("Courier New", 6), new SolidBrush(Color.Black), startX, 20);
            graphic.DrawString("085313255683".PadLeft(19), new Font("Courier New", 6), new SolidBrush(Color.Black), startX, 30);
            //Mumtaaz Herbal Jl.Raya Serang, km 13,8 Pengkolan Pasir Gadung 085313255683 
            for (int i = 0; i < gridView.DataRowCount; i++)
            {
                var rowHandle = gridView.GetRowHandle(i);
                string namaItem = gridView.GetRowCellValue(rowHandle, "NamaItem").ToString().PadRight(30);
                string jumlahItem = gridView.GetRowCellValue(rowHandle, "Jumlah").ToString().PadRight(8);
                string total = gridView.GetRowCellValue(rowHandle, "Total").ToString();
                string productLine = namaItem + jumlahItem + total;

                graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);

                offset += (int)fontHeight + 5;
            }

            offset += 20;

            graphic.DrawString("Total : ".PadRight(38) + txtTotal.Text, font, new SolidBrush(Color.Black), startX, startY + offset);

        }

        
    }
}
       