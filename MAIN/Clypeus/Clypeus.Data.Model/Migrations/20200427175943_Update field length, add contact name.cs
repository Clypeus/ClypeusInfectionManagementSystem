using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clypeus.Data.Model.Migrations
{
    public partial class Updatefieldlengthaddcontactname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                oldDefaultValue: new DateTime(2020, 4, 27, 18, 53, 46, 730, DateTimeKind.Local).AddTicks(4470));

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
                oldDefaultValue: new DateTime(2020, 4, 27, 18, 53, 46, 724, DateTimeKind.Local).AddTicks(5982));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                oldDefaultValue: new DateTime(2020, 4, 27, 18, 59, 42, 977, DateTimeKind.Local).AddTicks(2217));

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
                oldDefaultValue: new DateTime(2020, 4, 27, 18, 59, 42, 970, DateTimeKind.Local).AddTicks(6977));
        }
    }
}
