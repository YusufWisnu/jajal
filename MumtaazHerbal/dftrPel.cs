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
    public partial class dftrPel : DevExpress.XtraEditors.XtraForm
    {
        public dftrPel()
        {
            InitializeComponent();
        }

        Query query;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(tmbhPel))
                {
                    form.Activate();
                    return;
                }
            }

            tmbhPel tmbh = new tmbhPel(pelangganBindingSource);
            tmbh.MdiParent = this.ParentForm;
            tmbh.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool edit = true;
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(tmbhPel))
                {

                    form.Activate();
                    return;
                }
            }
            GetData();
            tmbhPel tmbh = new tmbhPel(this, edit, query, pelangganBindingSource);
            tmbh.MdiParent = this.ParentForm;
            tmbh.Show();
        }

        private void dftrPel_Load(object sender, EventArgs e)
        {
            query = new Query();

            using (var mumtaaz = new MumtaazContext())
            {
                pelangganBindingSource.DataSource = mumtaaz.Pelanggans.ToList();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        public void GetData()
        {
            var rowHandle = gridView1.FocusedRowHandle;
            query.NamaPel= gridView1.GetRowCellValue(rowHandle, "Nama").ToString();
            query.AlamatPel= gridView1.GetRowCellValue(rowHandle, "Alamat").ToString();
            query.EmailPel= gridView1.GetRowCellValue(rowHandle, "Email").ToString();
            query.TeleponPel= gridView1.GetRowCellValue(rowHandle, "NoHp").ToString();
            query.KodePel= gridView1.GetRowCellValue(rowHandle, "KodePelanggan").ToString();
            using (var mumtaaz = new MumtaazContext())
            {
                query.IdPelanggan = Convert.ToInt32(mumtaaz.Pelanggans.Where(c => c.KodePelanggan == query.KodePel).SingleOrDefault()?.Id);

            }


        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if(pelangganBindingSource.Current != null)
            {
                if(XtraMessageBox.Show("Hapus data ini ?.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (var mumtaaz = new MumtaazContext())
                    {
                        Pelanggan obj = pelangganBindingSource.Current as Pelanggan;
                        if (mumtaaz.Entry<Pelanggan>(obj).State == System.Data.Entity.EntityState.Detached)
                            mumtaaz.Set<Pelanggan>().Attach(obj);
                        mumtaaz.Entry<Pelanggan>(obj).State = System.Data.Entity.EntityState.Deleted;
                        pelangganBindingSource.RemoveCurrent();
                        mumtaaz.SaveChanges();
                        XtraMessageBox.Show("Berhasil menghapus data ini.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}