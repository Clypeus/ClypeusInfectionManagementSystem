using Clypeus.Data.Model.Medicinals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations.MedicinalConfigurations
{
    public class NotifiableDiseaseOrganismConfiguration : IEntityTypeConfiguration<NotifiableDiseaseOrganism>
    {
        public void Configure(EntityTypeBuilder<NotifiableDiseaseOrganism> entity)
        {
            entity.ToTable("NotifiableDiseasesOrganisms", "Medicinals");

            entity.HasKey(ndc => new { ndc.NotifiableDiseaseId, ndc.OrganismId });

            entity.HasOne(bc => bc.Organism)
            .WithMany(b => b.NotifiableDiseaseOrganisms)
            .HasForeignKey(bc => bc.OrganismId);
            
            entity.HasOne(bc => bc.NotifiableDisease)
                .WithMany(c => c.NotifiableDiseaseOrganisms)
                .HasForeignKey(bc => bc.NotifiableDiseaseId);
        }
    }
}
