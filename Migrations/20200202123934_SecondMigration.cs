using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesMovie.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Record",
                columns: table => new
                {
                    recordID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    recordName = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    category = table.Column<string>(nullable: false),
                    addedDate = table.Column<DateTime>(nullable: false),
                    amount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Record", x => x.recordID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Record");
        }
    }
}
