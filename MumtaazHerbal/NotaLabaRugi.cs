using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using MumtaazHerbal.Function;

namespace MumtaazHerbal
{
    public partial class NotaLabaRugi : DevExpress.XtraReports.UI.XtraReport
    {
        private DbHelper dbhelper;
        public NotaLabaRugi()
        {
            InitializeComponent();
            dbhelper = new DbHelper();
        }

        public void InitData(DateTime tglSebelum, DateTime tglSesudah, int totalPendapatanDagang, int HPP, int biayaLainya)
        {
            pTglSblm.Value = tglSebelum;
            pTglSdh.Value = tglSesudah;
            pPendaptanDagang.Value = totalPendapatanDagang;
            pHPP.Value = HPP;
            pBiayaLain.Value = biayaLainya;
        }

        

    }
}
