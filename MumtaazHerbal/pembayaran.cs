using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace MumtaazHerbal
{
    public partial class pembayaran : DevExpress.XtraEditors.XtraForm
    {
        private GridView gridView;
        private kasir kasir;

        public pembayaran()
        {
            InitializeComponent();
        }

        public pembayaran(kasir kasir, GridView gridView)
            :this()
        {
            this.kasir = kasir;
            this.gridView = gridView;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}