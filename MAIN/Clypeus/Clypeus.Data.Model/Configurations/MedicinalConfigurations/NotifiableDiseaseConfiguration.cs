using Clypeus.Data.Model.Medicinals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations.MedicinalConfigurations
{
    public class NotifiableDiseaseConfiguration : IEntityTypeConfiguration<NotifiableDisease>
    {
        public void Configure(EntityTypeBuilder<NotifiableDisease> entity)
        {
            entity.ToTable("NotifiableDiseases", "Medicinals");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Updated).HasColumnType("datetime");

        }
    }
}
