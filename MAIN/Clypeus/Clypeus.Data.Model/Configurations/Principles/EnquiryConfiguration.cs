using Clypeus.Data.Model.Principles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations.Principles
{
    public class EnquiryConfiguration : IEntityTypeConfiguration<Enquiry>
    {
        public void Configure(EntityTypeBuilder<Enquiry> entity)
        {
            entity.ToTable("Enquiries", "Principles");

            entity.HasKey(d => d.Id);

            entity.Property(e => e.Title)
               .HasMaxLength(5)
               .IsUnicode(false);

            entity.Property(e => e.Surname)
               .HasMaxLength(100)
               .IsUnicode(false);


            entity.Property(e => e.FirstName)
               .HasMaxLength(100)
               .IsUnicode(false);

            entity.Property(e => e.HouseName)
               .HasMaxLength(100)
               .IsUnicode(false);

            entity.Property(e => e.Street)
               .HasMaxLength(100)
               .IsUnicode(false);

            entity.Property(e => e.Town)
               .HasMaxLength(100)
               .IsUnicode(false);

            entity.Property(e => e.Area)
               .HasMaxLength(100)
               .IsUnicode(false);

            entity.Property(e => e.Postcode)
               .HasMaxLength(100)
               .IsUnicode(false);


            entity.Property(e => e.Mobile)
               .HasMaxLength(100)
               .IsUnicode(false);


            entity.Property(e => e.Telephone)
               .HasMaxLength(100)
               .IsUnicode(false);

            entity.Property(e => e.Location)
               .HasMaxLength(250)
               .IsUnicode(false);

            entity.Property(e => e.SubjectTitle)
               .HasMaxLength(200)
               .IsUnicode(false);

            entity.Property(e => e.SubjectDescription)
               .HasMaxLength(500)
               .IsUnicode(false);

            entity.Property(e => e.RelationshipTypeId)
            .HasMaxLength(4)
            .IsUnicode(false);

            entity.Property(e => e.EnquiryTypeId)
              .HasMaxLength(4)
              .IsUnicode(false);

            entity.Property(e => e.Created).HasColumnType("datetime");
      
            entity.Property(e => e.CreatedBy);
            
            entity.HasOne(d => d.CreatedBySystemUser)
                .WithMany(f => f.EnquiriesCreated)
                .HasForeignKey(f => f.CreatedBy)
                .HasConstraintName("FK_Enquiry_CreatedBy")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
