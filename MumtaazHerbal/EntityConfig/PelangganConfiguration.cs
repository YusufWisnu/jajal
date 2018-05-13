using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace MumtaazHerbal.EntityConfig
{
    public class PelangganConfiguration : EntityTypeConfiguration<Pelanggan>
    {
        public PelangganConfiguration()
        {
            ToTable("Pelanggans");

            HasKey(p => p.Id);

            Property(p => p.Nama)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            Property(p => p.KodePelanggan)
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired();

            Property(p => p.NoHp)
                .HasColumnType("varchar")
                .HasMaxLength(30);

            Property(p => p.Email)
                .HasColumnType("varchar")
                .HasMaxLength(255);

            Property(p => p.Alamat)
                .HasMaxLength(500);
                

        }
    }
}
