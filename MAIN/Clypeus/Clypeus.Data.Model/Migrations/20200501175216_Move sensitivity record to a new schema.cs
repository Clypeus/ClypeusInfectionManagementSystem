using Microsoft.EntityFrameworkCore.Migrations;

namespace Clypeus.Data.Model.Migrations
{
    public partial class Movesensitivityrecordtoanewschema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Specimens");

            migrationBuilder.RenameTable(
                name: "Sensitivity",
                schema: "Medicinals",
                newName: "Sensitivity",
                newSchema: "Specimens");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Sensitivity",
                schema: "Specimens",
                newName: "Sensitivity",
                newSchema: "Medicinals");
        }
    }
}
