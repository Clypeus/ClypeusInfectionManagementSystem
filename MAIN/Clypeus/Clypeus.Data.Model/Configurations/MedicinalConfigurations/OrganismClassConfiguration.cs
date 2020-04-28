using Clypeus.Data.Model.Medicinals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations.Medicinals
{
    public class OrganismClassConfiguration : IEntityTypeConfiguration<OrganismClass>
    {
        public void Configure(EntityTypeBuilder<OrganismClass> entity)
        {
            entity.ToTable("OrganismClass", "Medicinals");

            entity.Property(e => e.Description)
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Updated).HasColumnType("datetime");
        }
    }
}
