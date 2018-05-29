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

        MumtaazContext mumtaaz;

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount != 0)
            {
                pembayaran bayar = new pembayaran(this,txtTotal.Text, gridView1);
                bayar.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Mohon pilih item terlebih dahulu.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            dftrPending pending = new dftrPending();
            pending.ShowDialog();
        }
        
        private void kasir_Load(object sender, EventArgs e)
        {
            mumtaaz = new MumtaazContext();

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
            dt.Columns.Add("Jumlah", typeof(int));
            dt.Columns.Add("Satuan", typeof(string));
            dt.Columns.Add("Harga", typeof(int));
            dt.Columns.Add("Total", typeof(int));

            gridControl1.DataSource = dt;
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

            txtTransaksi.Text = noTransaksi.ToString().PadLeft(4, '0') + "/KSR/" + DateTime.Now.ToString("ddMM");
        }

        

        public void GetPelangganUmum()
        {
            //var query = from o in mumtaaz.Pelanggans
            //            where o.KodePelanggan == "UMUM"

            lookPelanggan.Text = mumtaaz.Pelanggans
                .Where(x => x.KodePelanggan == "UMUM")
                .Select(x => x.KodePelanggan)
                .FirstOrDefault()
                .ToString();
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

                int jumlah = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Jumlah"));
                if(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Harga") != DBNull.Value){
                     harga = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Harga"));
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
            dftrItem daftarItem = new dftrItem(this, getItem);
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

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.Caption == "No")
            {
                e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Jumlah")
            {
                int total = 0;
                int harga = 0;

                int jumlah = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Jumlah"));
                if(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Harga") != DBNull.Value){
                     harga = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Harga"));
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

        private void textEdit6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                bool getItem = true;
                dftrItem daftarItem = new dftrItem(this, getItem, txtKodeItem.Text);
                daftarItem.ShowDialog();
            }
        }

        List<Receipt> receipts;
        public void GetKeranjangItem()
        {
            receipts = new List<Receipt>();

            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                int rowHandle = gridView1.GetRowHandle(i);
                var receipt = new Receipt()
                {
                    NamaItem = gridView1.GetRowCellValue(rowHandle, "NamaItem").ToString(),
                    Harga = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "Harga")),
                    JumlahItem = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "Jumlah")),
                    Total = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "Total"))
                };

                receipts.Add(receipt);
            }
        }
    }
}


