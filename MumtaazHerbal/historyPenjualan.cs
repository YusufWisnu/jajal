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
    public partial class historyPenjualan : DevExpress.XtraEditors.XtraForm
    {
        public historyPenjualan()
        {
            InitializeComponent();
        }
        MumtaazContext mumtaaz;
        DbHelper dbhelper = new DbHelper();


        private void historyPenjualan_Load(object sender, EventArgs e)
        {
            mumtaaz = new MumtaazContext(dbhelper.ConnectionString);

            pelangganBindingSource.DataSource = mumtaaz.Pelanggans.ToList();

            tglSebelum.EditValue = DateTime.Today;
            tglSesudah.EditValue = tglSebelum.DateTime.AddDays(1).AddTicks(-1);
            LoadData();
        }

        public void LoadData()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var query = from o in mumtaaz.DetailPenjualans
                            join a in mumtaaz.Items on o.ItemId equals a.Id
                            join i in mumtaaz.Penjualan on o.PenjualanId equals i.Id
                            join b in mumtaaz.Pelanggans on i.PelangganId equals b.Id
                            where i.Tanggal >= tglSebelum.DateTime && i.Tanggal <= tglSesudah.DateTime
                            select new
                            {
                                b.KodePelanggan,
                                b.Nama,
                                i.NoTransaksi,
                                i.Tanggal,
                                a.KodeItem,
                                a.NamaItem,
                                a.Satuan,
                                o.HargaBarang
                            };

                gridControl1.DataSource = query.ToList();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ChangeDate();
        }

        private void tglSebelum_EditValueChanged(object sender, EventArgs e)
        {
            ChangeDate();

        }

        private void tglSesudah_EditValueChanged(object sender, EventArgs e)
        {
            ChangeDate();

        }

        private void lookPelanggan_EditValueChanged(object sender, EventArgs e)
        {
            ChangeDate();

        }

        private void lookPelanggan_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Back || e.KeyData == Keys.Delete))
            {
                ((LookUpEdit)sender).EditValue = null;
                e.Handled = true;
            }
        }

        public void ChangeDate()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var query = from o in mumtaaz.DetailPenjualans
                            join a in mumtaaz.Items on o.ItemId equals a.Id
                            join i in mumtaaz.Penjualan on o.PenjualanId equals i.Id
                            join b in mumtaaz.Pelanggans on i.PelangganId equals b.Id
                            where i.NoTransaksi.Contains(txtSearch.Text)
                            && (i.Tanggal >= tglSebelum.DateTime && i.Tanggal <= tglSesudah.DateTime)
                            && b.Nama.Contains(lookPelanggan.Text)
                            select new
                            {
                                b.KodePelanggan,
                                b.Nama,
                                i.NoTransaksi,
                                i.Tanggal,
                                a.KodeItem,
                                a.NamaItem,
                                a.Satuan,
                                o.HargaBarang
                            };

                gridControl1.DataSource = query.ToList();
            }
        }
    }
}