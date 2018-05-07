using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace MumtaazHerbal.EntityConfig
{
    public class SupplierConfiguration : EntityTypeConfiguration<Supplier>
    {
        public SupplierConfiguration()
        {

            ToTable("Suppliers");

            HasKey(c => c.Id);
            

            Property(c => c.NamaSupplier)
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(255);

            Property(c => c.KodeSupplier)
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(20);

            Property(c => c.Alamat)
                .HasColumnType("varchar")
                .HasMaxLength(255);

            Property(c => c.Email)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            Property(c => c.NoHP)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            

        }
    }
}
