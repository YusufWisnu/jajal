﻿using System;
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
    public partial class historyPmb : DevExpress.XtraEditors.XtraForm
    {
        public historyPmb()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dftrSupp supp = new dftrSupp();
            supp.ShowDialog();
        }
    }
}