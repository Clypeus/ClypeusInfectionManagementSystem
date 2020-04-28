using Clypeus.Data.Model.Medicinals;
using Clypeus.Data.Model.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations.Users
{
    public class SystemOrganisationConfiguration : IEntityTypeConfiguration<SystemOrganisations>
    {
        public void Configure(EntityTypeBuilder<SystemOrganisations> entity)
        {
            entity.ToTable("SystemOrganisation", "SystemUsers");

            entity.Property(e => e.Name)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

            entity.Property(e => e.Name)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

            entity.Property(e => e.TelephoneNumber)
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false);

            entity.HasOne(d => d.Address)
                .WithMany(p =>p.SystemOrganisations)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("FK_Address_ToOrganisation");
        }   
    }
}
