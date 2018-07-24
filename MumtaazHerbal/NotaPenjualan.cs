using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using MumtaazHerbal.Function;

namespace MumtaazHerbal
{
    public partial class NotaPenjualan : DevExpress.XtraReports.UI.XtraReport
    {
        public NotaPenjualan()
        {
            InitializeComponent();
            
        }

        public void InitData(DateTime tglSebelum, DateTime tglSesudah, List<ListNotaPenjualan> listLaba)
        {
            pTglSblm.Value = tglSebelum;
            pTglSdh.Value = tglSesudah;
            objectDataSource2.DataSource = listLaba;
        }

    }
}
