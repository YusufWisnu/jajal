using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MumtaazHerbal
{
    public partial class kasir : DevExpress.XtraEditors.XtraForm
    {
        public kasir()
        {
            InitializeComponent();
            
            // start timer
            var t = new Timer();
            t.Interval = 1000;  // in miliseconds
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();

        }

        MumtaazContext mumtaaz;

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            pembayaran bayar = new pembayaran();
            bayar.ShowDialog();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            dftrPending pending = new dftrPending();
            pending.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dftrPel pel = new dftrPel();
            pel.ShowDialog();
        }

        private void kasir_Load(object sender, EventArgs e)
        {
            mumtaaz = new MumtaazContext();
            txtTanggal.EditValue = DateTime.Now;
            txtuser.Text = "ADMIN";
            pelangganBindingSource.DataSource = mumtaaz.Pelanggans.ToList();
            GetNoTransaksi();
            GetPelangganUmum();
        }

        public void GetNoTransaksi()
        {
            //get no transaksi
            var noTransaksi = mumtaaz.Penjualan
                .OrderByDescending(x => x.Id)
                .Select(x => x.Id)
                .FirstOrDefault();

            if (!mumtaaz.Penjualan.Any())
                noTransaksi++;

            txtTransaksi.Text = noTransaksi.ToString().PadLeft(4, '0') + "/KSR/" + DateTime.Now.ToString("ddMM");
        }

        public void t_Tick(object sender, EventArgs e)
        {
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            //padding leading zero
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            txtTimer.Text = time;
        }

        public void GetPelangganUmum()
        {
            //var query = from o in mumtaaz.Pelanggans
            //            where o.KodePelanggan == "UMUM"

            lookPelanggan.Text = mumtaaz.Pelanggans
                .Where(x => x.KodePelanggan == "UMUM")
                .Select(x => x.KodePelanggan)
                .FirstOrDefault()
                .ToString();
        }

    }
}


