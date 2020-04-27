using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clypeus.Data.Model.Migrations
{
    public partial class LinkAddressToOrganisations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressId",
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
                defaultValue: new DateTime(2020, 4, 27, 18, 53, 46, 730, DateTimeKind.Local).AddTicks(4470),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 4, 27, 18, 39, 40, 550, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Inserted",
                schema: "medicinals",
                table: "DrugGroup",
                type: "datetime",
                nullable: true,
                defaultValue: new DateTime(2020, 4, 27, 18, 53, 46, 724, DateTimeKind.Local).AddTicks(5982),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 4, 27, 18, 39, 40, 544, DateTimeKind.Local).AddTicks(5994));

            migrationBuilder.CreateIndex(
                name: "IX_Organisation_AddressId",
                schema: "users",
                table: "Organisation",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_ToOrganisation",
                schema: "users",
                table: "Organisation",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_ToOrganisation",
                schema: "users",
                table: "Organisation");

            migrationBuilder.DropIndex(
                name: "IX_Organisation_AddressId",
                schema: "users",
                table: "Organisation");

            migrationBuilder.DropColumn(
                name: "AddressId",
                schema: "users",
                table: "Organisation");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                schema: "medicinals",
                table: "DrugGroup",
                type: "datetime",
                nullable: true,
                defaultValue: new DateTime(2020, 4, 27, 18, 39, 40, 550, DateTimeKind.Local).AddTicks(6671),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 4, 27, 18, 53, 46, 730, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Inserted",
                schema: "medicinals",
                table: "DrugGroup",
                type: "datetime",
                nullable: true,
                defaultValue: new DateTime(2020, 4, 27, 18, 39, 40, 544, DateTimeKind.Local).AddTicks(5994),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 4, 27, 18, 53, 46, 724, DateTimeKind.Local).AddTicks(5982));
        }
    }
}
