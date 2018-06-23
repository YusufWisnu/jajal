using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;

namespace MumtaazHerbal.Function
{
    public class Query
    {
        //var buat dftr Item
        public int Id;
        public string NamaItem;
        public string KodeItem;
        public string Stok;
        public string Satuan;
        public string HargaGrosir;
        public string HargaEceran;
        public string HargaJual;
        public string NamaSupplier;
        //public string TempId;

        //var buat dftrSupp
        public int idsupp;
        public string KodeSupplier;
        public string NamaSupplierMain;
        public string NoHpSupp;
        public string AlamatSupp;
        public string EmailSupp;

        Supplier supp;
        Item item;
        MumtaazContext mumtaaz;

        // ------------------------------------   dftrItem   -----------------------------------------------\\

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
            using (var mumtaaz = new MumtaazContext())
            {
                Id = Convert.ToInt32(mumtaaz.Items.Where(c => c.KodeItem == KodeItem).SingleOrDefault()?.Id);

            }       


        }

        // Load Data dftrItem
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

        // ------------------------------------   dftrPelanggan   -----------------------------------------------\\



        // ------------------------------------   dftrSupplier   -----------------------------------------------\\
        public void GetSupp(GridView grid)
        {
            var rowHandle = grid.FocusedRowHandle;
            
            KodeSupplier = grid.GetRowCellValue(rowHandle, "KodeSupplier").ToString();
            NamaSupplierMain = grid.GetRowCellValue(rowHandle, "NamaSupplier").ToString();
            NoHpSupp = grid.GetRowCellValue(rowHandle, "NoHP").ToString();
            AlamatSupp = grid.GetRowCellValue(rowHandle, "AlamatSupp").ToString();
            EmailSupp = grid.GetRowCellValue(rowHandle, "Email").ToString();
            
        }
    }


}
