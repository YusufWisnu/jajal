using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using MumtaazHerbal.Function;

namespace MumtaazHerbal
{
    public partial class NotaLabaJual : DevExpress.XtraReports.UI.XtraReport
    {
        public NotaLabaJual()
        {
            InitializeComponent();
        }

        public void InitData(DateTime tglSebelum, DateTime tglSesudah, List<NotaLabaKotor> listLaba)
        {
            pTanggalSblm.Value = tglSebelum;
            pTanggalSdh.Value = tglSesudah;
            objectDataSource1.DataSource = listLaba;
        }


    }
}
