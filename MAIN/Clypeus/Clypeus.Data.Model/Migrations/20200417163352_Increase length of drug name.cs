using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clypeus.Data.Model.Migrations
{
    public partial class Increaselengthofdrugname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "medicinals",
                table: "Drugs",
                unicode: false,
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

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
                oldDefaultValue: new DateTime(2020, 4, 16, 19, 33, 0, 794, DateTimeKind.Local).AddTicks(3734));

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
                oldDefaultValue: new DateTime(2020, 4, 16, 19, 33, 0, 788, DateTimeKind.Local).AddTicks(5466));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "medicinals",
                table: "Drugs",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                schema: "medicinals",
                table: "DrugGroup",
                type: "datetime",
                nullable: true,
                defaultValue: new DateTime(2020, 4, 16, 19, 33, 0, 794, DateTimeKind.Local).AddTicks(3734),
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
                defaultValue: new DateTime(2020, 4, 16, 19, 33, 0, 788, DateTimeKind.Local).AddTicks(5466),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 4, 17, 17, 33, 51, 929, DateTimeKind.Local).AddTicks(3911));
        }
    }
}
