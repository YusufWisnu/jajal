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
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(dftrItem))
                {
                    form.Activate();
                    return;
                }
            }
            dftrItem item = new dftrItem();
            item.MdiParent = this;
            item.Show();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(tmbhItem))
                {
                    form.Activate();
                    return;
                }
            }
            tmbhItem item = new tmbhItem();
            item.MdiParent = this;
            item.Show();
        }

        private void btnDftrSupp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(dftrSupp))
                {
                    form.Activate();
                    return;
                }
            }

            dftrSupp supp = new dftrSupp();
            supp.MdiParent = this;
            supp.Show();
        }

        private void btnDftrPel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(dftrPel))
                {
                    form.Activate();
                    return;
                }
            }

            dftrPel pel = new dftrPel();
            pel.MdiParent = this;
            pel.Show();
        }

        private void btnMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(kasir))
                {
                    form.Activate();
                    return;
                }
            }

            kasir ksr = new kasir();
            ksr.MdiParent = this;
            ksr.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(dftrPmb))
                {
                    form.Activate();
                    return;
                }
            }

            dftrPmb pmb = new dftrPmb();
            pmb.MdiParent = this;
            pmb.Show();
        
        }

        //history pembelian
        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach(Form form in Application.OpenForms)
            {
                if(form.GetType() == typeof(historyPmb))
                {
                    form.Activate();
                    return;
                }
            }

            historyPmb pmb = new historyPmb();
            pmb.MdiParent = this;
            pmb.Show();
        }

        //pembelian
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(pembelian))
                {
                    form.Activate();
                    return;
                }
            }

            pembelian pmb = new pembelian();
            pmb.MdiParent = this;
            pmb.Show();
        }

        //daftar penjualan
        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(dftrPenjualan))
                {
                    form.Activate();
                    return;
                }
            }

            dftrPenjualan penjualan = new dftrPenjualan();
            penjualan.MdiParent = this;
            penjualan.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(historyPenjualan))
                {
                    form.Activate();
                    return;
                }
            }

            historyPenjualan hstPenjualan= new historyPenjualan();
            hstPenjualan.MdiParent = this;
            hstPenjualan.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(pembayaranPiutang))
                {
                    form.Activate();
                    return;
                }
            }

            pembayaranPiutang piutang = new pembayaranPiutang();
            piutang.MdiParent = this;
            piutang.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.ConnectionString = string.Format("data source=.;initial catalog=MumtaazFixV1;integrated security=SSPI;");

        }

        
    }
}