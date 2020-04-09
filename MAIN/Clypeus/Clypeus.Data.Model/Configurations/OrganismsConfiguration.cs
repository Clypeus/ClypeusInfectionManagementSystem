using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations
{
    public class OrganismsConfiguration : IEntityTypeConfiguration<Organisms>
    {
        public void Configure(EntityTypeBuilder<Organisms> entity)
        {
            entity.ToTable("Organisms", "medicinals");

            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.HasOne(d => d.OrganismType)
                .WithMany(p => p.Organisms)
                .HasForeignKey(d => d.OrganismTypeId)
                .HasConstraintName("FK_Organisms_ToOrganismTypes");

        }
    }
}
