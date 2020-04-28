using Clypeus.Data.Model.Organisations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations.Organisations
{
    public class PrimaryCarePracticeConfiguration : IEntityTypeConfiguration<PrimaryCarePractice>
    {
        public void Configure(EntityTypeBuilder<PrimaryCarePractice> entity)
        {
            entity.ToTable("PrimaryCarePractice", "Organisations");

            entity.Property(e => e.Code)
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false);

            entity.Property(e => e.LongCode)
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

            entity.Property(e => e.Name)
                        .IsRequired()
                        .HasMaxLength(75)
                        .IsUnicode(false);

            entity.Property(e => e.TelephoneNumber)
                       .IsRequired()
                       .HasMaxLength(25)
                       .IsUnicode(false);

            entity.Property(e => e.EmailAddress)
                       .IsRequired()
                       .HasMaxLength(75)
                       .IsUnicode(false);

            entity.Property(e => e.PrincipleContactName)
                      .IsRequired()
                      .HasMaxLength(75)
                      .IsUnicode(false);

            entity.HasOne(d => d.Address)
               .WithMany(p => p.PrimaryCarePractices)
               .HasForeignKey(d => d.AddressId)
               .HasConstraintName("FK_Address_ToPrimaryCarePrictice");

           






        }
    }
}
