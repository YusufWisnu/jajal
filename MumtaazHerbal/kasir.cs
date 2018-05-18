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
            pelangganBindingSource.DataSource = mumtaaz.Pelanggans.ToList();

        }
    }
}


