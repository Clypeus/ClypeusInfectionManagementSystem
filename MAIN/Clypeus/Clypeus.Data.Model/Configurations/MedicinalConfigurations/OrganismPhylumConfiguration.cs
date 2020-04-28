using Clypeus.Data.Model.Medicinals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations.Medicinals
{
    class OrganismPhylumConfiguration : IEntityTypeConfiguration<OrganismPhylum>
    {

        public void Configure(EntityTypeBuilder<OrganismPhylum> entity)
        {
            entity.ToTable("OrganismPhylum", "Medicinals");

            entity.Property(e => e.Description)
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Updated).HasColumnType("datetime");
        }
    }
}
