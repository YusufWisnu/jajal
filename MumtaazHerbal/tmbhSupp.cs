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
using DevExpress.XtraGrid.Views.Grid;

namespace MumtaazHerbal
{
    public partial class tmbhSupp : DevExpress.XtraEditors.XtraForm
    {


        private BindingSource supplierSource;
        private dftrSupp daftarSupplier;
        private GridView gridview;
        private Query query;
        private bool edit;
        private string kodeSupplier;

        public tmbhSupp()
        {
            InitializeComponent();
        }

        public tmbhSupp(dftrSupp daftarsupplier, bool edit, )
        {

        }

        DbHelper dbhelper = new DbHelper();
        Utilities util = new Utilities();
        Query que = new Query();


        private void tmbhSupp_Load(object sender, EventArgs e)
        {
            if (edit)
            {
                GetData();
                this.Text = "Data Pelanggan";
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
                {
                    //jika user merubah nama yang sudah ada
                    if (txtKode.Text != kodeSupplier)
                    {
                        if (mumtaaz.Pelanggans.Any(o => o.KodePelanggan == txtKode.Text))
                        {
                            return;
                        }
                    }

                    //query mencari pelanggan yang akan di edit dengan nomor Id 
                    var result = (from i in mumtaaz.Pelanggans
                                  where i.Id == query.IdPelanggan
                                  select i).Single();

                    result.KodePelanggan = txtKode.Text;
                    result.Nama = txtNama.Text;
                    result.Alamat = txtAlamat.Text;
                    result.Email = txtEmail.Text;
                    result.NoHp = txtTelepon.Text;

                    mumtaaz.Entry(result).State = System.Data.Entity.EntityState.Modified;//tandai hasil query yang akan di edit
                    mumtaaz.SaveChanges();
                    pelangganSource.DataSource = mumtaaz.Pelanggans.ToList();
                    XtraMessageBox.Show("Berhasil Merubah Data Pelanggan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    edit = false;
                    ClearText();
                }
            }
        }
            else
            {
                using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
                {

                    var supplier = new Supplier()
                    {
                        NamaSupplier = txtNama.Text,
                        Alamat = txtAlamat.Text,
                        Email = txtEmail.Text,
                        KodeSupplier = txtKode.Text,
                        NoHP = txtTelepon.Text
                    };

                    if (cekKodeSupplier(txtKode.Text))
                        return;

                    mumtaaz.Suppliers.Add(supplier);
                    supplierSource.Add(supplier);
                    supplierSource.MoveLast();
                    mumtaaz.SaveChanges();
                    XtraMessageBox.Show("Berhasil Menambah Pelanggan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();
                }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //cek duplikasi kode supplier
        public bool cekKodeSupplier(string kodeSupplier)
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                if (mumtaaz.Pelanggans.Any(o => o.KodePelanggan == kodeSupplier))
                {
                    MessageBox.Show("Kode Supplier sudah digunakan.", "Mumtaaz Herbal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            return false;
        }

        //clear textbox
        private void ClearText()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is BaseEdit)
                    (ctrl as BaseEdit).EditValue = null;
            }
        }

        public void GetData()
        {
            var rowHandle = gridview.FocusedRowHandle;
            var kodeSupplier = gridview.GetRowCellValue(rowHandle, gridview.Columns[1]).ToString();

            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var query = mumtaaz.Suppliers
                    .Where(x => x.KodeSupplier == kodeSupplier)
                    .FirstOrDefault();

                txtKode.Text = query.KodeSupplier;
                txtNama.Text = query.NamaSupplier;
                txtAlamat.Text = query.Alamat;
                txtEmail.Text = query.Email;
                txtTelepon.Text = query.NoHP;

            }

        }

    }
}