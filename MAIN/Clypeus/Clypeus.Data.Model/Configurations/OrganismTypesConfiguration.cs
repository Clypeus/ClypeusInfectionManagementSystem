using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations
{
    public class OrganismTypesConfiguration : IEntityTypeConfiguration<OrganismGenus>
    {
        public void Configure(EntityTypeBuilder<OrganismGenus> entity)
        {
            entity.ToTable("OrganismTypes", "medicinals");

            entity.Property(e => e.Description)
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Updated).HasColumnType("datetime");
        }
    }
}
