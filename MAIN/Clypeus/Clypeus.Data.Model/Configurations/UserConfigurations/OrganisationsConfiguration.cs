using Clypeus.Data.Model.Medicinals;
using Clypeus.Data.Model.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations.Users
{
    public class OrganisationsConfiguration : IEntityTypeConfiguration<Organisation>
    {
        public void Configure(EntityTypeBuilder<Organisation> entity)
        {
            entity.ToTable("Organisation", "users");

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
                .WithMany(p =>p.Organisations)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("FK_Address_ToOrganisation");

            entity.HasOne(d => d.ParentOrganisation)
               .WithMany(p => p.Organisations)
               .HasForeignKey(d => d.ParentOrganisationId)
               .HasConstraintName("FK_Organisation_ToOrganisations");
        }   
    }
}
