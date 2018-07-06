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
using DevExpress.XtraGrid;

namespace MumtaazHerbal
{
    public partial class tmbhItem : DevExpress.XtraEditors.XtraForm
    {
        private Query query;
        private bool edit;
        private GridControl gridControl1 = new GridControl();


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

        public tmbhItem(GridControl gridControl1)
            :this()
        {
            this.gridControl1 = gridControl1;
        }
            
        MumtaazContext mumtaaz;
        Utilities util;
        Item item;


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

            //if(txthar)

            if (util.CheckIfNull(this))
            {
                return;
            }

            if (edit)
            {
                try
                {
                    using (var mumtaaz = new MumtaazContext())
                    {

                        if (txtKodeItem.Text != query.KodeItem)
                        {
                            if(mumtaaz.Items.Any(o => o.KodeItem == txtKodeItem.Text))
                            {
                                return;
                            }
                        }

                        var result = (from i in mumtaaz.Items
                                      where i.Id == query.Id
                                      select i).Single();

                        result.KodeItem = txtKodeItem.Text;
                        result.NamaItem = txtNamaItem.Text;
                        result.SupplierId = Convert.ToInt32(lookSupplier.EditValue);
                        result.Stok = Convert.ToInt32(txtStok.Text);
                        result.Satuan = txtSatuan.Text;
                        result.HargaEceran = Convert.ToInt32(txtHargaRetail.Text);
                        result.HargaGrosir = Convert.ToInt32(txtHargaGrosir.Text);
                        result.HargaJual = Convert.ToInt32(txtHargaPokok.Text);

                        mumtaaz.Entry(result).State = System.Data.Entity.EntityState.Modified;
                        mumtaaz.SaveChanges();
                        XtraMessageBox.Show("Berhasil Merubah Item", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        edit = false;
                        util.ClearEditors(this);
                        que.DisplayDaftarItem(gridControl1);
                    }
                        
                }

                catch (Exception ee)
                {
                    XtraMessageBox.Show(ee.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            // end ifs
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
                    dftrItem dftr = new dftrItem();
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