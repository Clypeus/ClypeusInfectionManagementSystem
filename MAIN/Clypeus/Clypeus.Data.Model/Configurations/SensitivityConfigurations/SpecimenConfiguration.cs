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

            entity.Property(e => e.LabSpecimenCode)
                       .IsRequired()
                       .HasMaxLength(50)
                       .IsUnicode(false);

            entity.Property(e => e.LabEpisodeCode)
                       .IsRequired()
                       .HasMaxLength(65)
                       .IsUnicode(false);

            entity.Property(e => e.LabPatientIdentifier)
                       .IsRequired()
                       .HasMaxLength(65)
                       .IsUnicode(false);

            entity.Property(e => e.LabPatientCode)
                       .IsRequired()
                       .HasMaxLength(65)
                       .IsUnicode(false);

            entity.Property(e => e.LabPatientSurname)
                       .IsRequired()
                       .HasMaxLength(65)
                       .IsUnicode(false);

            entity.Property(e => e.LabPatientDateOfBirth)
                       .IsRequired()
                       .HasMaxLength(10)
                       .IsUnicode(false);

            entity.Property(e => e.LocalPatientIdentifier)
                       .IsRequired()
                       .HasMaxLength(20)
                       .IsUnicode(false);
        }
    }
}
