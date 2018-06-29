using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using MumtaazHerbal.Function;
using System.Collections.Generic;

namespace MumtaazHerbal
{
    public partial class Nota : DevExpress.XtraReports.UI.XtraReport
    {
        public Nota()
        {
            InitializeComponent();
        }

        public void InitData(string noTransaksi, string namaPelanggan, DateTime tanggal, string waktu, int hargaTunaiKredit, string kembaliKekurangan, List<Receipt> receipt)
        {
            pNoTransaksi.Value = noTransaksi;
            pPelanggan.Value = namaPelanggan;
            pTanggal.Value = tanggal.Date;
            pTanggalWaktu.Value = waktu;
            pBayar.Value = hargaTunaiKredit;
            objectDataSource1.DataSource = receipt;
            pKembaliKekurangan.Value = kembaliKekurangan;
        }

        public void PrintInvoice(kasir _kasir, pembayaran _pembayaran, List<Receipt> receipt)
        {
            string kembali = "";

            foreach (DevExpress.XtraReports.Parameters.Parameter p in this.Parameters)
                p.Visible = false;

            //Tunai atau Kredit
            if (int.Parse(_pembayaran.txtKredit.Text.Replace(",", "")) > 0)
                kembali = "Kekurangan";
            else
                kembali = "Kembalian";

            InitData(_kasir.txtTransaksi.Text, _kasir.lookPelanggan.Text, DateTime.Now, DateTime.Now.ToString("HH:mm:ss"), int.Parse(_pembayaran.txtTunai.Text.Replace(",", "")), kembali, receipt);
            CreateDocument();
            this.Print();
        }
    }
}
