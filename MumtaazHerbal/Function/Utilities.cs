using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MumtaazHerbal.Function
{
   public class Utilities
    {
        tmbhItem item = new tmbhItem();


        //KodeItem = txtKodeItem.Text,
        //        NamaItem = txtNamaItem.Text,
        //        SupplierId = Convert.ToInt32(lookSupplier.EditValue),
        //        Stok = Convert.ToInt32(Stok.Text),
        //        Satuan = txtSatuan.Text,
        //        HargaEceran = Convert.ToInt32(txtHargaRetail.Text),
        //        HargaGrosir = Convert.ToInt32(txtHargaGrosir.Text),
        //        HargaJual = Convert.ToInt32(txtHargaPokok)
        public void ClearText(string kodeItem, string namaItem, string supplier, string stok, string satuan, string hargaEceran, string hargaGrosir, string hargaJual)
        {
            kodeItem = string.Empty;
            supplier = string.Empty;
            stok = string.Empty;
            satuan = string.Empty;
            hargaEceran = string.Empty;
            hargaGrosir = string.Empty;
            hargaJual = string.Empty;
            namaItem = string.Empty;
        }

        public void ClearEditors()
        {
            foreach (Control ctrl in item.Controls)
            {
                if (ctrl is DevExpress.XtraEditors.BaseEdit)
                    (ctrl as DevExpress.XtraEditors.BaseEdit).EditValue = null;
            }
        }


    }
}
