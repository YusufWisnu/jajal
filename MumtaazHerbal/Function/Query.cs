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

        //data pelanggan
        public int IdPelanggan;
        public string NamaPel;
        public string KodePel;
        public string AlamatPel;
        public string EmailPel;
        public string TeleponPel;
    

        Supplier supp;
        Item item;
        MumtaazContext mumtaaz;
        DbHelper dbhelper = new DbHelper();

        // ------------------------------------   dftrItem   -----------------------------------------------\\

        //ambil data dari gridView
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
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                Id = Convert.ToInt32(mumtaaz.Items.Where(c => c.KodeItem == KodeItem).SingleOrDefault()?.Id);

            }       


        }

        // Load Data dftrItem
        public void DisplayDaftarItem(DevExpress.XtraGrid.GridControl grid)
        {
            mumtaaz = new MumtaazContext(dbhelper.ConnectionString);
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
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
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

        public bool CheckKodePelanggan(string kodePelanggan)
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                if (mumtaaz.Pelanggans.Any(o => o.KodePelanggan == kodePelanggan))
                {
                    XtraMessageBox.Show("Kode Pelanggan sudah digunakan.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            return false;
        }


    }


}
