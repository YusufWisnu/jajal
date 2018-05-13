

using MumtaazHerbal.EntityConfig;
using System.Data.Entity;

namespace MumtaazHerbal
{
    public class MumtaazContext : DbContext
    {

        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Pelanggan> Pelanggans { get; set; }

        public MumtaazContext()
            :base("name=MumtaazFix")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ItemConfiguration());
            modelBuilder.Configurations.Add(new SupplierConfiguration());
            modelBuilder.Configurations.Add(new PelangganConfiguration());
        }

    }
}
