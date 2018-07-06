using System.Data.Entity.ModelConfiguration;

namespace MumtaazHerbal.EntityConfig
{
    public class DetailPenjualanConfiguration : EntityTypeConfiguration<DetailPenjualan>
    {
        public DetailPenjualanConfiguration()
        {
            ToTable("DetailPenjualans");

            HasKey(c => c.Id);

            HasRequired(c => c.Penjualan)
                .WithMany(s => s.DetailPenjualans)
                .HasForeignKey(c => c.PenjualanId)
                .WillCascadeOnDelete(false);

            HasRequired(c => c.Item)
                .WithMany(s => s.DetailPenjualans)
                .HasForeignKey(c => c.ItemId)
                .WillCascadeOnDelete(false);

            
        }
    }

    public class DetailPembelianConfiguration : EntityTypeConfiguration<DetailPembelian>
    {
        public DetailPembelianConfiguration()
        {
            ToTable("DetailPembelians");

            HasKey(c => c.Id);

            HasRequired(c => c.Pembelian)
                .WithMany(s => s.DetailPembelians)
                .HasForeignKey(c => c.PembelianId)
                .WillCascadeOnDelete(false);

            HasRequired(c => c.Item)
                .WithMany(s => s.DetailPembelians)
                .HasForeignKey(c => c.ItemId)
                .WillCascadeOnDelete(false);


        }
    }

}
