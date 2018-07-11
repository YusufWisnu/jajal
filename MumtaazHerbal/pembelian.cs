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
    public partial class pembelian : DevExpress.XtraEditors.XtraForm
    {
        private GridView gridView;
        private bool edit;
        private dftrPmb daftarPembelian;
        private string noTransaksi;

        public pembelian()
        {
            InitializeComponent();

            //timer
            var t = new Timer();
            t.Interval = 1000;  // in miliseconds
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }

        public pembelian(dftrPmb daftarPembelian, GridView gridView, bool edit, string noTransaksi)
            :this()
        {
            this.gridView = gridView;
            this.edit = edit;
            this.daftarPembelian = daftarPembelian;
            this.noTransaksi = noTransaksi;
        }

        DbHelper dbhelper = new DbHelper();
        MumtaazContext mumtaaz;


        private void pembelian_Load(object sender, EventArgs e)
        {
            mumtaaz = new MumtaazContext(dbhelper.ConnectionString);

            txtTanggal.EditValue = DateTime.Now;
            txtuser.Text = "ADMIN";
            supplierBindingSource.DataSource = mumtaaz.Suppliers.ToList();
            GetNoTransaksi();
            GetInformasiSupplier();

            //tabel pembelian item
            DataTable dt = new DataTable();
            dt.Columns.Add("No", typeof(string));
            dt.Columns.Add("KodeItem", typeof(string));
            dt.Columns.Add("NamaItem", typeof(string));
            dt.Columns.Add("JumlahBarang", typeof(int));
            dt.Columns.Add("Satuan", typeof(string));
            dt.Columns.Add("HargaBarang", typeof(int));
            dt.Columns.Add("Total", typeof(int));

            gridControl1.DataSource = dt;

            //edit daftar pembelian
            if (edit)
                GetData();
        }

        public void GetNoTransaksi()
        {
            ////get no transaksi
            //var query = mumtaaz.Pembelians
            //    .OrderByDescending(x => x.Id)
            //    .FirstOrDefault();

            ////ambil 4 kata pertama 
            //var splitWord = query.NoTransaksi.Take(4).ToArray();

            ////gabungkan kemudian increment
            //var noTransaksi = int.Parse(new string(splitWord.Take(4).ToArray()));
            //noTransaksi++;

            //get no transaksi
            var noTransaksi = mumtaaz.Pembelians
                .OrderByDescending(x => x.Id)
                .Select(x => x.Id)
                .FirstOrDefault();

            if (!mumtaaz.Pembelians.Any())
                noTransaksi++;

            noTransaksi++;

            txtTransaksi.Text = noTransaksi.ToString().PadLeft(4, '0') + "/BL/" + DateTime.Now.ToString("ddMM");

        }

        public void GetInformasiSupplier()
        {
            var query = mumtaaz.Suppliers
                .FirstOrDefault();

            lookSupplier.EditValue = query.Id;

            lblAlamat.Text = "Alamat : " + query.Alamat;
            lblNo.Text =     "No.HP  : " + query.NoHP;
            
        }

        private void btnDaftarItem_Click(object sender, EventArgs e)
        {
            bool getItem = true;
            dftrItem daftarItem = new dftrItem(this, getItem, gridView1);
            daftarItem.ShowDialog();
        }

        private void lookSupplier_EditValueChanged(object sender, EventArgs e)
        {
            var query = mumtaaz.Suppliers
                .Where(x => x.Id.ToString() == lookSupplier.EditValue.ToString())
                .FirstOrDefault();

            lblAlamat.Text = "Alamat : "+query.Alamat;
            lblNo.Text =     "No.HP  : " +query.NoHP;
                
        }

        //tambah item keranjang
        public void CreateNewRow(string kodeItem, string namaItem, string satuan, int harga)
        {
            int total = 0;

            gridView1.AddNewRow();
            int rowHandle = gridView1.GetRowHandle(gridView1.DataRowCount);

            if (gridView1.IsNewItemRow(rowHandle))
            {

                gridView1.SetRowCellValue(rowHandle, gridView1.Columns[1], kodeItem);
                gridView1.SetRowCellValue(rowHandle, gridView1.Columns[2], namaItem);
                gridView1.SetRowCellValue(rowHandle, gridView1.Columns[3], int.Parse(txtJumlah.Text));
                gridView1.SetRowCellValue(rowHandle, gridView1.Columns[4], satuan);
                gridView1.SetRowCellValue(rowHandle, gridView1.Columns[5], harga);

                int jumlah = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]));
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[5]) != DBNull.Value)
                {
                    harga = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[5]));
                }

                total = harga * jumlah;
                gridView1.SetRowCellValue(rowHandle, gridView1.Columns[6], total);

            }

            GetTotalHarga();
            gridView1.MoveLast();
        }

        //hitung total harga di keranjang pembelian
        public void GetTotalHarga()
        {
            int totalHarga = 0;
            for (int i = 0; i <= gridView1.DataRowCount; i++)
            {
                int rowHandle = gridView1.GetRowHandle(i);
                totalHarga += Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "Total"));
            }

            txtTotal.Text = totalHarga.ToString();

        }

        private void txtKodeItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                bool getItem = true;
                dftrItem daftarItem = new dftrItem(this, getItem, txtKodeItem.Text, gridView1);
                daftarItem.ShowDialog();
            }
        }

        // Pemberian nomor otomatis
        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.Caption == "No")
            {
                e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "HargaBarang")
            {
                int total = 0;

                var kodeItem = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KodeItem").ToString();
                int harga = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HargaBarang"));
                int jumlah = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "JumlahBarang"));

                total = harga * jumlah;
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6], total);

                GetTotalHarga();

                var hargaDatabase = mumtaaz.Items
                    .Where(x => x.KodeItem == kodeItem)
                    .Select(x => x.HargaJual)
                    .FirstOrDefault();

                if(hargaDatabase != harga)
                {
                    if (MessageBox.Show("Apakah Harga Pokok akan diubah di master data?", "Ubah Harga Pokok", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var editHarga = new editHargaPembelian(kodeItem, harga);
                        editHarga.ShowDialog();
                    }
                }
                

            }

            if (e.Column.FieldName == "JumlahBarang")
            {
                int total = 0;
                int harga = 0;

                var kodeItem = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KodeItem").ToString();
                var jumlah = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "JumlahBarang"));
                //var harga = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HargaBarang"));


                var query = mumtaaz.Items
                    .Where(x => x.KodeItem == kodeItem)
                    .SingleOrDefault();

                //if(query.Stok != jumlah)
                //{
                //    if (query.Stok < jumlah)
                //    {
                //        MessageBox.Show("Jumlah item melebihi stok.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "JumlahBarang", query.Stok);
                //        return;
                //    }
                //}
                //int harga = 0;

                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HargaBarang") != DBNull.Value)
                {
                    harga = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HargaBarang"));
                }

                total = harga * jumlah;
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6], total);

                GetTotalHarga();
            }
        }

        //Timer
        public void t_Tick(object sender, EventArgs e)
        {
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            //padding leading zero
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            txtTimer.Text = time;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Batalkan transaksi ini ?", "Batal Transaksi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                RefreshPage();
        }

        public void RefreshPage()
        {
            edit = false;
            pembelian_Load(null, EventArgs.Empty);
            txtTotal.Text = "0";
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount == 0)
                MessageBox.Show("Keranjang belanja kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (MessageBox.Show("Hapus item ini?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (edit)
                {
                    using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
                    {
                        var rowHandle = gridView1.FocusedRowHandle;
                        var kodeItem = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[1]).ToString();

                        var stok = (from o in mumtaaz.DetailPembelians
                                    join a in mumtaaz.Pembelians on o.PembelianId equals a.Id
                                    where a.NoTransaksi == noTransaksi
                                    select o.JumlahBarang).FirstOrDefault();


                        var itemList = mumtaaz.Items.Where(x => x.KodeItem == kodeItem).FirstOrDefault();

                        itemList.Stok = itemList.Stok - stok;
                        mumtaaz.Entry(itemList).State = System.Data.Entity.EntityState.Modified;
                        gridView1.DeleteRow(rowHandle);
                        GetTotalHarga();
                    }
                }
                else
                {
                    gridView1.DeleteRow(gridView1.FocusedRowHandle);
                    GetTotalHarga();
                }
                
            }
        }

        //button simpan
        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount == 0)
            {
                MessageBox.Show("Mohon pilih item terlebih dahulu.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (edit)
            {
                DeleteEditTransaksi();
                SimpanPembelian();
                edit = false;
                daftarPembelian.LoadData();
                RefreshPage();
            }
            else
            {
                GetKeranjangItem();
                SimpanPembelian();
                receipts.Clear();
                RefreshPage();
            }
        }

        List<Receipt> receipts = new List<Receipt>();
        public void GetKeranjangItem()
        {


            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                int rowHandle = gridView1.GetRowHandle(i);
                var receipt = new Receipt()
                {
                    NamaItem = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[1]).ToString().ToUpper(),
                    Harga = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, gridView1.Columns[5])),
                    JumlahItem = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, gridView1.Columns[3])),
                    Total = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, gridView1.Columns[6])),
                    Tipe = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[4]).ToString()
                };

                receipts.Add(receipt);
            }
        }

        public void SimpanPembelian()
        {
            
            var tablePembelian = new Pembelian();
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                tablePembelian.NoTransaksi = txtTransaksi.Text;
                tablePembelian.Tanggal = DateTime.Now;
                tablePembelian.SupplierId = int.Parse(lookSupplier.EditValue.ToString());
                tablePembelian.TotalHarga = int.Parse(txtTotal.Text.Replace(",", ""));


                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    var rowHandle = gridView1.GetRowHandle(i);
                    var kodeItem = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[1]).ToString();

                    var itemId = mumtaaz.Items
                        .Where(x => x.KodeItem == kodeItem)
                        .FirstOrDefault();


                    var detailPembelian = new DetailPembelian()
                    {
                        HargaBarang = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, gridView1.Columns[5])),
                        JumlahBarang = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, gridView1.Columns[3])),
                        Pembelian = tablePembelian,
                        ItemId = itemId.Id
                    };

                    mumtaaz.DetailPembelians.Add(detailPembelian);

                    //update Jumlah Barang
                    int jumlahBaru = itemId.Stok + Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, gridView1.Columns[3]));
                    itemId.Stok = jumlahBaru;
                    mumtaaz.Entry(itemId).State = System.Data.Entity.EntityState.Modified;
                }

                
                mumtaaz.Pembelians.Add(tablePembelian);
                mumtaaz.SaveChanges();
                XtraMessageBox.Show("Transaksi Berhasil", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void SimpanEditPembelian()
        {

        }

        //form closing event
        private void pembelian_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(gridView1.DataRowCount != 0)
            {
                if (MessageBox.Show("Transaksi "+txtTransaksi.Text+" belum selesai, batalkan transaksi ?.", "Mumtaaz Herbal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
                
            }
        }

        //get informasi daftar pembelian
        public void GetData()
        {
            var rowHandle = gridView.FocusedRowHandle;
            var noTransaksi = gridView.GetRowCellValue(rowHandle, "NoTransaksi").ToString();

            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                //Get Informasi Penjualan
                var transaksi = mumtaaz.Pembelians
                    .Where(x => x.NoTransaksi == noTransaksi)
                    .FirstOrDefault();

                txtTanggal.EditValue = transaksi.Tanggal;
                txtTransaksi.Text = transaksi.NoTransaksi.ToString();
                lookSupplier.EditValue = transaksi.SupplierId;
                txtTotal.Text = transaksi.TotalHarga.ToString();

                //get list item
                var listItem = from o in mumtaaz.DetailPembelians
                               join a in mumtaaz.Pembelians on o.PembelianId equals a.Id
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
                    gridView1.AddNewRow();
                    var row = gridView1.GetRowHandle(gridView1.DataRowCount);

                    if (gridView1.IsNewItemRow(row))
                    {

                        gridView1.SetRowCellValue(row, gridView1.Columns[1], i.KodeItem);
                        gridView1.SetRowCellValue(row, gridView1.Columns[2], i.NamaItem);
                        gridView1.SetRowCellValue(row, gridView1.Columns[3], i.JumlahBarang);
                        gridView1.SetRowCellValue(row, gridView1.Columns[4], i.Satuan);
                        gridView1.SetRowCellValue(row, gridView1.Columns[5], i.HargaBarang);

                        int jumlah = Convert.ToInt32(gridView1.GetRowCellValue(row, gridView1.Columns[3]));
                        int harga = Convert.ToInt32(gridView1.GetRowCellValue(row, gridView1.Columns[5]));

                        total = jumlah * harga;
                        gridView1.SetRowCellValue(row, gridView1.Columns[6], total);

                    }

                    GetTotalHarga();
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
                var query = (from i in mumtaaz.Pembelians
                             where i.NoTransaksi == txtTransaksi.Text
                             select i).FirstOrDefault();

                //get related pembelian (detail pembelian)
                var query1 = (from o in mumtaaz.DetailPembelians
                              where o.PembelianId == query.Id
                              select o).ToList();


                //update item
                for(int i = 0; i < gridView1.DataRowCount; i++)
                {
                    var rowHandle = gridView1.GetRowHandle(i);
                    var kodeItem = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[1]).ToString();

                    var stok = (from o in mumtaaz.DetailPembelians
                                join a in mumtaaz.Pembelians on o.PembelianId equals a.Id
                                where a.NoTransaksi == noTransaksi
                                select o.JumlahBarang).ToList();


                    var itemList = mumtaaz.Items.Where(x => x.KodeItem == kodeItem).FirstOrDefault();

                    itemList.Stok = itemList.Stok - stok[i];
                    mumtaaz.Entry(itemList).State = System.Data.Entity.EntityState.Modified;

                }

                //hapus related pembelian (detail pembelian)
                foreach (var i in query1)
                    mumtaaz.DetailPembelians.Remove(i);


                mumtaaz.Pembelians.Remove(query);
                mumtaaz.SaveChanges();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DeleteEditTransaksi();
        }
    }
}