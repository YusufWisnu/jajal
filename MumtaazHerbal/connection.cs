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
using MumtaazHerbal.Function;

namespace MumtaazHerbal
{
    public partial class connection : DevExpress.XtraEditors.XtraForm
    {
        public connection()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var frm = new frmMain();
            frm.Show();
        }
        DbHelper dbhelper;

        private void connection_Load(object sender, EventArgs e)
        {
            comboServer.Properties.Items.Add(".");
            comboServer.Properties.Items.Add("(local)");
            comboServer.Properties.Items.Add(@".\SQLEXPRESS");
            comboServer.Properties.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            comboServer.SelectedIndex = 3;

            Properties.Settings.Default.ConnectionString = string.Format("data source={0};initial catalog=master;integrated security=SSPI;", comboServer.Text);
            Properties.Settings.Default.DataSource = comboServer.Text;
        }

        //get list database
        public List<string> GetDatabasesList()
        {
            var list = new List<string>();
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                cn.Open();

                var cmd = new SqlCommand("SELECT name FROM sys.databases", cn);
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0].ToString() == "master" || dr[0].ToString() == "model" || dr[0].ToString() == "tempdb" || dr[0].ToString() == "msdb")
                        continue;

                    list.Add(dr[0].ToString());
                }

            }
            return list;
        }

        //btn cari database
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            listBoxDatabase.DataSource = GetDatabasesList();

        }

        //btn create database
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            createDB create = new createDB();
            create.ShowDialog();
        }

        //btn pilih
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboServer.Text) || string.IsNullOrEmpty(listBoxDatabase.Text))
            {
                MessageBox.Show("Mohon isi server dan nama database", "Mumtaaz Herbal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dbhelper = new DbHelper();
            Properties.Settings.Default.ConnectionString = string.Format("data source={0};initial catalog={1};integrated security=SSPI;", comboServer.Text, listBoxDatabase.SelectedValue.ToString());
            //var main = new frmMain();
            //main.Show();
            this.Hide();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        //btn set koneksi
        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboServer.Text))
            {
                MessageBox.Show("Pilih server terlebih dahulu");
                return;
            }

            Properties.Settings.Default.ConnectionString = string.Format("data source={0};initial catalog=master;integrated security=SSPI;", comboServer.Text);
            Properties.Settings.Default.DataSource = comboServer.Text;

            if (isServerConnected(Properties.Settings.Default.ConnectionString))
                MessageBox.Show("Set koneksi sukses", "Mumtaaz Herbal", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //test koneksi
        private bool isServerConnected(string connectionString)
        {
            dbhelper = new DbHelper();
            using (var sqlConnection = new SqlConnection(dbhelper.ConnectionString))
            {
                try
                {
                    sqlConnection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }

        private void connection_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}