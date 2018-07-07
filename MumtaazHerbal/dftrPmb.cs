using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

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



    }
}