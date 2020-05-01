using Clypeus.Data.Model.Specimens;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations.SensitivityConfigurations
{
    public class SpecimenSensitivityConfiguration : IEntityTypeConfiguration<SpecimenSensitivity>
    {
        public void Configure(EntityTypeBuilder<SpecimenSensitivity> entity)
        {
            entity.ToTable("SpecimenSensitivity", "Specimens");

            entity.HasKey(d => new { d.SpecimenId,d.OrganismId, d.DrugId });

            entity.HasOne(d => d.Sensitivity)
                .WithMany(p => p.SpecimenSensitivity)
                .HasForeignKey(d => d.SensitivityId)
                .HasConstraintName("FK_Sensitivity_SpecimenSensitivity");

            entity.HasOne(d => d.Drug)
               .WithMany(p => p.SpecimenSensitivity)
               .HasForeignKey(d => d.DrugId)
               .HasConstraintName("FK_Drug_SpecimenSensitivity");

            entity.HasOne(d => d.Organism)
             .WithMany(p => p.SpecimenSensitivity)
             .HasForeignKey(d => d.OrganismId)
             .HasConstraintName("FK_Organism_SpecimenSensitivity");

            entity.HasOne(d => d.Specimen)
            .WithMany(p => p.SpecimenSensitivity)
            .HasForeignKey(d => d.SpecimenId)
            .HasConstraintName("FK_Specimen_SpecimenSensitivity");
        }
    }
}
