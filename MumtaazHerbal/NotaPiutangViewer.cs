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
    public partial class NotaPiutangViewer : DevExpress.XtraEditors.XtraForm
    {
        
        public NotaPiutangViewer()
        {
            InitializeComponent();
        }



        NotaPiutang nota;
        DbHelper dbhelper;
        MumtaazContext mumtaaz;


        public void PrintInvoicePiutang(pembayaranPiutang _pembayaran, List<NotaPembayaranPiutang> piutangs)
        {
            nota = new NotaPiutang();
            dbhelper = new DbHelper();
            mumtaaz = new MumtaazContext(dbhelper.ConnectionString);

            foreach (DevExpress.XtraReports.Parameters.Parameter p in nota.Parameters)
                p.Visible = false;

            var idPelanggan = Convert.ToInt32(_pembayaran.lookPelanggan.EditValue);

            var kodePelanggan = mumtaaz.Pelanggans
                            .Where(x => x.Id == idPelanggan)
                            .Select(x => x.KodePelanggan)
                            .FirstOrDefault();

            nota.InitData(_pembayaran.txtTransaksi.Text, _pembayaran.lookPelanggan.Text, kodePelanggan, DateTime.Now, piutangs);
            documentViewer1.DocumentSource = nota;
            nota.CreateDocument();
        }
        
        private void NotaPiutangViewer_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}