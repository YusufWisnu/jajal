using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
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

        public void ClearEditors(tmbhItem item)
        {
            foreach (Control ctrl in item.Controls)
            {
                if (ctrl is BaseEdit)
                    (ctrl as BaseEdit).EditValue = null;
            }
        }

        public void GetData(GridView grid, string namaItem)
        {
            var rowhandle = grid.FocusedRowHandle;
            namaItem = grid.GetRowCellValue(rowhandle, "NamaItem").ToString();
        }

        public bool CheckIfNull(tmbhItem item)
        {

            foreach(Control c in item.Controls)
            {
                if(c is TextEdit || c is LookUpEdit || c is ComboBoxEdit)
                {
                    if (string.IsNullOrEmpty(c.Text))
                    {
                        XtraMessageBox.Show("Mohon isi semua field yang ada", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
                }
            }
            return false;
        }


    }
}
