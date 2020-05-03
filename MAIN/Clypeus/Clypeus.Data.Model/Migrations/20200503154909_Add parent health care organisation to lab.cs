using Microsoft.EntityFrameworkCore.Migrations;

namespace Clypeus.Data.Model.Migrations
{
    public partial class Addparenthealthcareorganisationtolab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HealthCareOrganisationId",
                table: "Lab",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Lab_HealthCareOrganisationId",
                table: "Lab",
                column: "HealthCareOrganisationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lab_HealthCareOrganisation_HealthCareOrganisationId",
                table: "Lab",
                column: "HealthCareOrganisationId",
                principalTable: "HealthCareOrganisation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lab_HealthCareOrganisation_HealthCareOrganisationId",
                table: "Lab");

            migrationBuilder.DropIndex(
                name: "IX_Lab_HealthCareOrganisationId",
                table: "Lab");

            migrationBuilder.DropColumn(
                name: "HealthCareOrganisationId",
                table: "Lab");
        }
    }
}
