using Clypeus.Data.Model.Organisations;
using Clypeus.Data.Model.People;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Configurations.PeopleConfigurations
{
    public class MedicalPractionerConfiguration : IEntityTypeConfiguration<MedicalPractioner>
    {
        public void Configure(EntityTypeBuilder<MedicalPractioner> entity)
        {
            entity.ToTable("MedicalPractioner", "People");

            entity.Property(e => e.Code)
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false);

            entity.Property(e => e.Name)
                        .IsRequired()
                        .HasMaxLength(75)
                        .IsUnicode(false);

            entity.HasOne(d => d.PrinciplePractice)
               .WithOne(p => p.SeniorPracticeMember)
               .HasForeignKey<PrimaryCarePractice>(d => d.SeniorPracticeMemberId)
               .HasConstraintName("FK_Principle_ToPrimaryCarePrictice");

        }
    }
}
