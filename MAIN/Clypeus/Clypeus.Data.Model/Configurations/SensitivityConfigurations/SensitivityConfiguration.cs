using Clypeus.Data.Model.Medicinals;
using Clypeus.Data.Model.Specimens;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations.SensitivityConfigurations
{
    public class SensitivityConfiguration : IEntityTypeConfiguration<Sensitivity>
    {
        public void Configure(EntityTypeBuilder<Sensitivity> entity)
        {
            entity.ToTable("Sensitivity", "Specimens");

            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasMaxLength(25)
                .IsUnicode(false);
        }
    }
}
