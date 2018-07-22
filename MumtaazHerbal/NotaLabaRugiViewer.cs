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
    public partial class NotaLabaRugiViewer : DevExpress.XtraEditors.XtraForm
    {
        private lprLabaRugi labaRugi;
        private DbHelper dbhelper;

        public NotaLabaRugiViewer()
        {
            InitializeComponent();
            dbhelper = new DbHelper();
        }
        public NotaLabaRugiViewer(lprLabaRugi labaRugi)
            :this()
        {
            this.labaRugi = labaRugi;
        }

        NotaLabaRugi nota;

        public void PrintInvoicePiutang()
        {
            nota = new NotaLabaRugi();

            foreach (DevExpress.XtraReports.Parameters.Parameter p in nota.Parameters)
                p.Visible = false;

            nota.InitData(labaRugi.tglSebelum.DateTime, labaRugi.tglSesudah.DateTime, PendapatanDagang(), HPP(), BiayaLainya());
            documentViewer1.DocumentSource = nota;
            nota.CreateDocument();
        }

        public int PendapatanDagang()
        {

            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var query = (from o in mumtaaz.Penjualan
                             where o.Tanggal >= labaRugi.tglSebelum.DateTime && o.Tanggal <= labaRugi.tglSesudah.DateTime
                             select o).ToList();

                return query.Select(x => x.TotalHarga).Sum();
            }
        }

        public int HPP()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var query = (from o in mumtaaz.Penjualan
                             where o.Tanggal >= labaRugi.tglSebelum.DateTime && o.Tanggal <= labaRugi.tglSesudah.DateTime
                             select o).ToList();

                return query.Select(x => x.SubTotal).Sum();
            }

        }

        public int BiayaLainya()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var query = (from o in mumtaaz.KasKeluars
                             where o.Tanggal >= labaRugi.tglSebelum.DateTime && o.Tanggal <= labaRugi.tglSesudah.DateTime
                             select o).ToList();

                return query.Select(x => x.Total).Sum();
            }
        }
        
    }
}