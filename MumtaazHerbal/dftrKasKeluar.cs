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
    public partial class dftrKasKeluar : DevExpress.XtraEditors.XtraForm
    {
        private DbHelper dbhelper;

        public dftrKasKeluar()
        {
            InitializeComponent();
            dbhelper = new DbHelper();
        }

        private void dftrKasKeluar_Load(object sender, EventArgs e)
        {
            tglSebelum.EditValue = DateTime.Today;
            tglSesudah.EditValue = tglSebelum.DateTime.AddDays(1).AddTicks(-1);
            LoadData();
        }

        public void LoadData()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var query = from o in mumtaaz.KasKeluars
                            where o.NoTransaksi.Contains(txtSearch.Text) 
                            && o.Tanggal >= tglSebelum.DateTime && o.Tanggal <= tglSesudah.DateTime
                            select o;

                gridControl1.DataSource = query.ToList();
            }
        }

        private void tglSebelum_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tglSesudah_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(kas))
                {
                    form.Activate();
                    return;
                }
            }

            kas tmbhKas = new kas();
            tmbhKas.MdiParent = this;
            tmbhKas.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(kas))
                {
                    form.Activate();
                    return;
                }
            }
            bool edit = true;
            var noTransaksi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NoTransaksi").ToString();
            var Kas = new kas(this, gridView1, edit, noTransaksi);
            Kas.MdiParent = this.ParentForm;
            Kas.Show();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hapus transaksi ini?", "Mumtaaz Herbal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                //find id yang di edit
                var transaksi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NoTransaksi").ToString();

                var query = (from i in mumtaaz.KasKeluars
                             where i.NoTransaksi == transaksi
                             select i).FirstOrDefault();

                //get related kas (detail kaskeluar)
                var query1 = (from o in mumtaaz.DetailKasKeluars
                              where o.KaskeluarId == query.Id
                              select o).ToList();

                //hapus related pembelian (detail pembelian)
                foreach (var i in query1)
                    mumtaaz.DetailKasKeluars.Remove(i);


                mumtaaz.KasKeluars.Remove(query);
                mumtaaz.SaveChanges();
                LoadData();
            }
        }
    }

}