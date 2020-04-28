using Clypeus.Data.Model.Medicinals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations.Medicinals
{
    public class DrugGroupConfiguration: IEntityTypeConfiguration<DrugGroup>
    {
        public void Configure(EntityTypeBuilder<DrugGroup> entity)
        {
            entity.ToTable("DrugGroup", "Medicinals");

            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                        .HasMaxLength(100)
                        .IsUnicode(false);

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.HasOne(d => d.DrugType)
                        .WithMany(p => p.DrugGroup)
                        .HasForeignKey(d => d.DrugTypeId)
                        .HasConstraintName("FK_Drugs_ToDrugsGroupTypes");

        }
    }
}
