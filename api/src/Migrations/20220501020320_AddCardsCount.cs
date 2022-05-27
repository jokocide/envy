using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace envyapi.Migrations
{
    public partial class AddCardsCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CardsCount",
                table: "Decks",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardsCount",
                table: "Decks");
        }
    }
}
