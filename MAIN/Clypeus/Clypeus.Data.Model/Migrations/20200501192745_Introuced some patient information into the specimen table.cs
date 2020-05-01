using Microsoft.EntityFrameworkCore.Migrations;

namespace Clypeus.Data.Model.Migrations
{
    public partial class Introucedsomepatientinformationintothespecimentable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LabEpisodeCode",
                table: "Specimen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LabPatientCode",
                table: "Specimen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LabPatientDateOfBirth",
                table: "Specimen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LabPatientIdentifier",
                table: "Specimen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LabPatientSurname",
                table: "Specimen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LabSpecimenCode",
                table: "Specimen",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LabEpisodeCode",
                table: "Specimen");

            migrationBuilder.DropColumn(
                name: "LabPatientCode",
                table: "Specimen");

            migrationBuilder.DropColumn(
                name: "LabPatientDateOfBirth",
                table: "Specimen");

            migrationBuilder.DropColumn(
                name: "LabPatientIdentifier",
                table: "Specimen");

            migrationBuilder.DropColumn(
                name: "LabPatientSurname",
                table: "Specimen");

            migrationBuilder.DropColumn(
                name: "LabSpecimenCode",
                table: "Specimen");
        }
    }
}
