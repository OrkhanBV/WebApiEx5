using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WebApi5.Migrations
{
    public partial class Orkhan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryW",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    categoryType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryW", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "File",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    materialId = table.Column<int>(type: "integer", nullable: false),
                    fileName = table.Column<string>(type: "text", nullable: true),
                    materialName = table.Column<string>(type: "text", nullable: true),
                    size = table.Column<int>(type: "integer", nullable: false),
                    idVersion = table.Column<int>(type: "integer", nullable: false),
                    pathOfFile = table.Column<string>(type: "text", nullable: true),
                    CategoryWId = table.Column<int>(type: "integer", nullable: true),
                    data = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_File", x => x.Id);
                    table.ForeignKey(
                        name: "FK_File_CategoryW_CategoryWId",
                        column: x => x.CategoryWId,
                        principalTable: "CategoryW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_File_CategoryWId",
                table: "File",
                column: "CategoryWId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "File");

            migrationBuilder.DropTable(
                name: "CategoryW");
        }
    }
}
