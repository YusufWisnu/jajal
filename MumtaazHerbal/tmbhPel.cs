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
    public partial class tmbhPel : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource pelangganSource;
        private dftrPel daftarPelanggan;
        private Query query;
        private bool edit;
        public tmbhPel()
        {
            InitializeComponent();
        }

        public tmbhPel(BindingSource pelangganSource)
            :this()
        {
            this.pelangganSource = pelangganSource;
        }

        public tmbhPel(dftrPel daftarPelanggan, bool edit, Query query, BindingSource pelangganSource)
            : this(pelangganSource)
        {
            this.daftarPelanggan = daftarPelanggan;
            this.edit = edit;
            this.query = query;
        }

        private void tmbhPel_Load(object sender, EventArgs e)
        {
           

            if (edit)
            {
                RetrieveData();
                this.Text = "Data Pelanggan";
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            var util = new Utilities();
            var que = new Query();
            if (util.CheckIfNull(this))
                return;

            if (edit)
            {
                try
                {
                    using (var mumtaaz = new MumtaazContext())
                    {

                        if (txtKode.Text != query.KodePel)
                        {
                            if (mumtaaz.Pelanggans.Any(o => o.KodePelanggan == txtKode.Text))
                            {
                                return;
                            }
                        }

                        var result = (from i in mumtaaz.Pelanggans
                                      where i.Id == query.IdPelanggan
                                      select i).Single();   

                        result.KodePelanggan = txtKode.Text;
                        result.Nama = txtNama.Text;
                        result.Alamat= txtAlamat.Text;
                        result.Email = txtEmail.Text;
                        result.NoHp = txtTelepon.Text;

                        mumtaaz.Entry(result).State = System.Data.Entity.EntityState.Modified;
                        mumtaaz.SaveChanges();
                        pelangganSource.DataSource = mumtaaz.Pelanggans.ToList();
                        XtraMessageBox.Show("Berhasil Merubah Data Pelanggan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        edit = false;
                        ClearText();
                    }

                }

                catch (Exception ee)
                {
                    XtraMessageBox.Show(ee.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                try
                {
                    using (var mumtaaz = new MumtaazContext())
                    {
                        var pelanggan = new Pelanggan()
                        {
                            Nama = txtNama.Text,
                            Alamat = txtAlamat.Text,
                            Email = txtEmail.Text,
                            KodePelanggan = txtKode.Text,
                            NoHp = txtTelepon.Text
                        };

                        if (que.CheckKodePelanggan(txtKode.Text))
                            return;

                        mumtaaz.Pelanggans.Add(pelanggan);
                        pelangganSource.Add(pelanggan);
                        pelangganSource.MoveLast();
                        mumtaaz.SaveChanges();
                        XtraMessageBox.Show("Berhasil Menambah Pelanggan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearText();
                    }
                } 

                catch (Exception ee)
                {
                    XtraMessageBox.Show(ee.Message);
                }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void ClearText()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is BaseEdit)
                    (ctrl as BaseEdit).EditValue = null;
            }
        }

        public void RetrieveData()
        {

            txtKode.Text = query.KodePel;
            txtNama.Text = query.NamaPel;
            txtAlamat.Text = query.AlamatPel;
            txtEmail.Text = query.EmailPel;
            txtTelepon.Text = query.TeleponPel;

        }

    }
}