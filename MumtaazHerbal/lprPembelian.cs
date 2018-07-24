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
    public partial class lprPembelian : DevExpress.XtraEditors.XtraForm
    {
        private DbHelper dbhelper;

        public lprPembelian()
        {
            InitializeComponent();
            dbhelper = new DbHelper();
        }

        private void lprPembelian_Load(object sender, EventArgs e)
        {
            tglSebelum.EditValue = DateTime.Today;
            tglSesudah.EditValue = tglSebelum.DateTime.AddDays(1).AddTicks(-1);
        }

        List<ListNotaPembelian> notaBeli = new List<ListNotaPembelian>();
        public void GetData()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var query = from o in mumtaaz.Pembelians
                            join a in mumtaaz.Suppliers on o.SupplierId equals a.Id
                            where o.Tanggal >= tglSebelum.DateTime && o.Tanggal <= tglSesudah.DateTime
                            select new
                            {
                                o.NoTransaksi,
                                o.Tanggal,
                                a.KodeSupplier,
                                o.JumlahItem,
                                o.TotalHarga

                            };

                foreach (var i in query.ToList())
                {
                    var beli = new ListNotaPembelian()
                    {
                        NoTransaksi = i.NoTransaksi,
                        Tanggal = i.Tanggal,
                        KodePelanggan = i.KodeSupplier,
                        JmlItem = i.JumlahItem,
                        SubTotal = i.TotalHarga
                    };

                    notaBeli.Add(beli);
                }
            }
        }

        public void CetakPiutang()
        {
            using (var printNota = new NotaPembelianViewer())
            {
                GetData();
                printNota.PrintInvoicePiutang(this, notaBeli);
                printNota.ShowDialog();
                notaBeli.Clear();
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            CetakPiutang();
        }
    }
}