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
    public partial class NotaPenjualanViewer : DevExpress.XtraEditors.XtraForm
    {
        public NotaPenjualanViewer()
        {
            InitializeComponent();
        }

        private void NotaPenjualanViewer_Load(object sender, EventArgs e)
        {

        }

        NotaPenjualan nota;
        DbHelper dbhelper;
        MumtaazContext mumtaaz;

        public void PrintInvoicePiutang(lprPenjualan beli, List<ListNotaPenjualan> pnj)
        {
            nota = new NotaPenjualan();
            dbhelper = new DbHelper();
            mumtaaz = new MumtaazContext(dbhelper.ConnectionString);

            foreach (DevExpress.XtraReports.Parameters.Parameter p in nota.Parameters)
                p.Visible = false;

            nota.InitData(beli.tglSebelum.DateTime, beli.tglSesudah.DateTime, pnj);
            documentViewer1.DocumentSource = nota;
            nota.CreateDocument();
        }


    }
}