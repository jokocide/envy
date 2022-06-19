using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace envyapi.Migrations
{
    public partial class _02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Answer",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "Question",
                table: "Cards");

            migrationBuilder.AddColumn<List<string>>(
                name: "Sides",
                table: "Cards",
                type: "text[]",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sides",
                table: "Cards");

            migrationBuilder.AddColumn<string>(
                name: "Answer",
                table: "Cards",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Question",
                table: "Cards",
                type: "text",
                nullable: true);
        }
    }
}
