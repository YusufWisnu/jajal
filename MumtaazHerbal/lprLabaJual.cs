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
    public partial class lprLabaJual : DevExpress.XtraEditors.XtraForm
    {
        private DbHelper dbhelper;

        public lprLabaJual()
        {
            InitializeComponent();
            dbhelper = new DbHelper();
        }

        private void lprLabaJual_Load(object sender, EventArgs e)
        {
            tglSebelum.EditValue = DateTime.Today;
            tglSesudah.EditValue = tglSebelum.DateTime.AddDays(1).AddTicks(-1);
        }

        List<NotaLabaKotor> labaKotor = new List<NotaLabaKotor>();
        public void GetData()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var query = from o in mumtaaz.Penjualan
                            join a in mumtaaz.Pelanggans on o.PelangganId equals a.Id
                            where o.Tanggal >= tglSebelum.DateTime && o.Tanggal <= tglSesudah.DateTime
                            select new
                            {
                                o.NoTransaksi,
                                o.Tanggal,
                                a.KodePelanggan,
                                a.Nama,
                                o.TotalHarga,
                                o.SubTotal,
                            };
                foreach(var i in query.ToList())
                {
                    var laba = new NotaLabaKotor()
                    {
                        NoTransaksi = i.NoTransaksi,
                        Tanggal = i.Tanggal,
                        KodePelanggan = i.KodePelanggan,
                        NamaPelanggan = i.Nama,
                        TotalPokok = i.SubTotal,
                        SubTotal = i.TotalHarga,
                        LabaJual = i.TotalHarga - i.SubTotal,
                        LabaKotor = i.TotalHarga - i.SubTotal,

                    };
                    labaKotor.Add(laba);
                }

            }
        }

        public void CetakPiutang()
        {
            using (var printLaba = new NotaLabaKotorViewer())
            {
                GetData();
                printLaba.PrintInvoicePiutang(this, labaKotor);
                printLaba.ShowDialog();
                labaKotor.Clear();
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            CetakPiutang();
        }
    }
}