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
    public partial class frmPrint : DevExpress.XtraEditors.XtraForm
    {
        public frmPrint()
        {
            InitializeComponent();
        }

        public void PrintInvoice(kasir _kasir, pembayaran _pembayaran, List<Receipt> receipt)
        {
            string kembali = "";

            Nota nota = new Nota();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in nota.Parameters)
                p.Visible = false;

            //Tunai atau Kredit
            if (int.Parse(_pembayaran.txtKredit.Text.Replace(",", "")) > 0)
                kembali = "Kekurangan";
            else
                kembali = "Kembalian";

            nota.InitData(_kasir.txtTransaksi.Text, _kasir.lookPelanggan.Text, DateTime.Now, DateTime.Now.ToString("HH:mm:ss"), int.Parse(_pembayaran.txtTunai.Text.Replace(",", "")),kembali, receipt);
            documentViewer1.DocumentSource = nota;
            nota.CreateDocument();
        }
    }
}