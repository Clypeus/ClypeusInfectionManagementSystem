using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clypeus.Data.Model.Migrations
{
    public partial class AddNotesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "internal");

            migrationBuilder.CreateTable(
                name: "NoteTexts",
                schema: "internal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Created = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedBy = table.Column<int>(nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoteTexts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NoteText_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "SystemUsers",
                        principalTable: "SystemUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NoteText_DeletedBy",
                        column: x => x.DeletedBy,
                        principalSchema: "SystemUsers",
                        principalTable: "SystemUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NoteTexts_CreatedBy",
                schema: "internal",
                table: "NoteTexts",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_NoteTexts_DeletedBy",
                schema: "internal",
                table: "NoteTexts",
                column: "DeletedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NoteTexts",
                schema: "internal");
        }
    }
}
