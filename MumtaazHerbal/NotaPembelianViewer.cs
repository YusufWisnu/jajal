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
    public partial class NotaPembelianViewer : DevExpress.XtraEditors.XtraForm
    {
        public NotaPembelianViewer()
        {
            InitializeComponent();
        }

        NotaPembelian nota;
        DbHelper dbhelper;
        MumtaazContext mumtaaz;

        public void PrintInvoicePiutang(lprPembelian beli, List<ListNotaPembelian> pmb)
        {
            nota = new NotaPembelian();
            dbhelper = new DbHelper();
            mumtaaz = new MumtaazContext(dbhelper.ConnectionString);

            foreach (DevExpress.XtraReports.Parameters.Parameter p in nota.Parameters)
                p.Visible = false;

            nota.InitData(beli.tglSebelum.DateTime, beli.tglSesudah.DateTime, pmb);
            documentViewer1.DocumentSource = nota;
            nota.CreateDocument();
        }


    }
}