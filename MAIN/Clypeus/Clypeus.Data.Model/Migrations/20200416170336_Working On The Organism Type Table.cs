using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clypeus.Data.Model.Migrations
{
    public partial class WorkingOnTheOrganismTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "medicinals");

            migrationBuilder.EnsureSchema(
                name: "users");

            migrationBuilder.CreateTable(
                name: "Drugs",
                schema: "medicinals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
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
                        principalSchema: "medicinals",
                        principalTable: "Drugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Drugs_ToDrugsGroup",
                        column: x => x.PrincipleDrugGroupId,
                        principalSchema: "medicinals",
                        principalTable: "Drugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DrugTypes",
                schema: "medicinals",
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
                name: "OrganismClass",
                schema: "medicinals",
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
                schema: "medicinals",
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
                schema: "medicinals",
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
                schema: "medicinals",
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
                schema: "medicinals",
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
                schema: "medicinals",
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
                name: "Organisation",
                schema: "users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    AddressLine2 = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    AddressLine3 = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    AddressLine4 = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    AddressLine5 = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    TelephoneNumber = table.Column<string>(unicode: false, maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DrugGroup",
                schema: "medicinals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
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
                        principalSchema: "medicinals",
                        principalTable: "DrugTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Organisms",
                schema: "medicinals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 75, nullable: true),
                    Species = table.Column<string>(unicode: false, maxLength: 75, nullable: true),
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
                        principalSchema: "medicinals",
                        principalTable: "OrganismClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Organisms_ToOrganismFamily",
                        column: x => x.OrganismFamilyId,
                        principalSchema: "medicinals",
                        principalTable: "OrganismFamily",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Organisms_ToOrganismTypes",
                        column: x => x.OrganismGenusId,
                        principalSchema: "medicinals",
                        principalTable: "OrganismTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Organisms_ToOrganismKingdom",
                        column: x => x.OrganismKingdomId,
                        principalSchema: "medicinals",
                        principalTable: "OrganismKingdom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Organisms_ToOrganismOrder",
                        column: x => x.OrganismOrderId,
                        principalSchema: "medicinals",
                        principalTable: "OrganismOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Organisms_ToOrganismPhylum",
                        column: x => x.OrganismPhylumId,
                        principalSchema: "medicinals",
                        principalTable: "OrganismPhylum",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "users",
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
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_ToOrganisations",
                        column: x => x.OrganisationId,
                        principalSchema: "users",
                        principalTable: "Organisation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DrugGroupMembers",
                schema: "medicinals",
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
                        principalSchema: "medicinals",
                        principalTable: "DrugGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Group_Drug",
                        column: x => x.DrugId,
                        principalSchema: "medicinals",
                        principalTable: "Drugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DrugGroup_DrugTypeId",
                schema: "medicinals",
                table: "DrugGroup",
                column: "DrugTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DrugGroupMembers_DrugId",
                schema: "medicinals",
                table: "DrugGroupMembers",
                column: "DrugId");

            migrationBuilder.CreateIndex(
                name: "IX_Drugs_DrugTypeId",
                schema: "medicinals",
                table: "Drugs",
                column: "DrugTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Drugs_PrincipleDrugGroupId",
                schema: "medicinals",
                table: "Drugs",
                column: "PrincipleDrugGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Organisms_OrganismClassId",
                schema: "medicinals",
                table: "Organisms",
                column: "OrganismClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Organisms_OrganismFamilyId",
                schema: "medicinals",
                table: "Organisms",
                column: "OrganismFamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_Organisms_OrganismGenusId",
                schema: "medicinals",
                table: "Organisms",
                column: "OrganismGenusId");

            migrationBuilder.CreateIndex(
                name: "IX_Organisms_OrganismKingdomId",
                schema: "medicinals",
                table: "Organisms",
                column: "OrganismKingdomId");

            migrationBuilder.CreateIndex(
                name: "IX_Organisms_OrganismOrderId",
                schema: "medicinals",
                table: "Organisms",
                column: "OrganismOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Organisms_OrganismPhylumId",
                schema: "medicinals",
                table: "Organisms",
                column: "OrganismPhylumId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_OrganisationsId",
                schema: "users",
                table: "Users",
                column: "OrganisationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrugGroupMembers",
                schema: "medicinals");

            migrationBuilder.DropTable(
                name: "Organisms",
                schema: "medicinals");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "users");

            migrationBuilder.DropTable(
                name: "DrugGroup",
                schema: "medicinals");

            migrationBuilder.DropTable(
                name: "Drugs",
                schema: "medicinals");

            migrationBuilder.DropTable(
                name: "OrganismClass",
                schema: "medicinals");

            migrationBuilder.DropTable(
                name: "OrganismFamily",
                schema: "medicinals");

            migrationBuilder.DropTable(
                name: "OrganismTypes",
                schema: "medicinals");

            migrationBuilder.DropTable(
                name: "OrganismKingdom",
                schema: "medicinals");

            migrationBuilder.DropTable(
                name: "OrganismOrder",
                schema: "medicinals");

            migrationBuilder.DropTable(
                name: "OrganismPhylum",
                schema: "medicinals");

            migrationBuilder.DropTable(
                name: "Organisation",
                schema: "users");

            migrationBuilder.DropTable(
                name: "DrugTypes",
                schema: "medicinals");
        }
    }
}
