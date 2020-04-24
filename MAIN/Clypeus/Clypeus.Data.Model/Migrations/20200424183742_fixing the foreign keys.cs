using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clypeus.Data.Model.Migrations
{
    public partial class fixingtheforeignkeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drugs_ToDrugsTypes",
                schema: "medicinals",
                table: "Drugs");

            migrationBuilder.DropForeignKey(
                name: "FK_Drugs_ToDrugsGroup",
                schema: "medicinals",
                table: "Drugs");

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
                oldDefaultValue: new DateTime(2020, 4, 18, 16, 56, 6, 81, DateTimeKind.Local).AddTicks(5252));

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
                oldDefaultValue: new DateTime(2020, 4, 18, 16, 56, 6, 71, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.AddForeignKey(
                name: "FK_Drugs_ToDrugsTypes",
                schema: "medicinals",
                table: "Drugs",
                column: "DrugTypeId",
                principalSchema: "medicinals",
                principalTable: "DrugTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Drugs_ToDrugsGroup",
                schema: "medicinals",
                table: "Drugs",
                column: "PrincipleDrugGroupId",
                principalSchema: "medicinals",
                principalTable: "DrugGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drugs_ToDrugsTypes",
                schema: "medicinals",
                table: "Drugs");

            migrationBuilder.DropForeignKey(
                name: "FK_Drugs_ToDrugsGroup",
                schema: "medicinals",
                table: "Drugs");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                schema: "medicinals",
                table: "DrugGroup",
                type: "datetime",
                nullable: true,
                defaultValue: new DateTime(2020, 4, 18, 16, 56, 6, 81, DateTimeKind.Local).AddTicks(5252),
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
                defaultValue: new DateTime(2020, 4, 18, 16, 56, 6, 71, DateTimeKind.Local).AddTicks(994),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 4, 24, 19, 37, 42, 550, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.AddForeignKey(
                name: "FK_Drugs_ToDrugsTypes",
                schema: "medicinals",
                table: "Drugs",
                column: "DrugTypeId",
                principalSchema: "medicinals",
                principalTable: "Drugs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Drugs_ToDrugsGroup",
                schema: "medicinals",
                table: "Drugs",
                column: "PrincipleDrugGroupId",
                principalSchema: "medicinals",
                principalTable: "Drugs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
