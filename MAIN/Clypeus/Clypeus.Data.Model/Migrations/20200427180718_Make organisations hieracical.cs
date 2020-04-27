using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clypeus.Data.Model.Migrations
{
    public partial class Makeorganisationshieracical : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "users",
                table: "Organisation",
                unicode: false,
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "ContactName",
                schema: "users",
                table: "Organisation",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentOrganisationId",
                schema: "users",
                table: "Organisation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                schema: "medicinals",
                table: "DrugGroup",
                type: "datetime",
                nullable: true,
                defaultValue: new DateTime(2020, 4, 27, 19, 7, 18, 262, DateTimeKind.Local).AddTicks(1252),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 4, 27, 18, 59, 42, 977, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Inserted",
                schema: "medicinals",
                table: "DrugGroup",
                type: "datetime",
                nullable: true,
                defaultValue: new DateTime(2020, 4, 27, 19, 7, 18, 252, DateTimeKind.Local).AddTicks(7674),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 4, 27, 18, 59, 42, 970, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.CreateIndex(
                name: "IX_Organisation_ParentOrganisationId",
                schema: "users",
                table: "Organisation",
                column: "ParentOrganisationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Organisation_ToOrganisations",
                schema: "users",
                table: "Organisation",
                column: "ParentOrganisationId",
                principalSchema: "users",
                principalTable: "Organisation",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organisation_ToOrganisations",
                schema: "users",
                table: "Organisation");

            migrationBuilder.DropIndex(
                name: "IX_Organisation_ParentOrganisationId",
                schema: "users",
                table: "Organisation");

            migrationBuilder.DropColumn(
                name: "ContactName",
                schema: "users",
                table: "Organisation");

            migrationBuilder.DropColumn(
                name: "ParentOrganisationId",
                schema: "users",
                table: "Organisation");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "users",
                table: "Organisation",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                schema: "medicinals",
                table: "DrugGroup",
                type: "datetime",
                nullable: true,
                defaultValue: new DateTime(2020, 4, 27, 18, 59, 42, 977, DateTimeKind.Local).AddTicks(2217),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 4, 27, 19, 7, 18, 262, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Inserted",
                schema: "medicinals",
                table: "DrugGroup",
                type: "datetime",
                nullable: true,
                defaultValue: new DateTime(2020, 4, 27, 18, 59, 42, 970, DateTimeKind.Local).AddTicks(6977),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 4, 27, 19, 7, 18, 252, DateTimeKind.Local).AddTicks(7674));
        }
    }
}
