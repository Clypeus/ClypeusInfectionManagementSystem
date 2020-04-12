using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations
{
    public class OrganisationsConfiguration : IEntityTypeConfiguration<Organisation>
    {
        public void Configure(EntityTypeBuilder<Organisation> entity)
        {
            entity.ToTable("Organisation", "users");

            entity.Property(e => e.AddressLine1)
                .IsRequired()
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine2)
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false);

            entity.Property(e => e.AddressLine3)
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false);

            entity.Property(e => e.AddressLine4)
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false);

            entity.Property(e => e.AddressLine5)
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false);

            entity.Property(e => e.Name)
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

            entity.Property(e => e.TelephoneNumber)
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false);
        }
           
    }
}
