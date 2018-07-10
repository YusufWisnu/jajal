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

        private void btnTestKoneksi_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("data source={0};initial catalog={1};integrated security=SSPI;", comboServer.Text, txtServer.Text);
            try
            {
                var helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                    MessageBox.Show("Test Connection Succeeded", "MumtaazHerbal", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("data source={0};initial catalog={1};integrated security=SSPI", comboServer.Text, listBoxDatabase.SelectedValue.ToString());
            try
            {
                var helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                {
                    AppSetting setting = new AppSetting();
                    setting.SaveConnectionString("MumtaazFix", connectionString);
                    //MessageBox.Show("Your Connectionstring has succesfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMain main = new frmMain();
                    main.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("data source={0};initial catalog={1};integrated security=SSPI", comboServer.Text, listBoxDatabase.SelectedValue.ToString());
            try
            {
                var helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                {
                    AppSetting setting = new AppSetting();
                    setting.SaveConnectionString("MumtaazFix", connectionString);
                    MessageBox.Show("Your Connectionstring has succesfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMain main = new frmMain();
                    main.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}