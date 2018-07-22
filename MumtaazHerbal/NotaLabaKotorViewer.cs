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
    public partial class NotaLabaKotorViewer : DevExpress.XtraEditors.XtraForm
    {
        public NotaLabaKotorViewer()
        {
            InitializeComponent();
        }


        NotaLabaJual nota;
        DbHelper dbhelper;
        MumtaazContext mumtaaz;


        public void PrintInvoicePiutang(lprLabaJual labaJual, List<NotaLabaKotor> listLabaKotor)
        {
            nota = new NotaLabaJual();
            dbhelper = new DbHelper();
            mumtaaz = new MumtaazContext(dbhelper.ConnectionString);

            foreach (DevExpress.XtraReports.Parameters.Parameter p in nota.Parameters)
                p.Visible = false;

            nota.InitData(labaJual.tglSebelum.DateTime, labaJual.tglSesudah.DateTime, listLabaKotor);
            documentViewer1.DocumentSource = nota;
            nota.CreateDocument();
        }

        
    }
}