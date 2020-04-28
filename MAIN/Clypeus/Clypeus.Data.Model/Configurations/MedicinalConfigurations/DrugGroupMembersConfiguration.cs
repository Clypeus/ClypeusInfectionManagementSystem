
using Clypeus.Data.Model.Medicinals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations.Medicinals
{
    public class DrugGroupMembersConfiguration : IEntityTypeConfiguration<DrugGroupMembers>
    {
        public void Configure(EntityTypeBuilder<DrugGroupMembers> entity)
        {
            entity.HasKey(e => new { e.DrugGroupId, e.DrugId })
                    .HasName("PK__DrugGrou__B7C2CA7426EEAF2F");

            entity.ToTable("DrugGroupMembers", "Medicinals");

            entity.HasOne(d => d.DrugGroup)
                .WithMany(p => p.DrugGroupMembers)
                .HasForeignKey(d => d.DrugGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Group_DrugGroup");

            entity.HasOne(d => d.Drug)
                .WithMany(p => p.DrugGroupMembers)
                .HasForeignKey(d => d.DrugId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Group_Drug");
        }
    }
}
