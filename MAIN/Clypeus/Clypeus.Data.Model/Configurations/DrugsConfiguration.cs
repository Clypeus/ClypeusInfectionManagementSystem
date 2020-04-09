using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations
{
    public class DrugsConfiguration : IEntityTypeConfiguration<Drugs>
    {
        public void Configure(EntityTypeBuilder<Drugs> entity)
        {
            entity.ToTable("Drugs", "medicinals");

            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.HasOne(d => d.DrugType)
                .WithMany(p => p.InverseDrugType)
                .HasForeignKey(d => d.DrugTypeId)
                .HasConstraintName("FK_Drugs_ToDrugsTypes");

            entity.HasOne(d => d.PrincipleDrugGroup)
                .WithMany(p => p.InversePrincipleDrugGroup)
                .HasForeignKey(d => d.PrincipleDrugGroupId)
                .HasConstraintName("FK_Drugs_ToDrugsGroup");
        }
    }
}
