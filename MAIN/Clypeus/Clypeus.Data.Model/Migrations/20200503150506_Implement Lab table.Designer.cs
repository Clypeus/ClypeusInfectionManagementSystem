﻿// <auto-generated />
using System;
using Clypeus.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Clypeus.Data.Model.Migrations
{
    [DbContext(typeof(ClypeusContext))]
    [Migration("20200503150506_Implement Lab table")]
    partial class ImplementLabtable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Clypeus.Data.Model.Geography.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inserted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Postcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

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
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("DrugTypeId");

                    b.ToTable("DrugGroup","Medicinals");
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

                    b.ToTable("DrugGroupMembers","Medicinals");
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

                    b.ToTable("DrugTypes","Medicinals");
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

                    b.ToTable("Drugs","Medicinals");
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

                    b.ToTable("NotifiableDiseases","Medicinals");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Medicinals.NotifiableDiseaseOrganism", b =>
                {
                    b.Property<int>("NotifiableDiseaseId")
                        .HasColumnType("int");

                    b.Property<int>("OrganismId")
                        .HasColumnType("int");

                    b.HasKey("NotifiableDiseaseId", "OrganismId");

                    b.HasIndex("OrganismId");

                    b.ToTable("NotifiableDiseasesOrganisms","Medicinals");
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

                    b.ToTable("OrganismClass","Medicinals");
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

                    b.ToTable("OrganismFamily","Medicinals");
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

                    b.ToTable("OrganismTypes","Medicinals");
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

                    b.ToTable("OrganismKingdom","Medicinals");
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

                    b.ToTable("OrganismOrder","Medicinals");
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

                    b.ToTable("OrganismPhylum","Medicinals");
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

                    b.ToTable("Organisms","Medicinals");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Organisations.PrimaryCarePractice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("varchar(75)")
                        .HasMaxLength(75)
                        .IsUnicode(false);

                    b.Property<string>("LongCode")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(75)")
                        .HasMaxLength(75)
                        .IsUnicode(false);

                    b.Property<int?>("ParentOrganisationId")
                        .HasColumnType("int");

                    b.Property<string>("PrincipleContactName")
                        .IsRequired()
                        .HasColumnType("varchar(75)")
                        .HasMaxLength(75)
                        .IsUnicode(false);

                    b.Property<int?>("SecondaryOrganisationId")
                        .HasColumnType("int");

                    b.Property<int?>("SeniorPracticeMemberId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelephoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("SeniorPracticeMemberId")
                        .IsUnique()
                        .HasFilter("[SeniorPracticeMemberId] IS NOT NULL");

                    b.ToTable("PrimaryCarePractice","Organisations");
                });

            modelBuilder.Entity("Clypeus.Data.Model.People.MedicalPractioner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(75)")
                        .HasMaxLength(75)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("MedicalPractioner","People");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Specimens.Lab", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactTelephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Lab");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Specimens.Sensitivity", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(1)")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Sensitivity","Specimens");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Specimens.Specimen", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Authorised")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Inserted")
                        .HasColumnType("datetime2");

                    b.Property<string>("LabEpisodeCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LabPatientCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LabPatientDateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LabPatientIdentifier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LabPatientSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LabSpecimenCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Requested")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Specimen");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Specimens.SpecimenSensitivity", b =>
                {
                    b.Property<long>("SpecimenId")
                        .HasColumnType("bigint");

                    b.Property<int>("OrganismId")
                        .HasColumnType("int");

                    b.Property<int>("DrugId")
                        .HasColumnType("int");

                    b.Property<short>("SensitivityId")
                        .HasColumnType("smallint");

                    b.HasKey("SpecimenId", "OrganismId", "DrugId");

                    b.HasIndex("DrugId");

                    b.HasIndex("OrganismId");

                    b.HasIndex("SensitivityId");

                    b.ToTable("SpecimenSensitivity","Specimens");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Users.SystemOrganisations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("TelephoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("SystemOrganisation","SystemUsers");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Users.SystemUser", b =>
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

                    b.ToTable("SystemUsers","SystemUsers");
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

            modelBuilder.Entity("Clypeus.Data.Model.Organisations.PrimaryCarePractice", b =>
                {
                    b.HasOne("Clypeus.Data.Model.Geography.Address", "Address")
                        .WithMany("PrimaryCarePractices")
                        .HasForeignKey("AddressId")
                        .HasConstraintName("FK_Address_ToPrimaryCarePrictice");

                    b.HasOne("Clypeus.Data.Model.People.MedicalPractioner", "SeniorPracticeMember")
                        .WithOne("PrinciplePractice")
                        .HasForeignKey("Clypeus.Data.Model.Organisations.PrimaryCarePractice", "SeniorPracticeMemberId")
                        .HasConstraintName("FK_Principle_ToPrimaryCarePrictice");
                });

            modelBuilder.Entity("Clypeus.Data.Model.Specimens.Lab", b =>
                {
                    b.HasOne("Clypeus.Data.Model.Geography.Address", "Address")
                        .WithOne("Lab")
                        .HasForeignKey("Clypeus.Data.Model.Specimens.Lab", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clypeus.Data.Model.Specimens.SpecimenSensitivity", b =>
                {
                    b.HasOne("Clypeus.Data.Model.Medicinals.Drugs", "Drug")
                        .WithMany("SpecimenSensitivity")
                        .HasForeignKey("DrugId")
                        .HasConstraintName("FK_Drug_SpecimenSensitivity")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clypeus.Data.Model.Medicinals.Organisms", "Organism")
                        .WithMany("SpecimenSensitivity")
                        .HasForeignKey("OrganismId")
                        .HasConstraintName("FK_Organism_SpecimenSensitivity")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clypeus.Data.Model.Specimens.Sensitivity", "Sensitivity")
                        .WithMany("SpecimenSensitivity")
                        .HasForeignKey("SensitivityId")
                        .HasConstraintName("FK_Sensitivity_SpecimenSensitivity")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clypeus.Data.Model.Specimens.Specimen", "Specimen")
                        .WithMany("SpecimenSensitivity")
                        .HasForeignKey("SpecimenId")
                        .HasConstraintName("FK_Specimen_SpecimenSensitivity")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clypeus.Data.Model.Users.SystemOrganisations", b =>
                {
                    b.HasOne("Clypeus.Data.Model.Geography.Address", "Address")
                        .WithMany("SystemOrganisations")
                        .HasForeignKey("AddressId")
                        .HasConstraintName("FK_Address_ToOrganisation")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clypeus.Data.Model.Users.SystemUser", b =>
                {
                    b.HasOne("Clypeus.Data.Model.Users.SystemOrganisations", "SystemOrganisation")
                        .WithMany("Users")
                        .HasForeignKey("OrganisationId")
                        .HasConstraintName("FK_Users_ToOrganisations")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
