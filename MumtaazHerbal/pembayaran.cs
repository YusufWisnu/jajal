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
using MumtaazHerbal.Function;

namespace MumtaazHerbal
{
    public partial class pembayaran : DevExpress.XtraEditors.XtraForm
    {
        private GridView gridView;
        private string total;
        private kasir kasir;
        public List<Receipt> receipt;
        private pembelian pembelian;
        private bool _pembelian;
        private bool edit;
        private dftrPenjualan daftarPenjualan;

        public pembayaran()
        {
            InitializeComponent();
        }

        //constructor untuk pembayaran dari form kasir
        public pembayaran(kasir kasir,dftrPenjualan daftarPenjualan, string total, GridView gridView, List<Receipt
            > receipt, bool edit)
            : this()
        {
            this.total = total;
            this.gridView = gridView;
            this.kasir = kasir;
            this.receipt = receipt;
            this.edit = edit;
            this.daftarPenjualan = daftarPenjualan;
        }

        //constructor untuk pembayaran dari form pembelian
        public pembayaran(pembelian pembelian, string total, GridView gridView, bool _pembelian, List<Receipt> receipt)
            :this()
        {
            this.total = total;
            this.gridView = gridView;
            this.pembelian = pembelian;
            this._pembelian = _pembelian;
            this.receipt = receipt;
        }

        MumtaazContext mumtaaz;
        DbHelper dbhelper = new DbHelper();

        private void pembayaran_Load(object sender, EventArgs e)
        {
            mumtaaz = new MumtaazContext(dbhelper.ConnectionString);

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
                        lblKekurangan.Text = "Kembalian";
                    else
                        lblKekurangan.Text = "Kekurangan";

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
                lblKekurangan.Text = "Kembalian";
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

        //Simpan Doang
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if(kasir.EditKasir == true)
            {

            }

            //pembelian
            if (_pembelian)
            {
                SimpanPembelian();
                pembelian.RefreshPage();
                _pembelian = false;
            }

            //penjualan kasir
            else
            {
                if (CekStok()) return;
                if (CheckHarga()) return;

                Simpan();
                kasir.RefreshPage();
                this.Close();
            }
            
            

        }

        //Simpan & Cetak
        private void btnSimpanCetak_Click(object sender, EventArgs e)
        {
            var nota = new Nota();
            
            //pembelian
            if (_pembelian)
            {
                SimpanPembelian();
                pembelian.RefreshPage();
                _pembelian = false;
                nota.PrintInvoicePembelian(pembelian, this, receipt);
            }

            //penjualan kasir
            else
            {
                if (CekStok()) return;
                

                Simpan();
                nota.PrintInvoice(kasir, this, receipt);
                kasir.RefreshPage();
                this.Close();
            }
            
        }

        //select * from Penjualans where Tanggal between '2018/05/27' and '2018/05/27 23:59:59.999'

