using System.Data.Entity.ModelConfiguration;

namespace MumtaazHerbal.EntityConfig
{
    public class KasKeluarConfiguration : EntityTypeConfiguration<KasKeluar>
    {
        public KasKeluarConfiguration()
        {
            ToTable("KasKeluars");

            HasKey(p => p.Id);

            Property(p => p.NoTransaksi)
                .HasColumnType("varchar")
                .HasMaxLength(255);
            
        }
    }

}
