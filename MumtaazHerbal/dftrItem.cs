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

namespace MumtaazHerbal
{
    public partial class dftrItem : DevExpress.XtraEditors.XtraForm
    {
        private kasir kasir;
        private bool getItem;
        public dftrItem()
        {
            InitializeComponent();
            //DisplayDaftarItem();
        }

        public dftrItem(kasir kasir, bool getItem)
            :this()
        {
            this.kasir = kasir;
            this.getItem = getItem;
        }

        

        Query query;
        //MumtaazContext mumtaaz;
        Utilities util;
        MumtaazContext mumtaaz;


        private void dftrItem_Load(object sender, EventArgs e)
        {
            query = new Query();
            mumtaaz = new MumtaazContext();
            //mumtaaz = new MumtaazContext();

            query.DisplayDaftarItem(gridControl1);
            

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
            if (gridView1.SelectedRowsCount == 0)
                return;


            using (var mumtaaz = new MumtaazContext())
            {
                if (XtraMessageBox.Show("Hapus item ini ?.", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var rowHandle = gridView1.FocusedRowHandle;
                    var kodeItem = gridView1.GetRowCellValue(rowHandle, "KodeItem").ToString();
                    var query = mumtaaz.Items.FirstOrDefault(i => i.KodeItem == kodeItem);
                    mumtaaz.Items.Remove(query);
                    mumtaaz.SaveChanges();
                    XtraMessageBox.Show("Berhasil menghapus item.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            query.DisplayDaftarItem(gridControl1);

        }

        private void DisplayDaftarItem()
        {
            using (var mumtaaz = new MumtaazContext())
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
            if (getItem)
            {
                var rowHandle = gridView1.FocusedRowHandle;


                string kodeItem = gridView1.GetRowCellValue(rowHandle, "KodeItem").ToString();
                string namaItem = gridView1.GetRowCellValue(rowHandle, "NamaItem").ToString();
                string satuan = gridView1.GetRowCellValue(rowHandle, "Satuan").ToString();

                if (kasir.lookPelanggan.Text == "UMUM")
                {
                    harga = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "HargaEceran"));
                }
                else
                {
                    harga = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "HargaGrosir"));
                }

                kasir.CreateNewRow(kodeItem, namaItem, satuan, harga);
                getItem = false;
                this.Close();
            }
            
        }
    }
}