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
    public partial class dftrSupp : DevExpress.XtraEditors.XtraForm
    {
        Query query;
        public dftrSupp()
        {
            InitializeComponent();
        }
        MumtaazContext mumtaaz;

        private void dftrSupp_Load(object sender, EventArgs e)
        {
            mumtaaz = new MumtaazContext();
            supplierBindingSource.DataSource = mumtaaz.Suppliers.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(tmbhSupp))
                {
                    form.Activate();
                    return;
                }
            }
            query.GetSupp(gridView1);
            tmbhSupp supp = new tmbhSupp();
            supp.MdiParent = this.ParentForm;
            supp.Show();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }
    }
}