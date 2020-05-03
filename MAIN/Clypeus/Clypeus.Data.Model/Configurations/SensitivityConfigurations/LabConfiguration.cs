using Clypeus.Data.Model.Geography;
using Clypeus.Data.Model.Organisations;
using Clypeus.Data.Model.Specimens;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations.SensitivityConfigurations
{
    public class LabConfiguration : IEntityTypeConfiguration<Lab>
    {
        public void Configure(EntityTypeBuilder<Lab> entity)
        {
            entity.ToTable("Lab", "Specimens");

            entity.Property(e => e.ContactName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ContactEmail)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ContactTelephone)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(e => e.Address)
                .WithOne(e => e.Lab)
                .HasForeignKey<Lab>(e => e.AddressId);

            entity.HasOne(e => e.HealthCareOrganisation)
                .WithMany(e => e.Labs)
                .HasForeignKey(e => e.HealthCareOrganisationId);
        }
    }
}
