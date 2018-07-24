using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using MumtaazHerbal.Function;
using System.Collections.Generic;

namespace MumtaazHerbal
{
    public partial class NotaPembelian : DevExpress.XtraReports.UI.XtraReport
    {
        public NotaPembelian()
        {
            InitializeComponent();
        }

        public void InitData(DateTime tglSebelum, DateTime tglSesudah, List<ListNotaPembelian> listLaba)
        {
            pTglSblm.Value = tglSebelum;
            pTglSdh.Value = tglSesudah;
            objectDataSource1.DataSource = listLaba;
        }

    }
}
