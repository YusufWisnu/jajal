using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Extensions;
using DevExpress.XtraGrid;
using MumtaazHerbal.Function;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.Entity;

namespace MumtaazHerbal
{
    public partial class dftrItem : DevExpress.XtraEditors.XtraForm
    {
        private kasir kasir;
        private pembelian pembelian;
        private string kodeItem;
        private string kodeItemPembelian;
        private bool getItem;
        private bool getItemPembelian;
        private GridView gridView;
        private GridView gridViewPembelian;



        public dftrItem()
        {
            InitializeComponent();
            //DisplayDaftarItem();
        }

        public dftrItem(kasir kasir, bool getItem, GridView gridView)
            : this()
        {
            this.kasir = kasir;
            this.getItem = getItem;
            this.gridView = gridView;
        }

        public dftrItem(kasir kasir, bool getItem, string kodeItem, GridView gridView)
            :this(kasir, getItem, gridView)
        {
            
            this.kodeItem = kodeItem;
        }

        public dftrItem(pembelian pembelian, bool getItemPembelian, GridView gridViewPembelian)
            :this()
        {
            this.pembelian = pembelian;
            this.gridViewPembelian = gridViewPembelian;
            this.getItemPembelian = getItemPembelian;
        }

        public dftrItem(pembelian pembelian, bool getItemPembelian, string kodeItemPembelian, GridView gridViewPembelian)
            : this(pembelian, getItemPembelian, gridViewPembelian)
        {
            this.kodeItemPembelian = kodeItemPembelian;
        }




        Query query;
        Utilities util;
        MumtaazContext mumtaaz;
        DbHelper dbhelper = new DbHelper();

