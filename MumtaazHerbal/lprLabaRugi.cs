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
    public partial class lprLabaRugi : DevExpress.XtraEditors.XtraForm
    {
        private DbHelper dbhelper;

        public lprLabaRugi()
        {
            InitializeComponent();
            dbhelper = new DbHelper();
        }

        private void lprLabaRugi_Load(object sender, EventArgs e)
        {
            tglSebelum.EditValue = DateTime.Today;
            tglSesudah.EditValue = tglSebelum.DateTime.AddDays(1).AddTicks(-1);
        }

        public void CetakPiutang()
        {
            using (var printLaba = new NotaLabaRugiViewer(this))
            {
                printLaba.PrintInvoicePiutang();
                printLaba.ShowDialog();
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            CetakPiutang();
        }
        
    }
}