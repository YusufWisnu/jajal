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
    public partial class historyPmb : DevExpress.XtraEditors.XtraForm
    {
        public historyPmb()
        {
            InitializeComponent();
        }

        MumtaazContext mumtaaz;
        DbHelper dbhelper = new DbHelper();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dftrSupp supp = new dftrSupp();
            supp.ShowDialog();
        }

        private void historyPmb_Load(object sender, EventArgs e)
        {
            mumtaaz = new MumtaazContext(dbhelper.ConnectionString);

            supplierBindingSource.DataSource = mumtaaz.Suppliers.ToList();

            tglSebelum.EditValue = DateTime.Today;
            tglSesudah.EditValue = tglSebelum.DateTime.AddDays(1).AddTicks(-1);
            LoadData();
        }

        public void LoadData()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var query = from o in mumtaaz.DetailPembelians
                            join a in mumtaaz.Items on o.ItemId equals a.Id
                            join i in mumtaaz.Pembelians on o.PembelianId equals i.Id
                            join b in mumtaaz.Suppliers on i.SupplierId equals b.Id
                            where i.Tanggal >= tglSebelum.DateTime && i.Tanggal <= tglSesudah.DateTime
                            select new
                            {
                                b.KodeSupplier,
                                b.NamaSupplier,
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

        private void tglSebelum_EditValueChanged(object sender, EventArgs e)
        {
            ChangeDate();
        }

        private void tglSesudah_EditValueChanged(object sender, EventArgs e)
        {
            ChangeDate();
        }

        private void lookSupplier_EditValueChanged(object sender, EventArgs e)
        {
            ChangeDate();
        }

        public void ChangeDate()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var query = from o in mumtaaz.DetailPembelians
                            join a in mumtaaz.Items on o.ItemId equals a.Id
                            join i in mumtaaz.Pembelians on o.PembelianId equals i.Id
                            join b in mumtaaz.Suppliers on i.SupplierId equals b.Id
                            where i.NoTransaksi.Contains(txtSearch.Text) 
                            && ( i.Tanggal >= tglSebelum.DateTime && i.Tanggal <= tglSesudah.DateTime)
                            && b.NamaSupplier.Contains(lookSupplier.Text)
                            select new
                            {
                                b.KodeSupplier,
                                b.NamaSupplier,
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

        //mengapus text di looksupplier
        private void lookSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Back || e.KeyData == Keys.Delete))
            {
                ((LookUpEdit)sender).EditValue = null;
                e.Handled = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ChangeDate();
        }
    }
}