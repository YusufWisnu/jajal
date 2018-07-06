using System.Data.Entity.ModelConfiguration;

namespace MumtaazHerbal.EntityConfig
{
    public class PembelianConfiguration: EntityTypeConfiguration<Pembelian>
    {
        public PembelianConfiguration()
        {
            ToTable("Pembelians");

            HasKey(p => p.Id);

            //HasMany(p => p.DetailPenjualans)
            //    .WithRequired(c => c.Penjualan)

            HasRequired(p => p.Supplier)
                .WithMany(c => c.Pembelians)
                .HasForeignKey(p => p.SupplierId);

            Property(p => p.NoTransaksi)
                .HasColumnType("varchar")
                .HasMaxLength(255);

        }
    }

}
