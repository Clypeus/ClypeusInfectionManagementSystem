using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations
{
    public class OrganismFamilyConfiguration : IEntityTypeConfiguration<OrganismFamily>
    {
        public void Configure(EntityTypeBuilder<OrganismFamily> entity)
        {
            entity.ToTable("OrganismFamily", "medicinals");

            entity.Property(e => e.Description)
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Updated).HasColumnType("datetime");
        }
    }
}
