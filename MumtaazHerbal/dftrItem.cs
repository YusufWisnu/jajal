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
       
            //faisalllll
            //pust test
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
            var i = 0;

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
           
            //gridView1.With<Item>(item => {
            //    item.Columns
            //    .Add(c => c.NamaItem, col =>
            //      {
            //          col.Caption = "Nama Item";
            //          col.Width = 150;

            //      })
            //      .Add((c => c.KodeItem), c => 
            //      {
            //          c.Caption = "Kode Item";
            //      });
                
            //});
            //gridView1.With<Supplier>(supplier => {
            //    supplier.Columns
            //    .Add(c => c.NamaSupplier, col =>
            //    {
            //        col.Name = "Nama Supplier";
            //        col.Width = 300;
            //    });
            //});
            gridControl1.DataSource = query.ToList();

            
        }
    }
}