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
    public partial class lprPenjualan : DevExpress.XtraEditors.XtraForm
    {
        private DbHelper dbhelper;

        public lprPenjualan()
        {
            InitializeComponent();
            dbhelper = new DbHelper();

        }

        private void lprPenjualan_Load(object sender, EventArgs e)
        {
            tglSebelum.EditValue = DateTime.Today;
            tglSesudah.EditValue = tglSebelum.DateTime.AddDays(1).AddTicks(-1);
        }

        List<ListNotaPenjualan> notaJual = new List<ListNotaPenjualan>();
        public void GetData()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {

                var query = (from o in mumtaaz.Penjualan
                             where o.Tanggal >= tglSebelum.DateTime && o.Tanggal <= tglSesudah.DateTime
                             group  o by new { o.Tanggal  } into tanggalGroup
                             select new
                             {
                                 tanggalGroup.Key.Tanggal
                             }).ToList();

                //MessageBox.Show(query.Count().ToString());
                var dt = string.Empty;

                foreach (var i in query)
                {
                    if (i.Tanggal.Date.AddDays(1).AddTicks(-1).ToString() == dt)
                        continue;

                    var endDay = i.Tanggal.Date.AddDays(1).AddTicks(-1);
                    var startDay = i.Tanggal.Date.AddDays(-1).AddTicks(1);

                    var jmlTransaksi = mumtaaz.Penjualan.Where(x => x.Tanggal >= startDay && x.Tanggal <= endDay).Count();
                    var jmlKredit = mumtaaz.Penjualan.Where(x => x.Tanggal >= startDay && x.Tanggal <= endDay).Select(x => x.BayarKredit).Sum();
                    var jmlTunai = mumtaaz.Penjualan.Where(x => x.Tanggal >= startDay && x.Tanggal <= endDay).Select(x => x.BayarTunai).Sum();
                    var total = mumtaaz.Penjualan.Where(x => x.Tanggal >= startDay && x.Tanggal <= endDay).Select(x => x.TotalHarga).Sum();

                    dt = i.Tanggal.Date.AddDays(1).AddTicks(-1).ToString();

                    var notaPenjualan = new ListNotaPenjualan()
                    {
                        Tanggal = i.Tanggal,
                        JumlahTransaksi = jmlTransaksi,
                        JumlahBayarKredit = jmlKredit,
                        JumlahBayarTunai = jmlTunai,
                        TotalTransaksi = total
                    };

                    notaJual.Add(notaPenjualan);
                }


            }
        }

        public void CetakPiutang()
        {
            using (var printNota = new NotaPenjualanViewer())
            {
                GetData();
                printNota.PrintInvoicePiutang(this, notaJual);
                printNota.ShowDialog();
                notaJual.Clear();
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            CetakPiutang();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var query = (from o in mumtaaz.Penjualan
                             where o.Tanggal >= tglSebelum.DateTime && o.Tanggal <= tglSesudah.DateTime
                             select o).ToList();

                foreach (var i in query)
                {
                    var tanggal = mumtaaz.Penjualan.Where(x => x.Tanggal == i.Tanggal).Select(x => x.Tanggal).FirstOrDefault();

                    //var jmlTransaksi = 
                    var jmlKredit = mumtaaz.Penjualan.Where(x => x.Tanggal == i.Tanggal).Select(x => x.BayarKredit).Sum();
                    var jmlTunai = mumtaaz.Penjualan.Where(x => x.Tanggal == i.Tanggal).Select(x => x.BayarTunai).Sum();
                    var total = mumtaaz.Penjualan.Where(x => x.Tanggal == i.Tanggal).Select(x => x.TotalHarga).Sum();

                    
                    MessageBox.Show(i.Tanggal.Date.AddDays(1).AddTicks(-1).ToString());
                    MessageBox.Show(tanggal.Date.AddDays(1).AddTicks(-1).ToString());

                }


            }
        }
    }
}