        private void dftrItem_Load(object sender, EventArgs e)
        {

            query = new Query();
            mumtaaz = new MumtaazContext(dbhelper.ConnectionString);
            //mumtaaz = new MumtaazContext(dbhelper.ConnectionString);

            query.DisplayDaftarItem(gridControl1);

            //get text from keypress enter search
            if (getItem)
                txtSearch.Text = kodeItem;
            else if (getItemPembelian)
                txtSearch.Text = kodeItemPembelian;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(tmbhItem))
                {

                    form.Activate();
                    return;
                }
            }
            tmbhItem item = new tmbhItem(gridControl1);
            item.MdiParent = this.ParentForm;
            item.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool edit = true;
            util = new Utilities();
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(tmbhItem))
                {
                    form.Activate();
                    return;
                }
            }
            // Ambil data dari gridview
            query.GetData(gridView1);

            tmbhItem item = new tmbhItem(query, edit);
            item.MdiParent = this.ParentForm;
            item.Show();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            //jika daftar tidak kosong
            if (gridView1.SelectedRowsCount == 0)
                return;


            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                if (XtraMessageBox.Show("Hapus item ini ?.", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var rowHandle = gridView1.FocusedRowHandle;
                        var kodeItem = gridView1.GetRowCellValue(rowHandle, "KodeItem").ToString();
                        var query = mumtaaz.Items.FirstOrDefault(i => i.KodeItem == kodeItem);
                        mumtaaz.Items.Remove(query);
                        mumtaaz.SaveChanges();
                        XtraMessageBox.Show("Berhasil menghapus item.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception ee)
                    {
                        MessageBox.Show("Item sudah masuk dalam daftar transaksi\ntidak bisa dihapus", ee.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
            }

            query.DisplayDaftarItem(gridControl1);

        }
    
        private void DisplayDaftarItem()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var supp = new Supplier();
                var item = new Item();

                var query = from o in mumtaaz.Items
                            join a in mumtaaz.Suppliers on o.SupplierId equals a.Id
                            select new
                            {
                                o.NamaItem,
                                o.KodeItem,
                                o.Stok,
                                o.Satuan,
                                o.HargaGrosir,
                                o.HargaEceran,
                                o.HargaJual,
                                a.NamaSupplier
                            };
                gridControl1.DataSource = query.ToList();
            }

        }

        public static int harga = 0;

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //get Item dari form kasir
            if (getItem)
            {
                var rowHandle = gridView1.FocusedRowHandle;


                var kodeItem = gridView1.GetRowCellValue(rowHandle, "KodeItem").ToString();

                //cek jika item melebihi stok
                var query = mumtaaz.Items
                    .Where(x => x.KodeItem == kodeItem)
                    .Select(x => x.Stok)
                    .FirstOrDefault()
                    .ToString();

                //cek jika item sudah ada dikeranjang belanjaan


                if (int.Parse(query) < int.Parse(kasir.txtJumlah.Text))
                {
                    MessageBox.Show("Jumlah item melebihi stok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                for (int i = 0; i < gridView.DataRowCount; i++)
                {
                    if (gridView.GetRowCellValue(i, "KodeItem").ToString() == gridView1.GetRowCellValue(rowHandle, "KodeItem").ToString())
                    {
                        MessageBox.Show("Item sudah ada di keranjang belanja.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }


                var namaItem = gridView1.GetRowCellValue(rowHandle, "NamaItem").ToString();
                var satuan = gridView1.GetRowCellValue(rowHandle, "Satuan").ToString();

                if (kasir.lookPelanggan.Text == "UMUM")
                {
                    harga = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "HargaEceran"));
                }
                else
                {
                    harga = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "HargaGrosir"));
                }

                kasir.CreateNewRowTxtSearch(kodeItem, namaItem, satuan, harga);
                getItem = false;
                this.Close();
            }

            //get item dari form pembelian
            else if (getItemPembelian)
            {
                var rowHandle = gridView1.FocusedRowHandle;


                var kodeItem = gridView1.GetRowCellValue(rowHandle, "KodeItem").ToString();

                //cek jika item kekurangan stok
                var query = mumtaaz.Items
                    .Where(x => x.KodeItem == kodeItem)
                    .Select(x => x.Stok)
                    .FirstOrDefault()
                    .ToString();

                //cek jika item sudah ada dikeranjang belanjaan


                //if (int.Parse(query) < int.Parse(pembelian.txtJumlah.Text))
                //{
                //    MessageBox.Show("Jumlah item melebihi stok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                for (int i = 0; i < gridViewPembelian.DataRowCount; i++)
                {
                    if (gridViewPembelian.GetRowCellValue(i, "KodeItem").ToString() == gridView1.GetRowCellValue(rowHandle, "KodeItem").ToString())
                    {
                        MessageBox.Show("Item sudah ada di keranjang belanja.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                var namaItem = gridView1.GetRowCellValue(rowHandle, "NamaItem").ToString();
                var satuan = gridView1.GetRowCellValue(rowHandle, "Satuan").ToString();
                var harga = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "HargaJual"));

                pembelian.CreateNewRow(kodeItem, namaItem, satuan, harga);
                getItemPembelian = false;
                this.Close();
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var dbhelper = new DbHelper();

            MessageBox.Show(dbhelper.ConnectionString);
        }

        public void GetItem()
        {
            //get Item dari form kasir
            if (getItem)
            {
                var rowHandle = gridView1.FocusedRowHandle;


                var kodeItem = gridView1.GetRowCellValue(rowHandle, "KodeItem").ToString();

                //cek jika item melebihi stok
                var query = mumtaaz.Items
                    .Where(x => x.KodeItem == kodeItem)
                    .Select(x => x.Stok)
                    .FirstOrDefault()
                    .ToString();

                //cek jika item sudah ada dikeranjang belanjaan


                if (int.Parse(query) < int.Parse(kasir.txtJumlah.Text))
                {
                    MessageBox.Show("Jumlah item melebihi stok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                for (int i = 0; i < gridView.DataRowCount; i++)
                {
                    if (gridView.GetRowCellValue(i, "KodeItem").ToString() == gridView1.GetRowCellValue(rowHandle, "KodeItem").ToString())
                    {
                        MessageBox.Show("Item sudah ada di keranjang belanja.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }


                var namaItem = gridView1.GetRowCellValue(rowHandle, "NamaItem").ToString();
                var satuan = gridView1.GetRowCellValue(rowHandle, "Satuan").ToString();

                if (kasir.lookPelanggan.Text == "UMUM")
                {
                    harga = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "HargaEceran"));
                }
                else
                {
                    harga = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "HargaGrosir"));
                }

                kasir.CreateNewRowTxtSearch(kodeItem, namaItem, satuan, harga);
                getItem = false;
                this.Close();
            }

            //get item dari form pembelian
            else if (getItemPembelian)
            {
                var rowHandle = gridView1.FocusedRowHandle;


                var kodeItem = gridView1.GetRowCellValue(rowHandle, "KodeItem").ToString();

                //cek jika item kekurangan stok
                var query = mumtaaz.Items
                    .Where(x => x.KodeItem == kodeItem)
                    .Select(x => x.Stok)
                    .FirstOrDefault()
                    .ToString();

                //cek jika item sudah ada dikeranjang belanjaan


                //if (int.Parse(query) < int.Parse(pembelian.txtJumlah.Text))
                //{
                //    MessageBox.Show("Jumlah item melebihi stok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                for (int i = 0; i < gridViewPembelian.DataRowCount; i++)
                {
                    if (gridViewPembelian.GetRowCellValue(i, "KodeItem").ToString() == gridView1.GetRowCellValue(rowHandle, "KodeItem").ToString())
                    {
                        MessageBox.Show("Item sudah ada di keranjang belanja.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                var namaItem = gridView1.GetRowCellValue(rowHandle, "NamaItem").ToString();
                var satuan = gridView1.GetRowCellValue(rowHandle, "Satuan").ToString();
                var harga = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "HargaJual"));

                pembelian.CreateNewRow(kodeItem, namaItem, satuan, harga);
                getItemPembelian = false;
                this.Close();
            }



        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var query = from o in mumtaaz.Items
                        join a in mumtaaz.Suppliers on o.SupplierId equals a.Id
                        where o.NamaItem.Contains(txtSearch.Text)
                        select new
                        {
                            o.NamaItem,
                            o.KodeItem,
                            o.Stok,
                            o.Satuan,
                            o.HargaGrosir,
                            o.HargaEceran,
                            o.HargaJual,
                            a.NamaSupplier
                        };
            gridControl1.DataSource = query.ToList();
        }

        private void gridControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) GetItem();
        }
    }
}