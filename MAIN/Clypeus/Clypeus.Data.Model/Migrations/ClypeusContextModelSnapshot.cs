﻿// <auto-generated />
using System;
using Clypeus.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Clypeus.Data.Model.Migrations
{
    [DbContext(typeof(ClypeusContext))]
    partial class ClypeusContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Clypeus.Data.Model.Medicinals.DrugGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int?>("DrugTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Inserted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValue(new DateTime(2020, 4, 26, 17, 8, 51, 29, DateTimeKind.Local).AddTicks(3094));

                    b.Property<DateTime?>("Updated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValue(new DateTime(2020, 4, 26, 17, 8, 51, 35, DateTimeKind.Local).AddTicks(5404));

                    b.HasKey("Id");

                    b.HasIndex("DrugTypeId");

                    b.ToTable("DrugGroup","medicinals");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Medicinals.DrugGroupMembers", b =>
                {
                    b.Property<int>("DrugGroupId")
                        .HasColumnType("int");

                    b.Property<int>("DrugId")
                        .HasColumnType("int");

                    b.HasKey("DrugGroupId", "DrugId")
                        .HasName("PK__DrugGrou__B7C2CA7426EEAF2F");

                    b.HasIndex("DrugId");

                    b.ToTable("DrugGroupMembers","medicinals");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Medicinals.DrugTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime?>("Inserted")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("DrugTypes","medicinals");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Medicinals.Drugs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Atc")
                        .IsRequired()
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int?>("DrugTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Inserted")
                        .HasColumnType("datetime");

                    b.Property<int?>("PrincipleDrugGroupId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("DrugTypeId");

                    b.HasIndex("PrincipleDrugGroupId");

                    b.ToTable("Drugs","medicinals");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Medicinals.NotifiableDisease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<DateTime?>("Inserted")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("NotifiableDiseases","medicinals");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Medicinals.NotifiableDiseaseOrganism", b =>
                {
                    b.Property<int>("NotifiableDiseaseId")
                        .HasColumnType("int");

                    b.Property<int>("OrganismId")
                        .HasColumnType("int");

                    b.HasKey("NotifiableDiseaseId", "OrganismId");

                    b.HasIndex("OrganismId");

                    b.ToTable("NotifiableDiseasesOrganisms","medicinals");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Medicinals.OrganismClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(75)")
                        .HasMaxLength(75)
                        .IsUnicode(false);

                    b.Property<DateTime?>("Inserted")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("OrganismClass","medicinals");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Medicinals.OrganismFamily", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(75)")
                        .HasMaxLength(75)
                        .IsUnicode(false);

                    b.Property<DateTime?>("Inserted")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("OrganismFamily","medicinals");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Medicinals.OrganismGenus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(75)")
                        .HasMaxLength(75)
                        .IsUnicode(false);

                    b.Property<DateTime?>("Inserted")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("OrganismTypes","medicinals");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Medicinals.OrganismKingdom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(75)")
                        .HasMaxLength(75)
                        .IsUnicode(false);

                    b.Property<DateTime?>("Inserted")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("OrganismKingdom","medicinals");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Medicinals.OrganismOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(75)")
                        .HasMaxLength(75)
                        .IsUnicode(false);

                    b.Property<DateTime?>("Inserted")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("OrganismOrder","medicinals");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Medicinals.OrganismPhylum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(75)")
                        .HasMaxLength(75)
                        .IsUnicode(false);

                    b.Property<DateTime?>("Inserted")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("OrganismPhylum","medicinals");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Medicinals.Organisms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<DateTime?>("Inserted")
                        .HasColumnType("datetime");

                    b.Property<int?>("OrganismClassId")
                        .HasColumnType("int");

                    b.Property<int?>("OrganismFamilyId")
                        .HasColumnType("int");

                    b.Property<int?>("OrganismGenusId")
                        .HasColumnType("int");

                    b.Property<int?>("OrganismKingdomId")
                        .HasColumnType("int");

                    b.Property<int?>("OrganismOrderId")
                        .HasColumnType("int");

                    b.Property<int?>("OrganismPhylumId")
                        .HasColumnType("int");

                    b.Property<string>("Species")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("OrganismClassId");

                    b.HasIndex("OrganismFamilyId");

                    b.HasIndex("OrganismGenusId");

                    b.HasIndex("OrganismKingdomId");

                    b.HasIndex("OrganismOrderId");

                    b.HasIndex("OrganismPhylumId");

                    b.ToTable("Organisms","medicinals");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Users.Organisation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("AddressLine3")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("AddressLine4")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("AddressLine5")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("TelephoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Organisation","users");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("ContactAddressLine1")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("ContactAddressLine2")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("ContactAddressLine3")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("ContactAddressLine4")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("ContactAddressLine5")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<DateTime?>("DateRegistered")
                        .HasColumnType("datetime");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<DateTime?>("LastAccessed")
                        .HasColumnType("datetime");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("MobileTelephoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<int>("OrganisationId")
                        .HasColumnType("int");

                    b.Property<string>("TelephoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(12)")
                        .HasMaxLength(12)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("OrganisationId")
                        .HasName("IX_Users_OrganisationsId");

                    b.ToTable("Users","users");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Medicinals.DrugGroup", b =>
                {
                    b.HasOne("Clypeus.Data.Model.Medicinals.DrugTypes", "DrugType")
                        .WithMany("DrugGroup")
                        .HasForeignKey("DrugTypeId")
                        .HasConstraintName("FK_Drugs_ToDrugsGroupTypes");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Medicinals.DrugGroupMembers", b =>
                {
                    b.HasOne("Clypeus.Data.Model.Medicinals.DrugGroup", "DrugGroup")
                        .WithMany("DrugGroupMembers")
                        .HasForeignKey("DrugGroupId")
                        .HasConstraintName("FK_Group_DrugGroup")
                        .IsRequired();

                    b.HasOne("Clypeus.Data.Model.Medicinals.Drugs", "Drug")
                        .WithMany("DrugGroupMembers")
                        .HasForeignKey("DrugId")
                        .HasConstraintName("FK_Group_Drug")
                        .IsRequired();
                });

            modelBuilder.Entity("Clypeus.Data.Model.Medicinals.Drugs", b =>
                {
                    b.HasOne("Clypeus.Data.Model.Medicinals.DrugTypes", "DrugType")
                        .WithMany("Drugs")
                        .HasForeignKey("DrugTypeId")
                        .HasConstraintName("FK_Drugs_ToDrugsTypes");

                    b.HasOne("Clypeus.Data.Model.Medicinals.DrugGroup", "PrincipleDrugGroup")
                        .WithMany("Drugs")
                        .HasForeignKey("PrincipleDrugGroupId")
                        .HasConstraintName("FK_Drugs_ToDrugsGroup");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Medicinals.NotifiableDiseaseOrganism", b =>
                {
                    b.HasOne("Clypeus.Data.Model.Medicinals.NotifiableDisease", "NotifiableDisease")
                        .WithMany("NotifiableDiseaseOrganisms")
                        .HasForeignKey("NotifiableDiseaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clypeus.Data.Model.Medicinals.Organisms", "Organism")
                        .WithMany("NotifiableDiseaseOrganisms")
                        .HasForeignKey("OrganismId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clypeus.Data.Model.Medicinals.Organisms", b =>
                {
                    b.HasOne("Clypeus.Data.Model.Medicinals.OrganismClass", "OrganismClass")
                        .WithMany("Organisms")
                        .HasForeignKey("OrganismClassId")
                        .HasConstraintName("FK_Organisms_ToOrganismClass");

                    b.HasOne("Clypeus.Data.Model.Medicinals.OrganismFamily", "OrganismFamily")
                        .WithMany("Organisms")
                        .HasForeignKey("OrganismFamilyId")
                        .HasConstraintName("FK_Organisms_ToOrganismFamily");

                    b.HasOne("Clypeus.Data.Model.Medicinals.OrganismGenus", "OrganismGenus")
                        .WithMany("Organisms")
                        .HasForeignKey("OrganismGenusId")
                        .HasConstraintName("FK_Organisms_ToOrganismTypes");

                    b.HasOne("Clypeus.Data.Model.Medicinals.OrganismKingdom", "OrganismKingdom")
                        .WithMany("Organisms")
                        .HasForeignKey("OrganismKingdomId")
                        .HasConstraintName("FK_Organisms_ToOrganismKingdom");

                    b.HasOne("Clypeus.Data.Model.Medicinals.OrganismOrder", "OrganismOrder")
                        .WithMany("Organisms")
                        .HasForeignKey("OrganismOrderId")
                        .HasConstraintName("FK_Organisms_ToOrganismOrder");

                    b.HasOne("Clypeus.Data.Model.Medicinals.OrganismPhylum", "OrganismPhylum")
                        .WithMany("Organisms")
                        .HasForeignKey("OrganismPhylumId")
                        .HasConstraintName("FK_Organisms_ToOrganismPhylum");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Users.User", b =>
                {
                    b.HasOne("Clypeus.Data.Model.Users.Organisation", "Organisation")
                        .WithMany("Users")
                        .HasForeignKey("OrganisationId")
                        .HasConstraintName("FK_Users_ToOrganisations")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
