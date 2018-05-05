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

namespace MumtaazHerbal
{
    public partial class dftrItem : DevExpress.XtraEditors.XtraForm
    {
        public dftrItem()
        {
            InitializeComponent();
        }

        Supplier supp;
        Item item;

        MumtaazContext mumtaaz;
        private void dftrItem_Load(object sender, EventArgs e)
        {
            mumtaaz = new MumtaazContext();
           // itemBindingSource.DataSource = mumtaaz.Items.ToList();
            DisplayData();
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
            tmbhItem item = new tmbhItem();
            item.MdiParent = this.ParentForm;
            item.Show();
        }


        public void DisplayData()
        {
            supp = new Supplier();
            item = new Item();

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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}