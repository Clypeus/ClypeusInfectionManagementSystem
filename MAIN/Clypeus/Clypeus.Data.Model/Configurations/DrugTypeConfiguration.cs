using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations
{
    public class DrugTypeConfiguration : IEntityTypeConfiguration<DrugTypes>
    {
        public void Configure(EntityTypeBuilder<DrugTypes> entity)
        {
            entity.ToTable("DrugTypes", "medicinals");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Updated).HasColumnType("datetime");
        }
    }
}
