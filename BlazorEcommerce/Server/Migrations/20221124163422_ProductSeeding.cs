using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "XCOM: Enemy Unknown is a 2012 turn-based tactical video game developed by Firaxis Games and published by 2K Games. The game is a reimagined remake of the 1994 cult classic strategy game X-COM: UFO Defense (also known as UFO: Enemy Unknown) and a reboot of MicroProse's 1990s X-COM series.", "https://upload.wikimedia.org/wikipedia/en/f/fd/XCOM_Enemy_Unknown_Game_Cover.jpg", 9.99m, "XCOM: Enemy Unknown" },
                    { 2, "The Witcher 3: Wild Hunt is a 2015 action role-playing game developed and published by CD Projekt. It is the sequel to the 2011 game The Witcher 2: Assassins of Kings and the third game in The Witcher video game series, played in an open world with a third-person perspective. The games are based on The Witcher series of fantasy novels written by Andrzej Sapkowski.", "https://upload.wikimedia.org/wikipedia/en/0/0c/Witcher_3_cover_art.jpg", 5.99m, "The Witcher 3: Wild Hunt" },
                    { 3, "Football Manager 2022 (officially abbreviated as FM22) is a 2021 football-management simulation video game developed by Sports Interactive and published by Sega. It was released worldwide for Microsoft Windows and macOS on 8 November 2021.", "https://upload.wikimedia.org/wikipedia/en/0/00/Football_Manager_2022_cover_image.jpg", 19.99m, "Football Manager 2022" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
