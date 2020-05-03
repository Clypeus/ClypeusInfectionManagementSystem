using Microsoft.EntityFrameworkCore.Migrations;

namespace Clypeus.Data.Model.Migrations
{
    public partial class HealthCareOrganisations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentHealthCareOrganisationId",
                table: "HealthCareOrganisation");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentHealthCareOrganisationId",
                table: "HealthCareOrganisation",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
