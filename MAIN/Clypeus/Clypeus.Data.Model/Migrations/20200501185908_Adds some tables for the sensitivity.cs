using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clypeus.Data.Model.Migrations
{
    public partial class Addssometablesforthesensitivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Specimen",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Requested = table.Column<DateTime>(nullable: true),
                    Authorised = table.Column<bool>(nullable: false),
                    Inserted = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specimen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpecimenSensitivity",
                schema: "Specimens",
                columns: table => new
                {
                    SpecimenId = table.Column<long>(nullable: false),
                    OrganismId = table.Column<int>(nullable: false),
                    DrugId = table.Column<int>(nullable: false),
                    SensitivityId = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecimenSensitivity", x => new { x.SpecimenId, x.OrganismId, x.DrugId });
                    table.ForeignKey(
                        name: "FK_Drug_SpecimenSensitivity",
                        column: x => x.DrugId,
                        principalSchema: "Medicinals",
                        principalTable: "Drugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Organism_SpecimenSensitivity",
                        column: x => x.OrganismId,
                        principalSchema: "Medicinals",
                        principalTable: "Organisms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sensitivity_SpecimenSensitivity",
                        column: x => x.SensitivityId,
                        principalSchema: "Specimens",
                        principalTable: "Sensitivity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Specimen_SpecimenSensitivity",
                        column: x => x.SpecimenId,
                        principalTable: "Specimen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpecimenSensitivity_DrugId",
                schema: "Specimens",
                table: "SpecimenSensitivity",
                column: "DrugId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecimenSensitivity_OrganismId",
                schema: "Specimens",
                table: "SpecimenSensitivity",
                column: "OrganismId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecimenSensitivity_SensitivityId",
                schema: "Specimens",
                table: "SpecimenSensitivity",
                column: "SensitivityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpecimenSensitivity",
                schema: "Specimens");

            migrationBuilder.DropTable(
                name: "Specimen");
        }
    }
}
