using Clypeus.Data.Model.Medicinals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations.Medicinals
{
    public class OrganismsConfiguration : IEntityTypeConfiguration<Organisms>
    {
        public void Configure(EntityTypeBuilder<Organisms> entity)
        {
            entity.ToTable("Organisms", "medicinals");

            entity.HasKey(e =>e.Id);

            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.Property(e => e.Species)
                .HasMaxLength(125)
                .IsUnicode(false);

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.HasOne(d => d.OrganismGenus)
                .WithMany(p => p.Organisms)
                .HasForeignKey(d => d.OrganismGenusId)
                .HasConstraintName("FK_Organisms_ToOrganismTypes");

            entity.HasOne(d => d.OrganismKingdom)
                .WithMany(p => p.Organisms)
                .HasForeignKey(d => d.OrganismKingdomId)
                .HasConstraintName("FK_Organisms_ToOrganismKingdom");

            entity.HasOne(d => d.OrganismPhylum)
               .WithMany(p => p.Organisms)
               .HasForeignKey(d => d.OrganismPhylumId)
               .HasConstraintName("FK_Organisms_ToOrganismPhylum");

            entity.HasOne(d => d.OrganismFamily)
             .WithMany(p => p.Organisms)
             .HasForeignKey(d => d.OrganismFamilyId)
             .HasConstraintName("FK_Organisms_ToOrganismFamily");

            entity.HasOne(d => d.OrganismClass)
              .WithMany(p => p.Organisms)
            .HasForeignKey(d => d.OrganismClassId)
           .HasConstraintName("FK_Organisms_ToOrganismClass");

            entity.HasOne(d => d.OrganismOrder)
         .WithMany(p => p.Organisms)
         .HasForeignKey(d => d.OrganismOrderId)
         .HasConstraintName("FK_Organisms_ToOrganismOrder");

        }
    }
}
