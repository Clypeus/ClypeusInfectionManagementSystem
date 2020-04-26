using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clypeus.Data.Model.Migrations
{
    public partial class createsanewnotifiablediseasetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                schema: "medicinals",
                table: "DrugGroup",
                type: "datetime",
                nullable: true,
                defaultValue: new DateTime(2020, 4, 26, 17, 8, 51, 35, DateTimeKind.Local).AddTicks(5404),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 4, 24, 19, 37, 42, 556, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Inserted",
                schema: "medicinals",
                table: "DrugGroup",
                type: "datetime",
                nullable: true,
                defaultValue: new DateTime(2020, 4, 26, 17, 8, 51, 29, DateTimeKind.Local).AddTicks(3094),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 4, 24, 19, 37, 42, 550, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.CreateTable(
                name: "NotifiableDiseases",
                schema: "medicinals",
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
                name: "NotifiableDiseasesOrganisms",
                schema: "medicinals",
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
                        principalSchema: "medicinals",
                        principalTable: "NotifiableDiseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotifiableDiseasesOrganisms_Organisms_OrganismId",
                        column: x => x.OrganismId,
                        principalSchema: "medicinals",
                        principalTable: "Organisms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NotifiableDiseasesOrganisms_OrganismId",
                schema: "medicinals",
                table: "NotifiableDiseasesOrganisms",
                column: "OrganismId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotifiableDiseasesOrganisms",
                schema: "medicinals");

            migrationBuilder.DropTable(
                name: "NotifiableDiseases",
                schema: "medicinals");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                schema: "medicinals",
                table: "DrugGroup",
                type: "datetime",
                nullable: true,
                defaultValue: new DateTime(2020, 4, 24, 19, 37, 42, 556, DateTimeKind.Local).AddTicks(8267),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 4, 26, 17, 8, 51, 35, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Inserted",
                schema: "medicinals",
                table: "DrugGroup",
                type: "datetime",
                nullable: true,
                defaultValue: new DateTime(2020, 4, 24, 19, 37, 42, 550, DateTimeKind.Local).AddTicks(7630),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 4, 26, 17, 8, 51, 29, DateTimeKind.Local).AddTicks(3094));
        }
    }
}
