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
    public partial class dftrSupp : DevExpress.XtraEditors.XtraForm
    {
        public dftrSupp()
        {
            InitializeComponent();
        }
        MumtaazContext mumtaaz;
        DbHelper dbhelper = new DbHelper();

        private void dftrSupp_Load(object sender, EventArgs e)
        {
            mumtaaz = new MumtaazContext(dbhelper.ConnectionString);

            LoadData();
        }

        public void LoadData()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var query = mumtaaz.Suppliers;
                gridControl1.DataSource = query.ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(tmbhSupp))
                {
                    form.Activate();
                    return;
                }
            }
            tmbhSupp supp = new tmbhSupp(gridControl1);
            supp.MdiParent = this.ParentForm;
            supp.Show();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(tmbhSupp))
                {

                    form.Activate();
                    return;
                }
            }
            bool edit = true;
            var rowHandle = gridView1.FocusedRowHandle;
            var kodeSupplier = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[0]).ToString();

            var tmbh = new tmbhSupp(this, edit, gridControl1, gridView1, kodeSupplier);
            tmbh.MdiParent = this.ParentForm;
            tmbh.Show();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
                {
                    if(MessageBox.Show("Hapus data ini ?.", "Mumtaaz Herbal", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        var kodeSupplier = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
                        var query = from o in mumtaaz.Suppliers
                                    where o.KodeSupplier == kodeSupplier
                                    select o;

                        mumtaaz.Suppliers.Remove(query.FirstOrDefault());
                        mumtaaz.SaveChanges();
                        MessageBox.Show("Berhasil menghapus data ini", "Mumtaaz Herbal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show("Gagal menghapus data", "Mumtaaz Herbal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //method untuk ambil data yang akan di edit
        //public void GetData()
        //{
        //    var rowHandle = gridView1.FocusedRowHandle;
        //    var kodeSupplier = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[1]).ToString();

        //    var query = mumtaaz.Suppliers
        //        .Where(x => x.KodeSupplier == kodeSupplier)
        //        .FirstOrDefault();

        //    query.NamaSupplier = gridView1.GetRowCellValue(rowHandle, "Nama").ToString();
        //    query.Alamat = gridView1.GetRowCellValue(rowHandle, "Alamat").ToString();
        //    query.Email = gridView1.GetRowCellValue(rowHandle, "Email").ToString();
        //    query.NoHP = gridView1.GetRowCellValue(rowHandle, "NoHp").ToString();
        //    query.KodeSupplier  = gridView1.GetRowCellValue(rowHandle, "KodePelanggan").ToString();

        //}
    }
}