using Clypeus.Data.Model.Specimens;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations.SensitivityConfigurations
{
    public class SpecimenConfiguration : IEntityTypeConfiguration<Specimen>
    {
        public void Configure(EntityTypeBuilder<Specimen> entity)
        {
            entity.ToTable("Specimen", "Specimens");

            entity.Property(e => e.Requested).HasColumnType("datetime");

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            
        }
    }
}
