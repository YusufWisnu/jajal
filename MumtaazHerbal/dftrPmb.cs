using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SQLite;

namespace MumtaazHerbal
{
    public partial class dftrPmb : DevExpress.XtraEditors.XtraForm
    {
        SQLiteConnection con = new SQLiteConnection(@"Data Source = C:\Users\YUSUF WISNU P\Source\Repos\jajal\MumtaazDB.db; Version = 3;");
        public dftrPmb()
        {
            InitializeComponent();
        }

        private void dftrPmb_Load(object sender, EventArgs e)
        {
            SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROM [tb_daftar_pembelian]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gridControl1.DataSource = dt;
        }
    }
}