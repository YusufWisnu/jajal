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
    public partial class editHargaPembelian : DevExpress.XtraEditors.XtraForm
    {
        private string kodeItem;
        private int harga;

        public editHargaPembelian()
        {
            InitializeComponent();
        }

        public editHargaPembelian(string kodeItem, int harga)
            :this()
        {
            this.kodeItem = kodeItem;
            this.harga = harga;
        }

        DbHelper dbhelper = new DbHelper();


        private void editHargaPembelian_Load(object sender, EventArgs e)
        {
            txtHargaPokok.Focus();
            getInformasiItem();
        }

        public void getInformasiItem()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var query = mumtaaz.Items
                    .Where(x => x.KodeItem == kodeItem)
                    .FirstOrDefault();

                txtNamaItem.Text = query.NamaItem;
                txtHargaPokok.Text = harga.ToString();
                txtHargaGrosir.Text = query.HargaGrosir.ToString();
                txtHargaRetail.Text = query.HargaEceran.ToString();
                
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                if (int.Parse(txtHargaPokok.Text) > int.Parse(txtHargaGrosir.Text) || int.Parse(txtHargaPokok.Text) > int.Parse(txtHargaRetail.Text))
                {
                    MessageBox.Show("Harga pokok tidak bisa lebih besar dari harga retail ataupun harga grosir", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var query = mumtaaz.Items
                    .Where(x => x.KodeItem == kodeItem)
                    .FirstOrDefault();

                query.HargaJual = int.Parse(txtHargaPokok.Text);
                query.HargaEceran = int.Parse(txtHargaRetail.Text);
                query.HargaGrosir = int.Parse(txtHargaGrosir.Text);

                mumtaaz.Entry(query).State = System.Data.Entity.EntityState.Modified;
                mumtaaz.SaveChanges();
                XtraMessageBox.Show("Berhasil Merubah Harga", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}