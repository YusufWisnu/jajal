using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;

namespace MumtaazHerbal
{
    public partial class dftrPmb : DevExpress.XtraEditors.XtraForm
    {
        public dftrPmb()
        {
            InitializeComponent();
        }

        private void dftrPmb_Load(object sender, EventArgs e)
        {
            //set tgl hari ini dan waktu terakhir 
            tglSebelum.EditValue = DateTime.Today;
            tglSesudah.EditValue = tglSebelum.DateTime.AddDays(1).AddTicks(-1);
            LoadData();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {


        }

        public void LoadData()
        {
            using (var mumtaaz = new MumtaazContext())
            {
                var query = from o in mumtaaz.Pembelians
                            join a in mumtaaz.Suppliers on o.SupplierId equals a.Id
                            where o.Tanggal >= tglSebelum.DateTime && o.Tanggal <= tglSesudah.DateTime
                            select new
                            {
                                o.NoTransaksi,
                                o.Tanggal,
                                a.KodeSupplier,
                                a.NamaSupplier,
                                o.TotalHarga
                            };

                gridControl1.DataSource = query.ToList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(pembelian))
                {
                    form.Activate();
                    return;
                }
            }
            bool edit = true;
            var noTransaksi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NoTransaksi").ToString();
            var pmb = new pembelian(this, gridView1, edit, noTransaksi);
            pmb.MdiParent = this.ParentForm;
            pmb.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ChangeDate();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tglSebelum_EditValueChanged(object sender, EventArgs e)
        {
            ChangeDate();
        }

        private void tglSesudah_EditValueChanged(object sender, EventArgs e)
        {
            ChangeDate();
        }

        // list berdasarkan event changed date
        public void ChangeDate()
        {
            using (var mumtaaz = new MumtaazContext())
            {
                var query = from o in mumtaaz.Pembelians
                            join a in mumtaaz.Suppliers on o.SupplierId equals a.Id
                            where o.NoTransaksi.Contains(txtSearch.Text) && (o.Tanggal >= tglSebelum.DateTime && o.Tanggal <= tglSesudah.DateTime)
                            select new
                            {
                                o.NoTransaksi,
                                o.Tanggal,
                                a.KodeSupplier,
                                a.NamaSupplier,
                                o.TotalHarga
                            };

                gridControl1.DataSource = query.ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(pembelian))
                {
                    form.Activate();
                    return;
                }
            }
            var pmb = new pembelian();
            pmb.MdiParent = this.ParentForm;
            pmb.Show();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            HapusItem();
            LoadData();
        }

        public void HapusItem()
        {
            if(MessageBox.Show("Hapus Laporan ini?", "Mumtaaz Herbal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var mumtaaz = new MumtaazContext())
                {
                    var noTransaksi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NoTransaksi").ToString();
                    //find id yang di edit
                    var query = (from i in mumtaaz.Pembelians
                                 where i.NoTransaksi == noTransaksi
                                 select i).FirstOrDefault();

                    //get related pembelian (detail pembelian)
                    var query1 = (from o in mumtaaz.DetailPembelians
                                  where o.PembelianId == query.Id
                                  select o).ToList();

                    //hapus related pembelian (detail pembelian)
                    foreach (var i in query1)
                        mumtaaz.DetailPembelians.Remove(i);


                    mumtaaz.Pembelians.Remove(query);
                    mumtaaz.SaveChanges();

                }
            }
            
        }
    }
}