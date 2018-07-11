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
using MumtaazHerbal.Function;

namespace MumtaazHerbal
{
    public partial class createDB : DevExpress.XtraEditors.XtraForm
    {
        public createDB()
        {
            InitializeComponent();
        }

        public string GetNamaDB
        {
            get
            {
                return txtnamaDB.Text;
            }
            set
            {
                this.txtnamaDB.Text = value;
            }
        }

        private void createDB_Load(object sender, EventArgs e)
        {

        }
        SqlCommand cmd;
        DbHelper dbhelper;
        public void CreateDatabase()
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["MumtaazFix"].ConnectionString))
            {
                cmd = new SqlCommand();
                cn.Open();
                cmd.Connection = cn;

                string namaDatabase = string.Format("create database {0}", txtnamaDB.Text);
                cmd.CommandText = namaDatabase;
                cmd.ExecuteNonQuery();
                cn.Close();
            }

        }

        public void CreateTable()
        {
            dbhelper = new DbHelper();

            string connectionString = string.Format("data source ={0}; initial catalog ={1}; integrated security = SSPI;", dbhelper.Datasource, txtnamaDB.Text);
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cmd = new SqlCommand();
                cn.Open();
                cmd.Connection = cn;

                string tableDetailPembelians = @"CREATE TABLE [dbo].[DetailPembelians](
	                                                [Id] [int] IDENTITY(1,1) NOT NULL,
	                                                [JumlahBarang] [int] NOT NULL,
	                                                [HargaBarang] [int] NOT NULL,
	                                                [PembelianId] [int] NOT NULL,
	                                                [ItemId] [int] NOT NULL,
                                                 CONSTRAINT [PK_dbo.DetailPembelians] PRIMARY KEY CLUSTERED 
                                                (
	                                                [Id] ASC
                                                )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                                                ) ON [PRIMARY]
                                                ";
                cmd.CommandText = tableDetailPembelians;
                cmd.ExecuteNonQuery();

                string tableDetailPenjualans = @"CREATE TABLE [dbo].[DetailPenjualans](
	                                            [Id] [int] IDENTITY(1,1) NOT NULL,
	                                            [JumlahBarang] [int] NOT NULL,
	                                            [PenjualanId] [int] NOT NULL,
	                                            [ItemId] [int] NOT NULL,
	                                            [HargaBarang] [int] NOT NULL,
                                             CONSTRAINT [PK_dbo.DetailPenjualans] PRIMARY KEY CLUSTERED 
                                            (
	                                            [Id] ASC
                                            )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                                            ) ON [PRIMARY]";
                cmd.CommandText = tableDetailPenjualans;
                cmd.ExecuteNonQuery();

                string tableItems = @"CREATE TABLE [dbo].[Items](
	                                [Id] [int] IDENTITY(1,1) NOT NULL,
	                                [NamaItem] [varchar](255) NOT NULL,
	                                [KodeItem] [varchar](50) NOT NULL,
	                                [Stok] [int] NOT NULL,
	                                [Satuan] [varchar](10) NOT NULL,
	                                [HargaGrosir] [int] NOT NULL,
	                                [HargaEceran] [int] NOT NULL,
	                                [HargaJual] [int] NOT NULL,
	                                [SupplierId] [int] NOT NULL,
                                 CONSTRAINT [PK_dbo.Items] PRIMARY KEY CLUSTERED 
                                (
	                                [Id] ASC
                                )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                                ) ON [PRIMARY]";
                cmd.CommandText = tableItems;
                cmd.ExecuteNonQuery();

                string tablePelanggans = @"CREATE TABLE [dbo].[Pelanggans](
	                                    [Id] [int] IDENTITY(1,1) NOT NULL,
	                                    [Nama] [varchar](255) NOT NULL,
	                                    [KodePelanggan] [varchar](20) NOT NULL,
	                                    [NoHp] [varchar](30) NULL,
	                                    [Alamat] [nvarchar](500) NULL,
	                                    [Email] [varchar](255) NULL,
                                     CONSTRAINT [PK_dbo.Pelanggans] PRIMARY KEY CLUSTERED 
                                    (
	                                    [Id] ASC
                                    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                                    ) ON [PRIMARY]";
                cmd.CommandText = tablePelanggans;
                cmd.ExecuteNonQuery();

                string tablePembelians = @"CREATE TABLE [dbo].[Pembelians](
	                                    [Id] [int] IDENTITY(1,1) NOT NULL,
	                                    [NoTransaksi] [varchar](255) NULL,
	                                    [Tanggal] [datetime] NOT NULL,
	                                    [SupplierId] [int] NOT NULL,
	                                    [TotalHarga] [int] NOT NULL,
                                     CONSTRAINT [PK_dbo.Pembelians] PRIMARY KEY CLUSTERED 
                                    (
	                                    [Id] ASC
                                    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                                    ) ON [PRIMARY]
                                    ";
                cmd.CommandText = tablePembelians;
                cmd.ExecuteNonQuery();

                string tablePenjualans = @"CREATE TABLE [dbo].[Penjualans](
	                                    [Id] [int] IDENTITY(1,1) NOT NULL,
	                                    [NoTransaksi] [varchar](255) NULL,
	                                    [Tanggal] [datetime] NOT NULL,
	                                    [PelangganId] [int] NOT NULL,
	                                    [TotalHarga] [int] NOT NULL,
	                                    [IsPending] [bit] NOT NULL,
	                                    [Keterangan] [nvarchar](max) NULL,
                                     CONSTRAINT [PK_dbo.Penjualans] PRIMARY KEY CLUSTERED 
                                    (
	                                    [Id] ASC
                                    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                                    ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]";

                cmd.CommandText = tablePenjualans;
                cmd.ExecuteNonQuery();

                string tableSupplier = @"CREATE TABLE [dbo].[Suppliers](
	                                    [Id] [int] IDENTITY(1,1) NOT NULL,
	                                    [KodeSupplier] [varchar](20) NOT NULL,
	                                    [NamaSupplier] [varchar](255) NOT NULL,
	                                    [Alamat] [varchar](255) NULL,
	                                    [NoHP] [varchar](50) NULL,
	                                    [Email] [varchar](100) NULL,
                                     CONSTRAINT [PK_dbo.Suppliers] PRIMARY KEY CLUSTERED 
                                    (
	                                    [Id] ASC
                                    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                                    ) ON [PRIMARY]";
                cmd.CommandText = tableSupplier;
                cmd.ExecuteNonQuery();

                string alterTable = @"
                                    ALTER TABLE [dbo].[DetailPenjualans] ADD  DEFAULT ((0)) FOR [HargaBarang]
                                    ALTER TABLE [dbo].[Penjualans] ADD  DEFAULT ((0)) FOR [IsPending]
                                    ALTER TABLE [dbo].[DetailPembelians]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DetailPembelians_dbo.Items_ItemId] FOREIGN KEY([ItemId])
                                    REFERENCES [dbo].[Items] ([Id])
                                    ALTER TABLE [dbo].[DetailPembelians] CHECK CONSTRAINT [FK_dbo.DetailPembelians_dbo.Items_ItemId]
                                    ALTER TABLE [dbo].[DetailPembelians]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DetailPembelians_dbo.Pembelians_PembelianId] FOREIGN KEY([PembelianId])
                                    REFERENCES [dbo].[Pembelians] ([Id])
                                    ALTER TABLE [dbo].[DetailPembelians] CHECK CONSTRAINT [FK_dbo.DetailPembelians_dbo.Pembelians_PembelianId]
                                    ALTER TABLE [dbo].[DetailPenjualans]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DetailPenjualans_dbo.Items_ItemId] FOREIGN KEY([ItemId])
                                    REFERENCES [dbo].[Items] ([Id])
                                    ALTER TABLE [dbo].[DetailPenjualans] CHECK CONSTRAINT [FK_dbo.DetailPenjualans_dbo.Items_ItemId]
                                    ALTER TABLE [dbo].[DetailPenjualans]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DetailPenjualans_dbo.Penjualans_PenjualanId] FOREIGN KEY([PenjualanId])
                                    REFERENCES [dbo].[Penjualans] ([Id])
                                    ALTER TABLE [dbo].[DetailPenjualans] CHECK CONSTRAINT [FK_dbo.DetailPenjualans_dbo.Penjualans_PenjualanId]
                                    ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Items_dbo.Suppliers_SupplierId] FOREIGN KEY([SupplierId])
                                    REFERENCES [dbo].[Suppliers] ([Id])
                                    ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_dbo.Items_dbo.Suppliers_SupplierId]
                                    ALTER TABLE [dbo].[Pembelians]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Pembelians_dbo.Suppliers_SupplierId] FOREIGN KEY([SupplierId])
                                    REFERENCES [dbo].[Suppliers] ([Id])
                                    ON DELETE CASCADE
                                    ALTER TABLE [dbo].[Pembelians] CHECK CONSTRAINT [FK_dbo.Pembelians_dbo.Suppliers_SupplierId]
                                    ALTER TABLE [dbo].[Penjualans]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Penjualans_dbo.Pelanggans_PelangganId] FOREIGN KEY([PelangganId])
                                    REFERENCES [dbo].[Pelanggans] ([Id])
                                    ON DELETE CASCADE
                                    ALTER TABLE [dbo].[Penjualans] CHECK CONSTRAINT [FK_dbo.Penjualans_dbo.Pelanggans_PelangganId]
                                    ";

                cmd.CommandText = alterTable;
                cmd.ExecuteNonQuery();

                cn.Close();
            }
            MessageBox.Show("Berhasil membuat database baru", "Mumtaaz Herbal", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnamaDB.Text))
            {
                MessageBox.Show("Mohon isi nama database", "Mumtaaz Herbal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CreateDatabase();
            CreateTable();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}