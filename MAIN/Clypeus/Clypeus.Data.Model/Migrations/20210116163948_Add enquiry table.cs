using Microsoft.EntityFrameworkCore.Migrations;

namespace Clypeus.Data.Model.Migrations
{
    public partial class Addenquirytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enquiry",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    HouseName = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    Town = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    RelationshipTypeId = table.Column<string>(nullable: true),
                    EnquiryTypeId = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    SubjectTitle = table.Column<string>(nullable: true),
                    SubjectDescription = table.Column<string>(nullable: true),
                    Created = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Archived = table.Column<string>(nullable: true),
                    CreatedBySystemUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enquiry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enquiry_SystemUsers_CreatedBySystemUserId",
                        column: x => x.CreatedBySystemUserId,
                        principalSchema: "SystemUsers",
                        principalTable: "SystemUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enquiry_CreatedBySystemUserId",
                table: "Enquiry",
                column: "CreatedBySystemUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enquiry");
        }
    }
}
