using System.Data.Entity.ModelConfiguration;

namespace MumtaazHerbal.EntityConfig
{
    public class DetailPiutangConfiguration : EntityTypeConfiguration<DetailPiutang>
    {
        public DetailPiutangConfiguration()
        {
            ToTable("DetailPiutangs");

            HasKey(p => p.Id);

            HasRequired(p => p.Penjualan)
                .WithMany(c => c.DetailPiutangs)
                .HasForeignKey(p => p.PenjualanId);
                //.WillCascadeOnDelete(/*false*/);


            HasRequired(p => p.Piutang)
                .WithMany(c => c.DetailPiutangs)
                .HasForeignKey(p => p.PiutangId)
                .WillCascadeOnDelete(false);


        }
    }

}
