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
using System.Data.SqlClient;

namespace MumtaazHerbal
{
    public partial class dftrPembayaranPiutang : DevExpress.XtraEditors.XtraForm
    {
        private DbHelper dbhelper;

        public dftrPembayaranPiutang()
        {
            InitializeComponent();
            dbhelper = new DbHelper();
        }

        MumtaazContext mumtaaz;

        private void dftrPembayaranPiutang_Load(object sender, EventArgs e)
        {
            mumtaaz = new MumtaazContext(dbhelper.ConnectionString);

            pelangganBindingSource.DataSource = mumtaaz.Pelanggans.ToList();

            tglSebelum.EditValue = DateTime.Today;
            tglSesudah.EditValue = tglSebelum.DateTime.AddDays(1).AddTicks(-1);

            LoadData();
        }

        public void LoadData()
        {
            //using(var cn = new SqlConnection(dbhelper.ConnectionString))
            //{
            //    cn.Open();

            //    string query = "SELECT Piutangs.NoTransaksi, Piutangs.Tanggal, Pelanggans.KodePelanggan, Pelanggans.Nama, Piutangs.Total " +
            //                    "FROM Piutangs " +
            //                    "INNER JOIN DetailPiutangs ON Piutangs.Id = DetailPiutangs.PiutangId " +
            //                    "INNER JOIN Pelanggans ON Piutangs.PelangganId = Pelanggans.Id " +
            //                    "GROUP BY" +
            //                    "Piutangs.NoTransaksi, Piutangs.Tanggal, Pelanggans.KodePelanggan, Pelanggans.Nama, Piutangs.Total";

            //    var cmd = new SqlCommand(query, cn);
            //    var ada = new SqlDataAdapter(cmd);
            //    var dt = new DataTable();
            //    ada.Fill(dt);

            //    gridControl1.DataSource = dt;
            //}

            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var query = from o in mumtaaz.Piutangs
                            join d in mumtaaz.DetailPiutangs on o.Id equals d.PiutangId
                            join p in mumtaaz.Pelanggans on o.PelangganId equals p.Id
                            where o.Tanggal >= tglSebelum.DateTime && o.Tanggal <= tglSesudah.DateTime
                            group new { o, d, p } by new { o.NoTransaksi, o.Tanggal, p.KodePelanggan, p.Nama, o.Total }
                            into pg
                            select new
                            {
                                NoTransaksi = pg.Key.NoTransaksi,
                                Tanggal = pg.Key.Tanggal,
                                KodePelanggan = pg.Key.KodePelanggan,
                                Nama = pg.Key.Nama,
                                Total = pg.Key.Total
                            };

                gridControl1.DataSource = query.ToList();
            }
        }

        public void ChangeDate()
        {
            using (var mumtaaz = new MumtaazContext(dbhelper.ConnectionString))
            {
                var query = from o in mumtaaz.Piutangs
                            join d in mumtaaz.DetailPiutangs on o.Id equals d.PiutangId
                            join p in mumtaaz.Pelanggans on o.PelangganId equals p.Id
                            where o.NoTransaksi.Contains(txtSearch.Text) &&
                            (o.Tanggal >= tglSebelum.DateTime && o.Tanggal <= tglSesudah.DateTime)
                            && p.Nama.Contains(lookPelanggan.Text)
                            group new { o, d, p } by new { o.NoTransaksi, o.Tanggal, p.KodePelanggan, p.Nama, o.Total }
                            into pg
                            select new
                            {
                                NoTransaksi = pg.Key.NoTransaksi,
                                Tanggal = pg.Key.Tanggal,
                                KodePelanggan = pg.Key.KodePelanggan,
                                Nama = pg.Key.Nama,
                                Total = pg.Key.Total
                            };

                gridControl1.DataSource = query.ToList();
            }
        }

        private void lookPelanggan_EditValueChanged(object sender, EventArgs e)
        {
            ChangeDate();
        }

        private void tglSebelum_EditValueChanged(object sender, EventArgs e)
        {
            ChangeDate();

        }

        private void tglSesudah_EditValueChanged(object sender, EventArgs e)
        {
            ChangeDate();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ChangeDate();

        }

        private void lookPelanggan_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Back || e.KeyData == Keys.Delete))
            {
                ((LookUpEdit)sender).EditValue = null;
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(dftrPembayaranPiutang))
                {
                    form.Activate();
                    return;
                }
            }

            dftrPembayaranPiutang dftrPiutang = new dftrPembayaranPiutang();
            dftrPiutang.MdiParent = this;
            dftrPiutang.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(pembayaranPiutang))
                {
                    form.Activate();
                    return;
                }
            }
            bool edit = true;
            var noTransaksi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NoTransaksi").ToString();
            var pmb = new pembayaranPiutang(this, gridView1, edit, noTransaksi);
            pmb.MdiParent = this.ParentForm;
            pmb.Show();
        }
    }
}