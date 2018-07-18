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
    public partial class dftrKasKeluar : DevExpress.XtraEditors.XtraForm
    {
        private DbHelper dbhelper;

        public dftrKasKeluar()
        {
            InitializeComponent();
            dbhelper = new DbHelper();
        }

        private void dftrKasKeluar_Load(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {

        }

    }

}