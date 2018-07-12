using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Linq.SqlClient;
using MumtaazHerbal.Function;

namespace MumtaazHerbal
{
    public partial class KoneksiDatabase : DevExpress.XtraEditors.XtraForm
    {
        public KoneksiDatabase()
        {
            InitializeComponent();
        }



        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
        }

        public List<string> GetDatabasesList()
        {
            var list = new List<string>();
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["MumtaazFix"].ConnectionString))
            {
                cn.Open();

                var cmd = new SqlCommand("SELECT name FROM sys.databases", cn);
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                    list.Add(dr[0].ToString());        
                
            }
            return list;
        }

        private void KoneksiDatabase_Load(object sender, EventArgs e)
        {
            comboServer.Properties.Items.Add(".");
            comboServer.Properties.Items.Add("(local)");
            comboServer.Properties.Items.Add(@".\SQLEXPRESS");
            comboServer.Properties.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            comboServer.SelectedIndex = 0;
            

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listBoxDatabase.DataSource = GetDatabasesList();

        }

        //button pilih
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(comboServer.Text) || string.IsNullOrEmpty(listBoxDatabase.Text))
            {
                MessageBox.Show("Mohon isi server dan nama database", "Mumtaaz Herbal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dbhelper = new DbHelper();
            Properties.Settings.Default.ConnectionString = string.Format("data source={0};initial catalog={1};integrated security=SSPI;", comboServer.Text, listBoxDatabase.SelectedValue.ToString());
            this.Close();
        }

        //butto close
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            createDB create = new createDB();
            create.ShowDialog();
        }
    }
}