using Clypeus.Data.Model.Organisations;
using Clypeus.Data.Model.Specimens;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations.Organisations
{
    public class HealthCareOrganisationConfiguration : IEntityTypeConfiguration<HealthCareOrganisation>
    {
        public void Configure(EntityTypeBuilder<HealthCareOrganisation> entity)
        {
            entity.ToTable("HealthCareOrganisation", "Organisations");

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
                .WithMany(e => e.HealthCareOrganisations)
                .HasForeignKey(e => e.AddressId);

            entity.HasOne(t => t.Parent)
                .WithMany(t=>t.Children)
                .HasForeignKey(d => d.ParentId);
        }
    }
}
