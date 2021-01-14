using Clypeus.Data.Model.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations.Internals
{
    class NoteTextConfiguration : IEntityTypeConfiguration<NoteText>
    {
        public void Configure(EntityTypeBuilder<NoteText> entity)
        {
            entity.ToTable("NoteTexts", "internal");

            entity.HasKey(d => d.Id);
            entity.Property(e => e.Text)
               .IsRequired()
               .HasMaxLength(500)
               .IsUnicode(false);

            entity.Property(e => e.IsDeleted);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Deleted).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy);
            entity.Property(e => e.DeletedBy);

            entity.HasOne(d => d.CreatedBySystemUser)
                .WithMany(f => f.NotesCreated)
                .HasForeignKey(f => f.CreatedBy)
                .HasConstraintName("FK_NoteText_CreatedBy")
                .OnDelete(DeleteBehavior.Restrict);
              
            entity.HasOne(d => d.DeletedBySystemUser)
             .WithMany(f => f.NotesDeleted)
             .HasForeignKey(f => f.DeletedBy)
             .HasConstraintName("FK_NoteText_DeletedBy")
             .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
