using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace MumtaazHerbal.EntityConfig
{
    public class PenjualanConfiguration : EntityTypeConfiguration<Penjualan>
    {
        public PenjualanConfiguration()
        {
            ToTable("Penjualans");

            HasKey(p => p.Id);

            //HasMany(p => p.DetailPenjualans)
            //    .WithRequired(c => c.Penjualan)

            HasRequired(p => p.Pelanggan)
                .WithMany(c => c.Penjualans)
                .HasForeignKey(p => p.PelangganId);

            Property(p => p.NoTransaksi)
                .HasColumnType("varchar")
                .HasMaxLength(255);

            Property(p => p.TanggalJT)
                .IsOptional();

            //Property(p => p.PiutangId)
            //    .IsOptional();

            //HasRequired(p => p.Piutang)
            //    .WithMany(c => c.Penjualans)
            //    .HasForeignKey(p => p.PiutangId)
            //    .WillCascadeOnDelete(false);

        }
    }

}
