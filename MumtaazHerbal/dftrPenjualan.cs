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

namespace MumtaazHerbal
{
    public partial class dftrPenjualan : DevExpress.XtraEditors.XtraForm
    {
        public dftrPenjualan()
        {
            InitializeComponent();
        }

        private void dftrPenjualan_Load(object sender, EventArgs e)
        {
            tglSebelum.EditValue = DateTime.Today;
            tglSesudah.EditValue = tglSebelum.DateTime.AddDays(1).AddTicks(-1);
            LoadData();
        }

        DbHelper dbhelper = new DbHelper();


        public void LoadData()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var query = from i in mumtaaz.Penjualan
                            join a in mumtaaz.Pelanggans on i.PelangganId equals a.Id
                            where i.Tanggal >= tglSebelum.DateTime && i.Tanggal <= tglSesudah.DateTime

                            select new
                            {
                                i.NoTransaksi,
                                i.Tanggal,
                                a.KodePelanggan,
                                a.Nama,
                                i.TotalHarga
                            };

                gridControl1.DataSource = query.ToList();
            }
        }

        private void tglSebelum_EditValueChanged(object sender, EventArgs e)
        {
            ChangeDate();
        }

        private void tglSesudah_EditValueChanged(object sender, EventArgs e)
        {
            ChangeDate();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ChangeDate();
        }

        public void ChangeDate()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var query = from i in mumtaaz.Penjualan
                            join a in mumtaaz.Pelanggans on i.PelangganId equals a.Id
                            where i.NoTransaksi.Contains(txtSearch.Text) && (i.Tanggal >= tglSebelum.DateTime && i.Tanggal <= tglSesudah.DateTime)
                            select new
                            {
                                i.NoTransaksi,
                                i.Tanggal,
                                a.KodePelanggan,
                                a.Nama,
                                i.TotalHarga
                            };

                gridControl1.DataSource = query.ToList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(kasir))
                {
                    form.Activate();
                    return;
                }
            }
            bool edit = true;
            var noTransaksi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NoTransaksi").ToString();
            var pmb = new kasir(this, gridView1, edit, noTransaksi);
            pmb.MdiParent = this.ParentForm;
            pmb.Show();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hapus Laporan ini?", "Mumtaaz Herbal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
                {
                    var noTransaksi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NoTransaksi").ToString();
                    //find id yang di edit
                    var query = (from i in mumtaaz.Penjualan
                                 where i.NoTransaksi == noTransaksi
                                 select i).FirstOrDefault();

                    //get related penjualan (detail penjualan)
                    var query1 = (from o in mumtaaz.DetailPenjualans
                                  where o.PenjualanId == query.Id
                                  select o).ToList();
                    
                    //update stock
                    var stok = (from o in mumtaaz.DetailPenjualans
                                join a in mumtaaz.Items on o.ItemId equals a.Id
                                join b in mumtaaz.Penjualan on o.PenjualanId equals b.Id
                                where b.NoTransaksi == noTransaksi
                                select new
                                {
                                    ItemId = a.Id,
                                    jumlahBarang = o.JumlahBarang

                                }).ToList();

                    foreach (var i in stok)
                    {
                        var itemList = mumtaaz.Items.Where(x => x.Id == i.ItemId).FirstOrDefault();

                        itemList.Stok += i.jumlahBarang;
                        mumtaaz.Entry(itemList).State = System.Data.Entity.EntityState.Modified;
                    }
                    
                    foreach (var i in query1)
                        mumtaaz.DetailPenjualans.Remove(i);

                    mumtaaz.Penjualan.Remove(query);
                    mumtaaz.SaveChanges();
                    MessageBox.Show("Berhasil menghapus data ini", "Mumtaaz Herbal", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            ChangeDate();
        }



    }
}