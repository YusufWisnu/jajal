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
    public partial class kasir : DevExpress.XtraEditors.XtraForm
    {
        private GridView gridView;
        private bool edit;
        private dftrPenjualan daftarPenjualan;
        private string noTransaksi;

        public bool EditKasir { get; set; }


        public kasir()
        {
            InitializeComponent();
           // gridView1.IndicatorWidth = 30;
           
            // start timer
            var t = new Timer();
            t.Interval = 1000;  // in miliseconds
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();

        }

        public kasir(dftrPenjualan daftarPenjualan, GridView gridView, bool edit, string noTransaksi)
            : this()
        {
            this.gridView = gridView;
            this.edit = edit;
            this.daftarPenjualan = daftarPenjualan;
            this.noTransaksi = noTransaksi;
        }

        MumtaazContext mumtaaz;
        DbHelper dbhelper = new DbHelper();


        //pembayaran
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            EditKasir = true;

            if (gridView1.DataRowCount != 0)
            {
                GetKeranjangItem();
                pembayaran bayar = new pembayaran(this,daftarPenjualan, txtTotal.Text, gridView1, receipts, edit);
                bayar.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Mohon pilih item terlebih dahulu.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        //button daftar pending
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Maaf transaksi "+txtTransaksi.Text+" belom selesai. Apakah akan dibatalkan ?","Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RefreshPage();
                dftrPending pending = new dftrPending(this, gridControl1, gridView1);
                pending.ShowDialog();
            }
            
        }
        
        private void kasir_Load(object sender, EventArgs e)
        {
            mumtaaz = new MumtaazContext(dbhelper.ConnectionString);

            txtTanggal.EditValue = DateTime.Now;
            txtuser.Text = "ADMIN";
            pelangganBindingSource.DataSource = mumtaaz.Pelanggans.ToList();
            GetNoTransaksi();
            GetPelangganUmum();

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
            //get no transaksi
            var noTransaksi = mumtaaz.Penjualan
                .OrderByDescending(x => x.Id)
                .Select(x => x.Id)
                .FirstOrDefault();

            if (!mumtaaz.Penjualan.Any())
                noTransaksi++;

            noTransaksi++;

            txtTransaksi.Text = noTransaksi.ToString().PadLeft(4, '0') + "/KSR/" + DateTime.Now.ToString("ddMM");
        }

        public void GetPelangganUmum()
        {
            var query = mumtaaz.Pelanggans
                .Where(x => x.KodePelanggan == "UMUM")
                .Select(x => x.Id)
                .FirstOrDefault();

            lookPelanggan.EditValue = query;
        }

        

        public void CreateNewRow(string kodeItem, string namaItem,string satuan, int harga)
        {
            int total = 0;

            gridView1.AddNewRow();
            int rowHandle = gridView1.GetRowHandle(gridView1.DataRowCount);
            
            if (gridView1.IsNewItemRow(rowHandle))
            {

                gridView1.SetRowCellValue(rowHandle, gridView1.Columns[1], kodeItem);
                gridView1.SetRowCellValue(rowHandle, gridView1.Columns[2], namaItem);
                gridView1.SetRowCellValue(rowHandle, gridView1.Columns[3], Convert.ToInt32(txtJumlah.Text));
                gridView1.SetRowCellValue(rowHandle, gridView1.Columns[4], satuan);
                gridView1.SetRowCellValue(rowHandle, gridView1.Columns[5], harga);

                int jumlah = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]));
                if(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[5]) != DBNull.Value){
                     harga = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[5]));
                } 

                total = harga * jumlah;
                gridView1.SetRowCellValue(rowHandle, gridView1.Columns[6], total);

            }

            GetTotalHarga();
            gridView1.MoveLast();
        }

        private void btnDaftarItem_Click(object sender, EventArgs e)
        {
            bool getItem = true;
            dftrItem daftarItem = new dftrItem(this, getItem, gridView1);
            daftarItem.ShowDialog();
        }



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

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if(XtraMessageBox.Show("Hapus item ini?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                GetTotalHarga();
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
            if(e.Column.FieldName == "HargaBarang")
            {
                var kodeItem = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KodeItem").ToString();
                int hargaColumn = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HargaBarang"));
                int jumlah = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "JumlahBarang"));

                var query = mumtaaz.Items
                    .Where(x => x.KodeItem == kodeItem)
                    .SingleOrDefault();

                if (lookPelanggan.Text == "UMUM")
                {
                    if (query.HargaEceran > hargaColumn)
                    {
                        MessageBox.Show("Harga jual lebih kecil dari harga pokok \n Mohon cek kembali untuk menghindari kerugian", "Mumtaaz Herbal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "HargaBarang", query.HargaEceran);
                       // return;
                    }
                }
                else
                {
                    if (query.HargaGrosir > hargaColumn)
                    {
                        MessageBox.Show("Harga jual lebih kecil dari harga pokok \n Mohon cek kembali untuk menghindari kerugian", "Mumtaaz Herbal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "HargaBarang", query.HargaGrosir);
                        //return;
                    }
                }

                int total = 0;
                int harga = 0;

                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HargaBarang") != DBNull.Value)
                {
                    harga = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HargaBarang"));
                }

                total = harga * jumlah;
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6], total);

                GetTotalHarga();

            }

            if (e.Column.FieldName == "JumlahBarang")
            {
                //cek jika stok melebihi inputan

                var kodeItem = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KodeItem").ToString();
                int jumlah = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "JumlahBarang"));

                var query = mumtaaz.Items
                    .Where(x => x.KodeItem == kodeItem)
                    .SingleOrDefault();
                   
                //if(query.Stok < jumlah)
                //{
                //    MessageBox.Show("Jumlah item melebihi stok.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "JumlahBarang", query.Stok);
                //    return;
                //}

                int total = 0;
                int harga = 0;

                if(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HargaBarang") != DBNull.Value){
                     harga = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HargaBarang"));
                } 

                total = harga * jumlah;
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6], total);

                GetTotalHarga();
            }
        }

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

        //Push enter keyword to search items
        private void textEdit6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                bool getItem = true;
                dftrItem daftarItem = new dftrItem(this, getItem, txtKodeItem.Text, gridView1);
                daftarItem.ShowDialog();
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

        //Button Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Batalkan transaksi ini ?", "Batal Transaksi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                RefreshPage();
        }

        public void RefreshPage()
        {
            edit = false;
            kasir_Load(null, EventArgs.Empty);
            txtTotal.Text = "0";
        }

        // Button Pending
        private void btnPending_Click(object sender, EventArgs e)
        {
            if(gridView1.DataRowCount == 0)
            {
                MessageBox.Show("Keranjang belanja kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GetKeranjangItem();
            var pending = new tmbhPending(this, txtTotal.Text, gridView1, receipts);
            pending.ShowDialog();
            
        }


        //get informasi pending
        public void getInformasiPending(string noTransaksi, string tanggal )
        {
            txtTransaksi.Text = noTransaksi;


        }

        private void lookPelanggan_EditValueChanged(object sender, EventArgs e)
        {
            int total = 0;

            //untuk umum
            if (lookPelanggan.Text == "UMUM")
            {
                for(int i = 0; i < gridView1.DataRowCount; i++)
                {
                    var rowHandle = gridView1.GetRowHandle(i);
                    var kodeItem = gridView1.GetRowCellValue(rowHandle, "KodeItem").ToString();

                    var harga = mumtaaz.Items
                        .Where(x => x.KodeItem == kodeItem)
                        .Select(x => x.HargaEceran)
                        .FirstOrDefault();


                    gridView1.SetRowCellValue(rowHandle, gridView1.Columns[5], harga);

                    var jumlah = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, gridView1.Columns[3]));
                    //if (gridView1.GetRowCellValue(rowHandle, gridView1.Columns[5]) != DBNull.Value)
                    //{
                    //    harga = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[5]));
                    //}

                    total = harga * jumlah;
                    gridView1.SetRowCellValue(rowHandle, gridView1.Columns[6], total);
                }

                GetTotalHarga();
            }
            //jika pembeli adlaah pelanggan
            else
            {
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    var rowHandle = gridView1.GetRowHandle(i);
                    var kodeItem = gridView1.GetRowCellValue(rowHandle, "KodeItem").ToString();

                    var harga = mumtaaz.Items
                        .Where(x => x.KodeItem == kodeItem)
                        .Select(x => x.HargaGrosir)
                        .FirstOrDefault();


                    gridView1.SetRowCellValue(rowHandle, gridView1.Columns[5], harga);

                    var jumlah = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, gridView1.Columns[3]));
                    //if (gridView1.GetRowCellValue(rowHandle, gridView1.Columns[5]) != DBNull.Value)
                    //{
                    //    harga = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[5]));
                    //}

                    total = harga * jumlah;
                    gridView1.SetRowCellValue(rowHandle, gridView1.Columns[6], total);
                }

                GetTotalHarga();
            }
                
        }

        private void kasir_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gridView1.DataRowCount != 0)
            {
                if (MessageBox.Show("Transaksi "+txtTransaksi.Text+" belum selesai, batalkan transaksi ?.", "Mumtaaz Herbal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }

            }
        }
        //---------------------------------------------------------- EDIT PENJUALAN TRANSAKSI  ------------------------------
        //get data from item yang mau di edit
        public void GetData()
        {
            var rowHandle = gridView.FocusedRowHandle;
            var noTransaksi = gridView.GetRowCellValue(rowHandle, "NoTransaksi").ToString();

            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                //Get Informasi Penjualan
                var transaksi = mumtaaz.Penjualan
                    .Where(x => x.NoTransaksi == noTransaksi)
                    .FirstOrDefault();

                txtTanggal.EditValue = transaksi.Tanggal;
                txtTransaksi.Text = transaksi.NoTransaksi.ToString();
                lookPelanggan.EditValue = transaksi.PelangganId;
                txtTotal.Text = transaksi.TotalHarga.ToString();

                //get list item
                var listItem = from o in mumtaaz.DetailPenjualans
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

    }
}


