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
        private Query query;
        private bool edit;
        public tmbhItem()
        {
            InitializeComponent();
        }

        public tmbhItem(Query query, bool edit)
            : this()
        {
            this.query = query;
            this.edit = edit;
        }

        MumtaazContext mumtaaz;
        Utilities util;
        

        private void tmbhItem_Load(object sender, EventArgs e)
        {
            mumtaaz = new MumtaazContext();
            supplierBindingSource.DataSource = mumtaaz.Suppliers.ToList();
            if (edit)
            {
                RetrieveData();
                this.Text = "Edit Item : " + txtKodeItem.Text;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            util = new Utilities();
            var que = new Query();

            if (util.CheckIfNull(this))
            {
                return;
            }

            if (edit)
            {
                try
                {
                    var result = (from i in mumtaaz.Items
                                  where i.KodeItem == txtKodeItem.Text
                                  select i).Single();

                    result.KodeItem = txtKodeItem.Text;
                    result.NamaItem = txtNamaItem.Text;
                    result.SupplierId = Convert.ToInt32(lookSupplier.EditValue);
                    result.Stok = Convert.ToInt32(txtStok.Text);
                    result.Satuan = txtSatuan.Text;
                    result.HargaEceran = Convert.ToInt32(txtHargaRetail.Text);
                    result.HargaGrosir = Convert.ToInt32(txtHargaGrosir.Text);
                    result.HargaJual = Convert.ToInt32(txtHargaPokok.Text);
                    edit = false;

                    //if (que.CheckIfEdit(txtKodeItem.Text))
                    //    return;

                    XtraMessageBox.Show("Berhasil Merubah Item", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mumtaaz.SaveChanges();
                    util.ClearEditors(this);
                }

                catch (Exception ee)
                {
                    XtraMessageBox.Show("Mohon periksa kembali fieldnya", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            else
            {
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

                    if (que.CheckIfAdd(txtKodeItem.Text))
                        return;

                    mumtaaz.Items.Add(item);
                    mumtaaz.SaveChanges();
                    XtraMessageBox.Show("Berhasil Menambah Item", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    util.ClearEditors(this);
                }

                catch (Exception ee)
                {
                    XtraMessageBox.Show(ee.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            util = new Utilities();
            util.ClearEditors(this);
            
        }

        public void RetrieveData()
        {
            txtKodeItem.Text = query.KodeItem;
            txtNamaItem.Text = query.NamaItem;
            lookSupplier.Text = query.NamaSupplier;
            txtStok.Text = query.Stok;
            txtSatuan.Text = query.Satuan;
            txtHargaRetail.Text = query.HargaEceran;
            txtHargaGrosir.Text = query.HargaGrosir;
            txtHargaPokok.Text = query.HargaJual;
        }
    }
}