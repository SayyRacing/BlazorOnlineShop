using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class SecondProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 2, "Show No Mercy is the debut studio album by American thrash metal band Slayer, released on December 3, 1983, by Metal Blade Records. Brian Slagel signed the band to the label after watching them perform the song \"Phantom of the Opera\" by Iron Maiden. The band self-financed their full-length debut, combining the savings of vocalist Tom Araya, who was employed as a respiratory therapist, and money borrowed from guitarist Kerry King's father. Touring extensively promoting the album, the band brought close friends and family members along the trip, who helped backstage with lighting and sound.", "https://upload.wikimedia.org/wikipedia/en/8/83/Slayer_-_Show_No_Mercy.jpg", 30.99m, "Show No Mercy" },
                    { 5, 2, "Immortalized is the sixth studio album by American heavy metal band Disturbed. The album was released on August 21, 2015 by Reprise Records, and is Disturbed's first studio album since Asylum (2010), marking the longest gap between two studio albums in their career.With 98,000 album-equivalent units in its first week, Immortalized is Disturbed's fifth consecutive number one debut on the United States Billboard 200 chart. They are the third band in history to achieve this feat, after Metallica and Dave Matthews Band. The band also found crossover success in the album's third single, a cover of the 1964 song \"The Sound of Silence\" by Simon & Garfunkel, which marked Disturbed's highest ranked single on the Billboard Hot 100 at number 42 and has since become Disturbed's biggest song since \"Down with the Sickness\".", "https://upload.wikimedia.org/wikipedia/en/0/0b/Disturbed_immortalized_cover.jpg", 55.99m, "Immortalized" },
                    { 6, 2, "Master of Puppets is the third studio album by the American heavy metal band Metallica, released on March 3, 1986, by Elektra Records.[1] Recorded in Denmark at Sweet Silence Studios with producer Flemming Rasmussen, it was the band's last album to feature bassist Cliff Burton, who died in a bus accident in Sweden during the album's promotional tour.The album's artwork, designed by Metallica and Peter Mensch and painted by Don Brautigam, depicts a cemetery field of white crosses tethered to strings, manipulated by a pair of hands in a clouded, blood-red sky, with a fiery orange glow on the horizon. Instead of releasing a single or video in advance of the album's release, Metallica embarked on a five-month American tour in support of Ozzy Osbourne. The European leg was canceled after Burton's death in September 1986, and the band returned home to audition a new bassist.", "https://upload.wikimedia.org/wikipedia/en/b/b2/Metallica_-_Master_of_Puppets_cover.jpg", 59.99m, "Master of Puppets" },
                    { 7, 3, "The PlayStation 5 (PS5) is a home video game console developed by Sony Interactive Entertainment. Announced in 2019 as the successor to the PlayStation 4, the PS5 was released on November 12, 2020, in Australia, Japan, New Zealand, North America, and South Korea, with worldwide release following a week later. The PS5 is part of the ninth generation of video game consoles, along with Microsoft's Xbox Series X and Series S consoles, which were released in the same month.", "https://upload.wikimedia.org/wikipedia/en/8/83/Slayer_-_Show_No_Mercy.jpg", 800.99m, "PlayStation 5" },
                    { 8, 3, "The Nintendo Switch[n] is a hybrid video game console developed by Nintendo and released worldwide in most regions on March 3, 2017. The console itself is a tablet that can either be docked for use as a home console or used as a portable device, making it a hybrid console. Its wireless Joy-Con controllers, with standard buttons and directional analog sticks for user input, motion sensing, and tactile feedback, can attach to both sides of the console to support handheld-style play.", "https://upload.wikimedia.org/wikipedia/commons/7/76/Nintendo-Switch-Console-Docked-wJoyConRB.jpg", 390.00m, "Nintendo Switch" },
                    { 9, 3, "The Steam Deck is a handheld gaming computer developed by Valve Corporation. Released on February 25, 2022, the Steam Deck can be played as a handheld or connected to a monitor in the same manner as the Nintendo Switch. It is an x86-64-v3 device with integrated gaming inputs designed to play the full Steam library, including Windows PC games via the Linux-based Proton compatibility layer. The system is an open platform, allowing users to install other compatible games on the device or other operating systems.", "https://upload.wikimedia.org/wikipedia/commons/5/5d/Steam_Deck_%28front%29.png", 649.00m, "Steam Deck" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
