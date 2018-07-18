using System.Data.Entity.ModelConfiguration;

namespace MumtaazHerbal.EntityConfig
{
    public class PiutangConfiguration : EntityTypeConfiguration<Piutang>
    {
        public PiutangConfiguration()
        {
            ToTable("Piutangs");

            Property(p => p.NoTransaksi)
                .HasColumnType("varchar")
                .HasMaxLength(255);

            HasRequired(p => p.Pelanggan)
                .WithMany(c => c.Piutangs)
                .HasForeignKey(p => p.PelangganId)
                .WillCascadeOnDelete(false);
        }
    }

}
