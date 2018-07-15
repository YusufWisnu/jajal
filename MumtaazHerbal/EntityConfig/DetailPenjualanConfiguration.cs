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

}
