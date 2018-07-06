using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MumtaazHerbal
{
    public partial class pembelian : DevExpress.XtraEditors.XtraForm
    {
        public pembelian()
        {
            InitializeComponent();
        }

        MumtaazContext mumtaaz;


        private void pembelian_Load(object sender, EventArgs e)
        {
            mumtaaz = new MumtaazContext();

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
        }

        public void GetNoTransaksi()
        {
            //get no transaksi
            var noTransaksi = mumtaaz.Pembelians
                .OrderByDescending(x => x.Id)
                .Select(x => x.Id)
                .FirstOrDefault();

            if (!mumtaaz.Pembelians.Any())
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
                gridView1.SetRowCellValue(rowHandle, gridView1.Columns[3], Convert.ToInt32(txtJumlah.Text));
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
        //    if (e.Column.FieldName == "HargaBarang")
        //    {
        //        var kodeItem = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KodeItem").ToString();
        //        int hargaColumn = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HargaBarang"));
        //        int jumlah = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "JumlahBarang"));

        //        var query = mumtaaz.Items
        //            .Where(x => x.KodeItem == kodeItem)
        //            .SingleOrDefault();

        //        if (lookPelanggan.Text == "UMUM")
        //        {
        //            if (query.HargaEceran > hargaColumn)
        //            {
        //                MessageBox.Show("Jumlah item melebihi stok.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "HargaBarang", query.HargaEceran);
        //                return;
        //            }
        //        }
        //        else
        //        {
        //            if (query.HargaGrosir > hargaColumn)
        //            {
        //                MessageBox.Show("Jumlah item melebihi stok.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "HargaBarang", query.HargaGrosir);
        //                return;
        //            }
        //        }

        //        int total = 0;
        //        int harga = 0;

        //        if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HargaBarang") != DBNull.Value)
        //        {
        //            harga = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HargaBarang"));
        //        }

        //        total = harga * jumlah;
        //        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6], total);

        //        GetTotalHarga();

        //    }

        //    if (e.Column.FieldName == "JumlahBarang")
        //    {
        //        //cek jika stok melebihi inputan

        //        var kodeItem = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KodeItem").ToString();
        //        int jumlah = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "JumlahBarang"));

        //        var query = mumtaaz.Items
        //            .Where(x => x.KodeItem == kodeItem)
        //            .SingleOrDefault();

        //        if (query.Stok < jumlah)
        //        {
        //            MessageBox.Show("Jumlah item melebihi stok.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "JumlahBarang", query.Stok);
        //            return;
        //        }

        //        int total = 0;
        //        int harga = 0;

        //        if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HargaBarang") != DBNull.Value)
        //        {
        //            harga = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HargaBarang"));
        //        }

        //        total = harga * jumlah;
        //        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6], total);

        //        GetTotalHarga();
        //    }
        }
    }
}