using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using MumtaazHerbal.Function;

namespace MumtaazHerbal
{
    public partial class NotaPiutang : DevExpress.XtraReports.UI.XtraReport
    {
        public NotaPiutang()
        {
            InitializeComponent();
        }

        public void InitData(string noTransaksi, string namaPelanggan, string kodePelanggan, DateTime tanggal, List<NotaPembayaranPiutang> piutangs)
        {
            pNoTransaksi.Value = noTransaksi;
            pPelanggan.Value = namaPelanggan;
            pKodePelanggan.Value = kodePelanggan;
            pTanggal.Value = tanggal;
            objectDataSource3.DataSource = piutangs;
        }

        

    }
}
