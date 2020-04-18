using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clypeus.Data.Model.Migrations
{
    public partial class IncreaseLengthOfOrganismCodeandName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Species",
                schema: "medicinals",
                table: "Organisms",
                unicode: false,
                maxLength: 125,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(75)",
                oldUnicode: false,
                oldMaxLength: 75,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "medicinals",
                table: "Organisms",
                unicode: false,
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(75)",
                oldUnicode: false,
                oldMaxLength: 75,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                schema: "medicinals",
                table: "Organisms",
                unicode: false,
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldUnicode: false,
                oldMaxLength: 15);

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
                oldDefaultValue: new DateTime(2020, 4, 17, 17, 33, 51, 935, DateTimeKind.Local).AddTicks(5161));

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
                oldDefaultValue: new DateTime(2020, 4, 17, 17, 33, 51, 929, DateTimeKind.Local).AddTicks(3911));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Species",
                schema: "medicinals",
                table: "Organisms",
                type: "varchar(75)",
                unicode: false,
                maxLength: 75,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 125,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "medicinals",
                table: "Organisms",
                type: "varchar(75)",
                unicode: false,
                maxLength: 75,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                schema: "medicinals",
                table: "Organisms",
                type: "varchar(15)",
                unicode: false,
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                schema: "medicinals",
                table: "DrugGroup",
                type: "datetime",
                nullable: true,
                defaultValue: new DateTime(2020, 4, 17, 17, 33, 51, 935, DateTimeKind.Local).AddTicks(5161),
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
                defaultValue: new DateTime(2020, 4, 17, 17, 33, 51, 929, DateTimeKind.Local).AddTicks(3911),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 4, 18, 16, 56, 6, 71, DateTimeKind.Local).AddTicks(994));
        }
    }
}
