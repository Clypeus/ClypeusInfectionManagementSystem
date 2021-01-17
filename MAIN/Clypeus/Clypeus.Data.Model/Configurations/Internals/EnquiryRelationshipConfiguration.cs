using Clypeus.Data.Model.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations.Internals
{
    public class EnquiryRelationshipConfiguration : IEntityTypeConfiguration<EnquiryRelationship>
    {
        public void Configure(EntityTypeBuilder<EnquiryRelationship> entity)
        {
            entity.ToTable("EnquiryRelationship", "internal");

            entity.HasKey(d => d.Id);

            entity.Property(e => e.Code)
               .IsRequired()
               .HasMaxLength(5)
               .IsUnicode(false);

            entity.Property(e => e.Description)
               .IsRequired()
               .HasMaxLength(125)
               .IsUnicode(false);

            entity.Property(e => e.ShortDescription)
               .IsRequired()
               .HasMaxLength(30)
               .IsUnicode(false);

            entity.Property(e => e.IsActive)
               .IsRequired()
               .HasMaxLength(1)
               .IsUnicode(false);
        }
    }
}
