using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using MumtaazHerbal.Function;

namespace MumtaazHerbal
{
    public partial class tmbhItem : DevExpress.XtraEditors.XtraForm
    {
        public tmbhItem()
        {
            InitializeComponent();
            
        }

        MumtaazContext mumtaaz;
        Utilities util;

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void tmbhItem_Load(object sender, EventArgs e)
        {
            mumtaaz = new MumtaazContext();
            supplierBindingSource.DataSource = mumtaaz.Suppliers.ToList();
            
        }

        private void unboundSource1_ValueNeeded(object sender, DevExpress.Data.UnboundSourceValueNeededEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            util = new Utilities();
            try
            {
                var item = new Item
                {
                    KodeItem = txtKodeItem.Text,
                    NamaItem = txtNamaItem.Text,
                    SupplierId = Convert.ToInt32(lookSupplier.EditValue),
                    Stok = Convert.ToInt32(txtStok.Text),
                    Satuan = txtSatuan.Text,
                    HargaEceran = Convert.ToInt32(txtHargaRetail.Text),
                    HargaGrosir = Convert.ToInt32(txtHargaGrosir.Text),
                    HargaJual = Convert.ToInt32(txtHargaPokok.Text)
                };
                mumtaaz.Items.Add(item);
                mumtaaz.SaveChanges();
                XtraMessageBox.Show("Berhasil Menambah Item", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                util.ClearText(txtKodeItem.Text, txtNamaItem.Text, lookSupplier.Text, txtStok.Text, txtSatuan.Text, txtHargaGrosir.Text, txtHargaPokok.Text, txtHargaRetail.Text);
            }
            catch(Exception ee)
            {
                XtraMessageBox.Show(ee.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        public string ClearText()
        {
            foreach()
            return clear;
        }
    }
}