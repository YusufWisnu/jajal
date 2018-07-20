using System.Data.Entity.ModelConfiguration;

namespace MumtaazHerbal.EntityConfig
{
    public class DetailKasKeluarConfiguration : EntityTypeConfiguration<DetailKasKeluar>
    {
        public DetailKasKeluarConfiguration()
        {
            ToTable("DetailKasKeluars");

            HasRequired(p => p.KasKeluar)
                .WithMany(c => c.DetailKasKeluars)
                .HasForeignKey(p => p.KaskeluarId)
                .WillCascadeOnDelete(false);

            Property(p => p.Keterangan)
                .HasColumnType("varchar")
                .HasMaxLength(255);
        }

    }

}
