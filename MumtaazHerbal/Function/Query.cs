using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MumtaazHerbal.Function
{
    public class Query
    {
        public string NamaItem;
        public string KodeItem;
        public string Stok;
        public string Satuan;
        public string HargaGrosir;
        public string HargaEceran;
        public string HargaJual;
        public string NamaSupplier;


        Supplier supp;
        Item item;
        MumtaazContext mumtaaz;

        public void GetData(GridView grid)
        {
            var rowHandle = grid.FocusedRowHandle;

            NamaItem = grid.GetRowCellValue(rowHandle, "NamaItem").ToString();
            KodeItem = grid.GetRowCellValue(rowHandle, "KodeItem").ToString();
            Stok = grid.GetRowCellValue(rowHandle, "Stok").ToString();
            Satuan = grid.GetRowCellValue(rowHandle, "Satuan").ToString();
            HargaGrosir = grid.GetRowCellValue(rowHandle, "HargaGrosir").ToString();
            HargaEceran = grid.GetRowCellValue(rowHandle, "HargaEceran").ToString();
            HargaJual = grid.GetRowCellValue(rowHandle, "HargaJual").ToString();
            NamaSupplier = grid.GetRowCellValue(rowHandle, "NamaSupplier").ToString();
        }


        public void DisplayDaftarItem(DevExpress.XtraGrid.GridControl grid)
        {
            mumtaaz = new MumtaazContext();
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
            grid.DataSource = query.ToList();
        }

        public bool CheckIfAdd(string kodeItem)
        {
            using (var mumtaaz = new MumtaazContext())
            {
                if(mumtaaz.Items.Any(o => o.KodeItem == kodeItem))
                {
                    XtraMessageBox.Show("Kode Item sudah digunakan.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            return false;
        }

        //public bool CheckIfEdit(string kodeItem)
        //{
        //    using (var mumtaaz = new MumtaazContext())
        //    {
        //        if (mumtaaz.Items.Any(o => o.KodeItem == kodeItem))
        //        {
        //            if()
        //            return true;
                    
        //        }
        //    }
        //}

    }

    
}
