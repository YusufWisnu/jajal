

using MumtaazHerbal.EntityConfig;
using System.Data.Entity;

namespace MumtaazHerbal
{
    public class MumtaazContext : DbContext
    {

        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Pelanggan> Pelanggans { get; set; }
        public virtual DbSet<Penjualan> Penjualan { get; set; }
        public virtual DbSet<DetailPenjualan> DetailPenjualans { get; set; }
        public virtual DbSet<Pembelian> Pembelians { get; set; }
        public virtual DbSet<DetailPembelian> DetailPembelians { get; set; }
        public virtual DbSet<Piutang> Piutangs { get; set; }
        public virtual DbSet<DetailPiutang> DetailPiutangs { get; set; }

        public MumtaazContext(string _connectionString)
            :base(_connectionString)
        {

        }

        public MumtaazContext()
            : base("name=MumtaazFix")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ItemConfiguration());
            modelBuilder.Configurations.Add(new SupplierConfiguration());
            modelBuilder.Configurations.Add(new PelangganConfiguration());
            modelBuilder.Configurations.Add(new PenjualanConfiguration());
            modelBuilder.Configurations.Add(new DetailPenjualanConfiguration());
            modelBuilder.Configurations.Add(new PembelianConfiguration());
            modelBuilder.Configurations.Add(new DetailPembelianConfiguration());
            modelBuilder.Configurations.Add(new PiutangConfiguration());
            modelBuilder.Configurations.Add(new DetailPiutangConfiguration());

        }

    }
}
