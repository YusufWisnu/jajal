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

            var query = from o in mumtaaz.Suppliers
                        select o;

            gridControl1.DataSource = query.ToList();
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
            tmbhSupp supp = new tmbhSupp();
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
            var kodeSupplier = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[1]).ToString();

            tmbhSupp tmbh = new tmbhSupp(this, edit, supplierBindingSource, gridView1, kodeSupplier);
            tmbh.MdiParent = this.ParentForm;
            tmbh.Show();
        }

        //method untuk ambil data yang akan di edit
        public void GetData()
        {
            var rowHandle = gridView1.FocusedRowHandle;
            var kodeSupplier = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[1]).ToString();

            var query = mumtaaz.Suppliers
                .Where(x => x.KodeSupplier == kodeSupplier)
                .FirstOrDefault();

            query.NamaSupplier = gridView1.GetRowCellValue(rowHandle, "Nama").ToString();
            query.Alamat = gridView1.GetRowCellValue(rowHandle, "Alamat").ToString();
            query.Email = gridView1.GetRowCellValue(rowHandle, "Email").ToString();
            query.NoHP = gridView1.GetRowCellValue(rowHandle, "NoHp").ToString();
            query.KodeSupplier  = gridView1.GetRowCellValue(rowHandle, "KodePelanggan").ToString();

        }
    }
}