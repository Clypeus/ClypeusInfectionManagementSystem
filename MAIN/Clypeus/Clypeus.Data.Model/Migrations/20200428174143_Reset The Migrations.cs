using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clypeus.Data.Model.Migrations
{
    public partial class ResetTheMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Medicinals");

            migrationBuilder.EnsureSchema(
                name: "Organisations");

            migrationBuilder.EnsureSchema(
                name: "People");

            migrationBuilder.EnsureSchema(
                name: "SystemUsers");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    Address3 = table.Column<string>(nullable: true),
                    Address4 = table.Column<string>(nullable: true),
                    Address5 = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: true),
                    Inserted = table.Column<DateTime>(nullable: true),
                    Updated = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DrugTypes",
                schema: "Medicinals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    Inserted = table.Column<DateTime>(type: "datetime", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotifiableDiseases",
                schema: "Medicinals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Inserted = table.Column<DateTime>(type: "datetime", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotifiableDiseases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganismClass",
                schema: "Medicinals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(unicode: false, maxLength: 75, nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    Inserted = table.Column<DateTime>(type: "datetime", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganismClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganismFamily",
                schema: "Medicinals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(unicode: false, maxLength: 75, nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    Inserted = table.Column<DateTime>(type: "datetime", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganismFamily", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganismKingdom",
                schema: "Medicinals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(unicode: false, maxLength: 75, nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    Inserted = table.Column<DateTime>(type: "datetime", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganismKingdom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganismOrder",
                schema: "Medicinals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(unicode: false, maxLength: 75, nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    Inserted = table.Column<DateTime>(type: "datetime", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganismOrder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganismPhylum",
                schema: "Medicinals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(unicode: false, maxLength: 75, nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    Inserted = table.Column<DateTime>(type: "datetime", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganismPhylum", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganismTypes",
                schema: "Medicinals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(unicode: false, maxLength: 75, nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    Inserted = table.Column<DateTime>(type: "datetime", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganismTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalPractioner",
                schema: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 75, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalPractioner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemOrganisation",
                schema: "SystemUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    ContactName = table.Column<string>(nullable: true),
                    AddressId = table.Column<int>(nullable: false),
                    TelephoneNumber = table.Column<string>(unicode: false, maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemOrganisation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_ToOrganisation",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DrugGroup",
                schema: "Medicinals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    DrugTypeId = table.Column<int>(nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    Inserted = table.Column<DateTime>(type: "datetime", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drugs_ToDrugsGroupTypes",
                        column: x => x.DrugTypeId,
                        principalSchema: "Medicinals",
                        principalTable: "DrugTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Organisms",
                schema: "Medicinals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    Species = table.Column<string>(unicode: false, maxLength: 125, nullable: true),
                    OrganismGenusId = table.Column<int>(nullable: true),
                    OrganismKingdomId = table.Column<int>(nullable: true),
                    OrganismPhylumId = table.Column<int>(nullable: true),
                    OrganismFamilyId = table.Column<int>(nullable: true),
                    OrganismClassId = table.Column<int>(nullable: true),
                    OrganismOrderId = table.Column<int>(nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    Inserted = table.Column<DateTime>(type: "datetime", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organisms_ToOrganismClass",
                        column: x => x.OrganismClassId,
                        principalSchema: "Medicinals",
                        principalTable: "OrganismClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Organisms_ToOrganismFamily",
                        column: x => x.OrganismFamilyId,
                        principalSchema: "Medicinals",
                        principalTable: "OrganismFamily",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Organisms_ToOrganismTypes",
                        column: x => x.OrganismGenusId,
                        principalSchema: "Medicinals",
                        principalTable: "OrganismTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Organisms_ToOrganismKingdom",
                        column: x => x.OrganismKingdomId,
                        principalSchema: "Medicinals",
                        principalTable: "OrganismKingdom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Organisms_ToOrganismOrder",
                        column: x => x.OrganismOrderId,
                        principalSchema: "Medicinals",
                        principalTable: "OrganismOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Organisms_ToOrganismPhylum",
                        column: x => x.OrganismPhylumId,
                        principalSchema: "Medicinals",
                        principalTable: "OrganismPhylum",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrimaryCarePractice",
                schema: "Organisations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    LongCode = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 75, nullable: false),
                    TelephoneNumber = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    EmailAddress = table.Column<string>(unicode: false, maxLength: 75, nullable: false),
                    PrincipleContactName = table.Column<string>(unicode: false, maxLength: 75, nullable: false),
                    AddressId = table.Column<int>(nullable: true),
                    ParentOrganisationId = table.Column<int>(nullable: true),
                    SecondaryOrganisationId = table.Column<int>(nullable: true),
                    SeniorPracticeMemberId = table.Column<int>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryCarePractice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_ToPrimaryCarePrictice",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Principle_ToPrimaryCarePrictice",
                        column: x => x.SeniorPracticeMemberId,
                        principalSchema: "People",
                        principalTable: "MedicalPractioner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SystemUsers",
                schema: "SystemUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    FirstName = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    LastName = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    DateRegistered = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastAccessed = table.Column<DateTime>(type: "datetime", nullable: true),
                    OrganisationId = table.Column<int>(nullable: false),
                    ContactAddressLine1 = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    ContactAddressLine2 = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    ContactAddressLine3 = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    ContactAddressLine4 = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    ContactAddressLine5 = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    TelephoneNumber = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    MobileTelephoneNumber = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    EmailAddress = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_ToOrganisations",
                        column: x => x.OrganisationId,
                        principalSchema: "SystemUsers",
                        principalTable: "SystemOrganisation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Drugs",
                schema: "Medicinals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    Atc = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    DrugTypeId = table.Column<int>(nullable: true),
                    PrincipleDrugGroupId = table.Column<int>(nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    Inserted = table.Column<DateTime>(type: "datetime", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drugs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drugs_ToDrugsTypes",
                        column: x => x.DrugTypeId,
                        principalSchema: "Medicinals",
                        principalTable: "DrugTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Drugs_ToDrugsGroup",
                        column: x => x.PrincipleDrugGroupId,
                        principalSchema: "Medicinals",
                        principalTable: "DrugGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NotifiableDiseasesOrganisms",
                schema: "Medicinals",
                columns: table => new
                {
                    OrganismId = table.Column<int>(nullable: false),
                    NotifiableDiseaseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotifiableDiseasesOrganisms", x => new { x.NotifiableDiseaseId, x.OrganismId });
                    table.ForeignKey(
                        name: "FK_NotifiableDiseasesOrganisms_NotifiableDiseases_NotifiableDiseaseId",
                        column: x => x.NotifiableDiseaseId,
                        principalSchema: "Medicinals",
                        principalTable: "NotifiableDiseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotifiableDiseasesOrganisms_Organisms_OrganismId",
                        column: x => x.OrganismId,
                        principalSchema: "Medicinals",
                        principalTable: "Organisms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DrugGroupMembers",
                schema: "Medicinals",
                columns: table => new
                {
                    DrugGroupId = table.Column<int>(nullable: false),
                    DrugId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DrugGrou__B7C2CA7426EEAF2F", x => new { x.DrugGroupId, x.DrugId });
                    table.ForeignKey(
                        name: "FK_Group_DrugGroup",
                        column: x => x.DrugGroupId,
                        principalSchema: "Medicinals",
                        principalTable: "DrugGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Group_Drug",
                        column: x => x.DrugId,
                        principalSchema: "Medicinals",
                        principalTable: "Drugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DrugGroup_DrugTypeId",
                schema: "Medicinals",
                table: "DrugGroup",
                column: "DrugTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DrugGroupMembers_DrugId",
                schema: "Medicinals",
                table: "DrugGroupMembers",
                column: "DrugId");

            migrationBuilder.CreateIndex(
                name: "IX_Drugs_DrugTypeId",
                schema: "Medicinals",
                table: "Drugs",
                column: "DrugTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Drugs_PrincipleDrugGroupId",
                schema: "Medicinals",
                table: "Drugs",
                column: "PrincipleDrugGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_NotifiableDiseasesOrganisms_OrganismId",
                schema: "Medicinals",
                table: "NotifiableDiseasesOrganisms",
                column: "OrganismId");

            migrationBuilder.CreateIndex(
                name: "IX_Organisms_OrganismClassId",
                schema: "Medicinals",
                table: "Organisms",
                column: "OrganismClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Organisms_OrganismFamilyId",
                schema: "Medicinals",
                table: "Organisms",
                column: "OrganismFamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_Organisms_OrganismGenusId",
                schema: "Medicinals",
                table: "Organisms",
                column: "OrganismGenusId");

            migrationBuilder.CreateIndex(
                name: "IX_Organisms_OrganismKingdomId",
                schema: "Medicinals",
                table: "Organisms",
                column: "OrganismKingdomId");

            migrationBuilder.CreateIndex(
                name: "IX_Organisms_OrganismOrderId",
                schema: "Medicinals",
                table: "Organisms",
                column: "OrganismOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Organisms_OrganismPhylumId",
                schema: "Medicinals",
                table: "Organisms",
                column: "OrganismPhylumId");

            migrationBuilder.CreateIndex(
                name: "IX_PrimaryCarePractice_AddressId",
                schema: "Organisations",
                table: "PrimaryCarePractice",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_PrimaryCarePractice_SeniorPracticeMemberId",
                schema: "Organisations",
                table: "PrimaryCarePractice",
                column: "SeniorPracticeMemberId",
                unique: true,
                filter: "[SeniorPracticeMemberId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SystemOrganisation_AddressId",
                schema: "SystemUsers",
                table: "SystemOrganisation",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_OrganisationsId",
                schema: "SystemUsers",
                table: "SystemUsers",
                column: "OrganisationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrugGroupMembers",
                schema: "Medicinals");

            migrationBuilder.DropTable(
                name: "NotifiableDiseasesOrganisms",
                schema: "Medicinals");

            migrationBuilder.DropTable(
                name: "PrimaryCarePractice",
                schema: "Organisations");

            migrationBuilder.DropTable(
                name: "SystemUsers",
                schema: "SystemUsers");

            migrationBuilder.DropTable(
                name: "Drugs",
                schema: "Medicinals");

            migrationBuilder.DropTable(
                name: "NotifiableDiseases",
                schema: "Medicinals");

            migrationBuilder.DropTable(
                name: "Organisms",
                schema: "Medicinals");

            migrationBuilder.DropTable(
                name: "MedicalPractioner",
                schema: "People");

            migrationBuilder.DropTable(
                name: "SystemOrganisation",
                schema: "SystemUsers");

            migrationBuilder.DropTable(
                name: "DrugGroup",
                schema: "Medicinals");

            migrationBuilder.DropTable(
                name: "OrganismClass",
                schema: "Medicinals");

            migrationBuilder.DropTable(
                name: "OrganismFamily",
                schema: "Medicinals");

            migrationBuilder.DropTable(
                name: "OrganismTypes",
                schema: "Medicinals");

            migrationBuilder.DropTable(
                name: "OrganismKingdom",
                schema: "Medicinals");

            migrationBuilder.DropTable(
                name: "OrganismOrder",
                schema: "Medicinals");

            migrationBuilder.DropTable(
                name: "OrganismPhylum",
                schema: "Medicinals");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "DrugTypes",
                schema: "Medicinals");
        }
    }
}
