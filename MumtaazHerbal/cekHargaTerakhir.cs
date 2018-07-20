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
    public partial class cekHargaTerakhir : DevExpress.XtraEditors.XtraForm
    {
        private DbHelper dbhelper;
        private kasir ksr;
        private string kodeItem;
        private string namaItem;

        public cekHargaTerakhir()
        {
            InitializeComponent();
            dbhelper = new DbHelper();
        }

        public cekHargaTerakhir(kasir ksr, string kodeItem, string namaItem)
            : this()
        {
            this.ksr = ksr;
            this.namaItem = namaItem;
            this.kodeItem = kodeItem;
        }

        private void cekHargaTerakhir_Load(object sender, EventArgs e)
        {
            lblKodePelanggan.Text = kodePelanggan();
            lblNamaPelanggan.Text = ksr.lookPelanggan.Text;
            lblNamaItem.Text = namaItem;

            LoadData();

        }

        public void LoadData()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var itemId = mumtaaz.Items.Where(i => i.KodeItem == kodeItem).Select(i => i.Id).FirstOrDefault();
                var idPelanggan = Convert.ToInt32(ksr.lookPelanggan.EditValue);

                var query = from o in mumtaaz.DetailPenjualans
                            join a in mumtaaz.Penjualan on o.PenjualanId equals a.Id
                            join b in mumtaaz.Pelanggans on a.PelangganId equals b.Id
                            //join c in mumtaaz.Items on o.ItemId equals c.Id
                            where o.ItemId == itemId && b.Id == idPelanggan
                            orderby a.Tanggal descending
                            select new
                            {
                                a.Tanggal,
                                o.HargaBarang
                            };

                gridControl1.DataSource = query.ToList();
            }
        }

        public string kodePelanggan()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var idPelanggan = Convert.ToInt32(ksr.lookPelanggan.EditValue);

                var query = mumtaaz.Pelanggans.Where(x => x.Id == idPelanggan).Select(x => x.KodePelanggan).FirstOrDefault();

                return query;
            }
        }

        private void cekHargaTerakhir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}