        public bool CheckHarga()
        {
            if (int.Parse(txtKekurangan.Text.Replace(",", "")) < 0 || int.Parse(txtTunai.Text.Replace(",", "")) <= 0)
            {
                XtraMessageBox.Show("Jumlah Pembayaran Belum Selesai.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        //simpan kasir
        public void Simpan()
        {

            //edit transaksi
            if (edit)
                DeleteEditTransaksi();

            Penjualan penjualan = new Penjualan();
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                penjualan.NoTransaksi = kasir.txtTransaksi.Text;
                penjualan.Tanggal = DateTime.Now;
                penjualan.PelangganId = int.Parse(kasir.lookPelanggan.EditValue.ToString());
                penjualan.TotalHarga = int.Parse(txtTotal.Text.Replace(",", ""));
                penjualan.IsPending = false;
                //jika pelanggan hutang
                if (int.Parse(txtKredit.Text.Replace(",", "")) > 0)
                {
                    penjualan.TanggalJT = DateTime.Now.AddDays(int.Parse(kasir.spinJT.Text));
                    penjualan.Sisa = int.Parse(txtKredit.Text.Replace(",", ""));
                }
                else
                {
                    penjualan.Sisa = 0;
                }

                for (int i = 0; i < gridView.DataRowCount; i++)
                {
                    var rowHandle = gridView.GetRowHandle(i);
                    var kodeItem = gridView.GetRowCellValue(rowHandle, gridView.Columns[1]).ToString();

                    var itemId = mumtaaz.Items
                        .Where(x => x.KodeItem == kodeItem)
                        .SingleOrDefault();


                    var detailPenjualan = new DetailPenjualan()
                    {
                        HargaBarang = Convert.ToInt32(gridView.GetRowCellValue(rowHandle, gridView.Columns[5])),
                        JumlahBarang = Convert.ToInt32(gridView.GetRowCellValue(rowHandle, gridView.Columns[3])),
                        Untung = Convert.ToInt32(gridView.GetRowCellValue(rowHandle, gridView.Columns[3])) - itemId.HargaJual,
                        Penjualan = penjualan,
                        ItemId = itemId.Id
                    };

                    mumtaaz.DetailPenjualans.Add(detailPenjualan);

                    //update Jumlah Barang
                    int jumlahBaru = itemId.Stok - Convert.ToInt32(gridView.GetRowCellValue(rowHandle, gridView.Columns[3]));
                    itemId.Stok = jumlahBaru;
                    mumtaaz.Entry(itemId).State = System.Data.Entity.EntityState.Modified;
                }

                mumtaaz.Penjualan.Add(penjualan);
                mumtaaz.SaveChanges();
                XtraMessageBox.Show("Transaksi Berhasil.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //load daftar penjualan setelah edit selesai
                if (edit)
                {
                    daftarPenjualan.LoadData();
                    edit = false;
                }


            }
        }

        

        //simpan pembelian
        public void SimpanPembelian()
        {
            if (int.Parse(txtKekurangan.Text.Replace(",", "")) < 0 || int.Parse(txtTunai.Text.Replace(",", "")) <= 0)
            {
                XtraMessageBox.Show("Jumlah Pembayaran Belum Selesai.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var tablePembelian = new Pembelian();
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                tablePembelian.NoTransaksi = pembelian.txtTransaksi.Text;
                tablePembelian.Tanggal = DateTime.Now;
                tablePembelian.SupplierId = int.Parse(pembelian.lookSupplier.EditValue.ToString());
                tablePembelian.TotalHarga = int.Parse(txtTotal.Text.Replace(",", ""));
                

                for (int i = 0; i < gridView.DataRowCount; i++)
                {
                    var rowHandle = gridView.GetRowHandle(i);
                    var kodeItem = gridView.GetRowCellValue(rowHandle, gridView.Columns[1]).ToString();

                    var itemId = mumtaaz.Items
                        .Where(x => x.KodeItem == kodeItem)
                        .FirstOrDefault();

                    var detailPembelian = new DetailPembelian()
                    {
                        HargaBarang = Convert.ToInt32(gridView.GetRowCellValue(rowHandle, gridView.Columns[5])),
                        JumlahBarang = Convert.ToInt32(gridView.GetRowCellValue(rowHandle, gridView.Columns[3])),
                        Pembelian = tablePembelian,
                        ItemId = itemId.Id
                    };

                    mumtaaz.DetailPembelians.Add(detailPembelian);

                    //update Jumlah Barang
                    int jumlahBaru = itemId.Stok + Convert.ToInt32(gridView.GetRowCellValue(rowHandle, gridView.Columns[3]));
                    itemId.Stok = jumlahBaru;
                    mumtaaz.Entry(itemId).State = System.Data.Entity.EntityState.Modified;
                }

                mumtaaz.Pembelians.Add(tablePembelian);
                mumtaaz.SaveChanges();
                XtraMessageBox.Show("Transaksi Berhasil.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //cek jika jumlah stok kurang
        public bool CekStok()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                for (int i = 0; i < gridView.DataRowCount; i++)
                {
                    var rowHandle = gridView.GetRowHandle(i);
                    var kodeItem = gridView.GetRowCellValue(rowHandle, gridView.Columns[1]).ToString();
                    var stok = Convert.ToInt32(gridView.GetRowCellValue(rowHandle, gridView.Columns[3]));

                    var query = mumtaaz.Items.Where(x => x.KodeItem == kodeItem).FirstOrDefault();

                    if(query.Stok < stok)
                    {
                        MessageBox.Show("Maaf stok item untuk kode item : ["+query.KodeItem +"] tidak cukup", "Mumtaaz Herbal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
                       
                }
            }
            return false;
        }

        private void pembayaran_FormClosing(object sender, FormClosingEventArgs e)
        {
            receipt.Clear();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //delete transaksi yang ingin di update
        public void DeleteEditTransaksi()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                //find id yang di edit
                var query = (from i in mumtaaz.Penjualan
                             where i.NoTransaksi == kasir.txtTransaksi.Text
                             select i).FirstOrDefault();

                //get related pembelian (detail pembelian)
                var query1 = (from o in mumtaaz.DetailPenjualans
                              where o.PenjualanId == query.Id
                              select o).ToList();


                //update item
                for (int i = 0; i < gridView.DataRowCount; i++)
                {
                    var rowHandle = gridView.GetRowHandle(i);
                    var kodeItem = gridView.GetRowCellValue(rowHandle, gridView.Columns[1]).ToString();

                    var stok = (from o in mumtaaz.DetailPenjualans
                                join a in mumtaaz.Penjualan on o.PenjualanId equals a.Id
                                where a.NoTransaksi == kasir.txtTransaksi.Text
                                select o.JumlahBarang).ToList();


                    var itemList = mumtaaz.Items.Where(x => x.KodeItem == kodeItem).FirstOrDefault();

                    itemList.Stok = itemList.Stok + stok[i];
                    mumtaaz.Entry(itemList).State = System.Data.Entity.EntityState.Modified;

                }

                //hapus related pembelian (detail pembelian)
                foreach (var i in query1)
                    mumtaaz.DetailPenjualans.Remove(i);


                mumtaaz.Penjualan.Remove(query);
                mumtaaz.SaveChanges();
            }
        }



        ////cetak nota

        //private void PrintReceipt()
        //{
        //    PrintDialog printDialog = new PrintDialog();
        //    PrintDocument printDocument = new PrintDocument();

        //    printDialog.Document = printDocument;

        //    printDocument.PrintPage += PrintDocument_PrintPage;

        //    DialogResult result = printDialog.ShowDialog();

        //    if(result == DialogResult.OK)
        //    {
        //        printDocument.Print();
        //    }
        //}

        //private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    Graphics graphic = e.Graphics;

        //    Font font = new Font("Courier New", 6);

        //    float fontHeight = font.GetHeight();

        //    int startX = 10;
        //    int startY = 10;
        //    int offset = 40;

        //    graphic.DrawString("Toko Mumtaz Herbal".PadLeft(40), new Font("Courier New", 6), new SolidBrush(Color.Black), startX, startY);
        //    graphic.DrawString("Jl. Raya Serang, Km 13,8 Pengkolan Pasir Gadung", new Font("Courier New", 6), new SolidBrush(Color.Black), startX, 20);
        //    graphic.DrawString("085313255683".PadLeft(19), new Font("Courier New", 6), new SolidBrush(Color.Black), startX, 30);
        //    //Mumtaaz Herbal Jl.Raya Serang, km 13,8 Pengkolan Pasir Gadung 085313255683 
        //    for (int i = 0; i < gridView.DataRowCount; i++)
        //    {
        //        var rowHandle = gridView.GetRowHandle(i);
        //        string namaItem = gridView.GetRowCellValue(rowHandle, "NamaItem").ToString().PadRight(30);
        //        string jumlahItem = gridView.GetRowCellValue(rowHandle, "Jumlah").ToString().PadRight(8);
        //        string total = gridView.GetRowCellValue(rowHandle, "Total").ToString();
        //        string productLine = namaItem + jumlahItem + total;

        //        graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);

        //        offset += (int)fontHeight + 5;
        //    }

        //    offset += 20;

        //    graphic.DrawString("Total : ".PadRight(38) + txtTotal.Text, font, new SolidBrush(Color.Black), startX, startY + offset);

        //}


    }
}
       