using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace MumtaazHerbal.EntityConfig
{

    public class ItemConfiguration : EntityTypeConfiguration<Item>
    {
        public ItemConfiguration()
        {
            ToTable("Items");

            HasKey(c => c.Id);

            HasRequired(c => c.Supplier)
                .WithMany(s => s.Items)
                .HasForeignKey(c => c.SupplierId)
                .WillCascadeOnDelete(false);

            Property(c => c.Satuan)
                .HasColumnType("varchar")
                .HasMaxLength(10)
                .IsRequired();


            Property(c => c.KodeItem)
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.NamaItem)
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(255);                

        }
    }
}
