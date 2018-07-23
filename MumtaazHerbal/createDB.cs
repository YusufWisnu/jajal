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
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                //try
                //{
                    cmd = new SqlCommand();
                    cn.Open();
                    cmd.Connection = cn;

                    string namaDatabase = string.Format("create database {0}", txtnamaDB.Text);
                    cmd.CommandText = namaDatabase;
                    cmd.ExecuteNonQuery();
                    cn.Close();
                //}
                //catch(Exception ee)
                //{
                //    MessageBox.Show("Silahkan isi nama database dengan benar", "Mumtaaz Herbal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                
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

                //string dbName = string.Format("use {0}", txtnamaDB.Text);
                //cmd.CommandText = dbName;
                //cmd.ExecuteNonQuery();

                //string tableDetailPembelians = @"CREATE TABLE [dbo].[DetailPembelians](
                //                                 [Id] [int] IDENTITY(1,1) NOT NULL,
                //                                 [JumlahBarang] [int] NOT NULL,
                //                                 [HargaBarang] [int] NOT NULL,
                //                                 [PembelianId] [int] NOT NULL,
                //                                 [ItemId] [int] NOT NULL,
                //                                 CONSTRAINT [PK_dbo.DetailPembelians] PRIMARY KEY CLUSTERED 
                //                                (
                //                                 [Id] ASC
                //                                )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                //                                ) ON [PRIMARY]
                //                                ";
                //cmd.CommandText = tableDetailPembelians;
                //cmd.ExecuteNonQuery();

                //string tableDetailPenjualans = @"CREATE TABLE [dbo].[DetailPenjualans](
                //                             [Id] [int] IDENTITY(1,1) NOT NULL,
                //                             [JumlahBarang] [int] NOT NULL,
                //                             [PenjualanId] [int] NOT NULL,
                //                             [ItemId] [int] NOT NULL,
                //                             [HargaBarang] [int] NOT NULL,
                //                             CONSTRAINT [PK_dbo.DetailPenjualans] PRIMARY KEY CLUSTERED 
                //                            (
                //                             [Id] ASC
                //                            )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                //                            ) ON [PRIMARY]";
                //cmd.CommandText = tableDetailPenjualans;
                //cmd.ExecuteNonQuery();

                //string tableItems = @"CREATE TABLE [dbo].[Items](
                //                 [Id] [int] IDENTITY(1,1) NOT NULL,
                //                 [NamaItem] [varchar](255) NOT NULL,
                //                 [KodeItem] [varchar](50) NOT NULL,
                //                 [Stok] [int] NOT NULL,
                //                 [Satuan] [varchar](10) NOT NULL,
                //                 [HargaGrosir] [int] NOT NULL,
                //                 [HargaEceran] [int] NOT NULL,
                //                 [HargaJual] [int] NOT NULL,
                //                 [SupplierId] [int] NOT NULL,
                //                 CONSTRAINT [PK_dbo.Items] PRIMARY KEY CLUSTERED 
                //                (
                //                 [Id] ASC
                //                )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                //                ) ON [PRIMARY]";
                //cmd.CommandText = tableItems;
                //cmd.ExecuteNonQuery();

                //string tablePelanggans = @"CREATE TABLE [dbo].[Pelanggans](
                //                     [Id] [int] IDENTITY(1,1) NOT NULL,
                //                     [Nama] [varchar](255) NOT NULL,
                //                     [KodePelanggan] [varchar](20) NOT NULL,
                //                     [NoHp] [varchar](30) NULL,
                //                     [Alamat] [nvarchar](500) NULL,
                //                     [Email] [varchar](255) NULL,
                //                     CONSTRAINT [PK_dbo.Pelanggans] PRIMARY KEY CLUSTERED 
                //                    (
                //                     [Id] ASC
                //                    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                //                    ) ON [PRIMARY]";
                //cmd.CommandText = tablePelanggans;
                //cmd.ExecuteNonQuery();

                //string tablePembelians = @"CREATE TABLE [dbo].[Pembelians](
                //                     [Id] [int] IDENTITY(1,1) NOT NULL,
                //                     [NoTransaksi] [varchar](255) NULL,
                //                     [Tanggal] [datetime] NOT NULL,
                //                     [SupplierId] [int] NOT NULL,
                //                     [TotalHarga] [int] NOT NULL,
                //                     CONSTRAINT [PK_dbo.Pembelians] PRIMARY KEY CLUSTERED 
                //                    (
                //                     [Id] ASC
                //                    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                //                    ) ON [PRIMARY]
                //                    ";
                //cmd.CommandText = tablePembelians;
                //cmd.ExecuteNonQuery();

                //string tablePenjualans = @"CREATE TABLE [dbo].[Penjualans](
                //                     [Id] [int] IDENTITY(1,1) NOT NULL,
                //                     [NoTransaksi] [varchar](255) NULL,
                //                     [Tanggal] [datetime] NOT NULL,
                //                     [PelangganId] [int] NOT NULL,
                //                     [TotalHarga] [int] NOT NULL,
                //                     [IsPending] [bit] NOT NULL,
                //                     [Keterangan] [nvarchar](max) NULL,
                //                     CONSTRAINT [PK_dbo.Penjualans] PRIMARY KEY CLUSTERED 
                //                    (
                //                     [Id] ASC
                //                    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                //                    ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]";

                //cmd.CommandText = tablePenjualans;
                //cmd.ExecuteNonQuery();

                //string tableSupplier = @"CREATE TABLE [dbo].[Suppliers](
                //                     [Id] [int] IDENTITY(1,1) NOT NULL,
                //                     [KodeSupplier] [varchar](20) NOT NULL,
                //                     [NamaSupplier] [varchar](255) NOT NULL,
                //                     [Alamat] [varchar](255) NULL,
                //                     [NoHP] [varchar](50) NULL,
                //                     [Email] [varchar](100) NULL,
                //                     CONSTRAINT [PK_dbo.Suppliers] PRIMARY KEY CLUSTERED 
                //                    (
                //                     [Id] ASC
                //                    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                //                    ) ON [PRIMARY]";
                //cmd.CommandText = tableSupplier;
                //cmd.ExecuteNonQuery();

                //string alterTable = @"
                //                    ALTER TABLE [dbo].[DetailPenjualans] ADD  DEFAULT ((0)) FOR [HargaBarang]
                //                    ALTER TABLE [dbo].[Penjualans] ADD  DEFAULT ((0)) FOR [IsPending]
                //                    ALTER TABLE [dbo].[DetailPembelians]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DetailPembelians_dbo.Items_ItemId] FOREIGN KEY([ItemId])
                //                    REFERENCES [dbo].[Items] ([Id])
                //                    ALTER TABLE [dbo].[DetailPembelians] CHECK CONSTRAINT [FK_dbo.DetailPembelians_dbo.Items_ItemId]
                //                    ALTER TABLE [dbo].[DetailPembelians]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DetailPembelians_dbo.Pembelians_PembelianId] FOREIGN KEY([PembelianId])
                //                    REFERENCES [dbo].[Pembelians] ([Id])
                //                    ALTER TABLE [dbo].[DetailPembelians] CHECK CONSTRAINT [FK_dbo.DetailPembelians_dbo.Pembelians_PembelianId]
                //                    ALTER TABLE [dbo].[DetailPenjualans]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DetailPenjualans_dbo.Items_ItemId] FOREIGN KEY([ItemId])
                //                    REFERENCES [dbo].[Items] ([Id])
                //                    ALTER TABLE [dbo].[DetailPenjualans] CHECK CONSTRAINT [FK_dbo.DetailPenjualans_dbo.Items_ItemId]
                //                    ALTER TABLE [dbo].[DetailPenjualans]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DetailPenjualans_dbo.Penjualans_PenjualanId] FOREIGN KEY([PenjualanId])
                //                    REFERENCES [dbo].[Penjualans] ([Id])
                //                    ALTER TABLE [dbo].[DetailPenjualans] CHECK CONSTRAINT [FK_dbo.DetailPenjualans_dbo.Penjualans_PenjualanId]
                //                    ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Items_dbo.Suppliers_SupplierId] FOREIGN KEY([SupplierId])
                //                    REFERENCES [dbo].[Suppliers] ([Id])
                //                    ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_dbo.Items_dbo.Suppliers_SupplierId]
                //                    ALTER TABLE [dbo].[Pembelians]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Pembelians_dbo.Suppliers_SupplierId] FOREIGN KEY([SupplierId])
                //                    REFERENCES [dbo].[Suppliers] ([Id])
                //                    ON DELETE CASCADE
                //                    ALTER TABLE [dbo].[Pembelians] CHECK CONSTRAINT [FK_dbo.Pembelians_dbo.Suppliers_SupplierId]
                //                    ALTER TABLE [dbo].[Penjualans]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Penjualans_dbo.Pelanggans_PelangganId] FOREIGN KEY([PelangganId])
                //                    REFERENCES [dbo].[Pelanggans] ([Id])
                //                    ON DELETE CASCADE
                //                    ALTER TABLE [dbo].[Penjualans] CHECK CONSTRAINT [FK_dbo.Penjualans_dbo.Pelanggans_PelangganId]
                //                    ";

                string query = @"CREATE TABLE [dbo].[DetailKasKeluars](
	                            [Id] [int] IDENTITY(1,1) NOT NULL,
	                            [KaskeluarId] [int] NOT NULL,
	                            [Total] [int] NOT NULL,
	                            [Keterangan] [nvarchar](max) NULL,
                             CONSTRAINT [PK_dbo.DetailKasKeluars] PRIMARY KEY CLUSTERED 
                            (
	                            [Id] ASC
                            )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                            ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

                            CREATE TABLE [dbo].[DetailPembelians](
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

                            CREATE TABLE [dbo].[DetailPenjualans](
	                            [Id] [int] IDENTITY(1,1) NOT NULL,
	                            [JumlahBarang] [int] NOT NULL,
	                            [PenjualanId] [int] NOT NULL,
	                            [ItemId] [int] NOT NULL,
	                            [HargaBarang] [int] NOT NULL,
	                            [Untung] [int] NOT NULL,
                             CONSTRAINT [PK_dbo.DetailPenjualans] PRIMARY KEY CLUSTERED 
                            (
	                            [Id] ASC
                            )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                            ) ON [PRIMARY]

                            CREATE TABLE [dbo].[DetailPiutangs](
	                            [Id] [int] IDENTITY(1,1) NOT NULL,
	                            [PiutangId] [int] NOT NULL,
	                            [PenjualanId] [int] NOT NULL,
	                            [JumlahBayar] [int] NOT NULL,
	                            [Sisa] [int] NOT NULL,
                             CONSTRAINT [PK_dbo.DetailPiutangs] PRIMARY KEY CLUSTERED 
                            (
	                            [Id] ASC
                            )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                            ) ON [PRIMARY]

                            CREATE TABLE [dbo].[Items](
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
                            ) ON [PRIMARY]

                            CREATE TABLE [dbo].[KasKeluars](
	                            [Id] [int] IDENTITY(1,1) NOT NULL,
	                            [NoTransaksi] [varchar](255) NOT NULL,
	                            [Tanggal] [datetime] NOT NULL,
	                            [Total] [int] NOT NULL,
	                            [Keterangan] [varchar](255) NOT NULL,
                             CONSTRAINT [PK_dbo.KasKeluars] PRIMARY KEY CLUSTERED 
                            (
	                            [Id] ASC
                            )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                            ) ON [PRIMARY]

                            CREATE TABLE [dbo].[Pelanggans](
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
                            ) ON [PRIMARY]

                            CREATE TABLE [dbo].[Pembelians](
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

                            CREATE TABLE [dbo].[Penjualans](
	                            [Id] [int] IDENTITY(1,1) NOT NULL,
	                            [NoTransaksi] [varchar](255) NULL,
	                            [Tanggal] [datetime] NOT NULL,
	                            [PelangganId] [int] NOT NULL,
	                            [TotalHarga] [int] NOT NULL,
	                            [IsPending] [bit] NOT NULL,
	                            [Keterangan] [nvarchar](max) NULL,
	                            [Sisa] [int] NOT NULL,
	                            [TanggalJT] [datetime] NULL,
	                            [SubTotal] [int] NOT NULL,
                             CONSTRAINT [PK_dbo.Penjualans] PRIMARY KEY CLUSTERED 
                            (
	                            [Id] ASC
                            )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                            ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

                            CREATE TABLE [dbo].[Piutangs](
	                            [Id] [int] IDENTITY(1,1) NOT NULL,
	                            [NoTransaksi] [varchar](255) NULL,
	                            [Total] [int] NOT NULL,
	                            [Tanggal] [datetime] NOT NULL,
	                            [PelangganId] [int] NULL,
                             CONSTRAINT [PK_dbo.Piutangs] PRIMARY KEY CLUSTERED 
                            (
	                            [Id] ASC
                            )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                            ) ON [PRIMARY]

                            CREATE TABLE [dbo].[Suppliers](
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
                            ) ON [PRIMARY]

                            SET ANSI_PADDING OFF
                            ALTER TABLE [dbo].[DetailPenjualans] ADD  DEFAULT ((0)) FOR [HargaBarang]
                            ALTER TABLE [dbo].[DetailPenjualans] ADD  DEFAULT ((0)) FOR [Untung]
                            ALTER TABLE [dbo].[DetailPiutangs] ADD  DEFAULT ((0)) FOR [Sisa]
                            ALTER TABLE [dbo].[KasKeluars] ADD  DEFAULT ((0)) FOR [Total]
                            ALTER TABLE [dbo].[KasKeluars] ADD  DEFAULT ('') FOR [Keterangan]
                            ALTER TABLE [dbo].[Penjualans] ADD  DEFAULT ((0)) FOR [IsPending]
                            ALTER TABLE [dbo].[Penjualans] ADD  DEFAULT ((0)) FOR [Sisa]
                            ALTER TABLE [dbo].[Penjualans] ADD  DEFAULT ('1900-01-01T00:00:00.000') FOR [TanggalJT]
                            ALTER TABLE [dbo].[Penjualans] ADD  DEFAULT ((0)) FOR [SubTotal]
                            ALTER TABLE [dbo].[DetailKasKeluars]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DetailKasKeluars_dbo.KasKeluars_KaskeluarId] FOREIGN KEY([KaskeluarId])
                            REFERENCES [dbo].[KasKeluars] ([Id])
                            ON DELETE CASCADE
                            ALTER TABLE [dbo].[DetailKasKeluars] CHECK CONSTRAINT [FK_dbo.DetailKasKeluars_dbo.KasKeluars_KaskeluarId]
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
                            ALTER TABLE [dbo].[DetailPiutangs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DetailPiutangs_dbo.Penjualans_PenjualanId] FOREIGN KEY([PenjualanId])
                            REFERENCES [dbo].[Penjualans] ([Id])
                            ON DELETE CASCADE
                            ALTER TABLE [dbo].[DetailPiutangs] CHECK CONSTRAINT [FK_dbo.DetailPiutangs_dbo.Penjualans_PenjualanId]
                            ALTER TABLE [dbo].[DetailPiutangs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DetailPiutangs_dbo.Piutangs_PiutangId] FOREIGN KEY([PiutangId])
                            REFERENCES [dbo].[Piutangs] ([Id])
                            ALTER TABLE [dbo].[DetailPiutangs] CHECK CONSTRAINT [FK_dbo.DetailPiutangs_dbo.Piutangs_PiutangId]
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
                            ALTER TABLE [dbo].[Piutangs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Piutangs_dbo.Pelanggans_PelangganId] FOREIGN KEY([PelangganId])
                            REFERENCES [dbo].[Pelanggans] ([Id])
                            ALTER TABLE [dbo].[Piutangs] CHECK CONSTRAINT [FK_dbo.Piutangs_dbo.Pelanggans_PelangganId]
                            ";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string insertUMUM = @"INSERT INTO Pelanggans (Nama,KodePelanggan) VALUES ('UMUM','UMUM')";
                cmd.CommandText = insertUMUM;
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

            try
            {
                CreateDatabase();
                CreateTable();
            }
            
            catch(Exception ee)
            {
                MessageBox.Show("Silahkan isi nama database dengan benar", "Mumtaaz Herbal", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}