using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        //kontekst potrzebny do uwtowrzenia migracji 
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //Umieszczamy w bazie danych dane początkowe

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Video Games",
                    Url = "video-games"
                },
                new Category
                {
                    Id = 2,
                    Name = "Music",
                    Url = "music"
                },
                new Category
                {
                    Id = 3,
                    Name = "Consoles",
                    Url = "consoles"
                }
                ); 



            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Title = "XCOM: Enemy Unknown",
                Description = "XCOM: Enemy Unknown is a 2012 turn-based tactical video game developed by Firaxis Games and published by 2K Games. The game is a reimagined remake of the 1994 cult classic strategy game X-COM: UFO Defense (also known as UFO: Enemy Unknown) and a reboot of MicroProse's 1990s X-COM series.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/f/fd/XCOM_Enemy_Unknown_Game_Cover.jpg",
                Price = 9.99m,
                CategoryId = 1
                
            },

            new Product
            {
                Id = 2,
                Title = "The Witcher 3: Wild Hunt",
                Description = "The Witcher 3: Wild Hunt is a 2015 action role-playing game developed and published by CD Projekt. It is the sequel to the 2011 game The Witcher 2: Assassins of Kings and the third game in The Witcher video game series, played in an open world with a third-person perspective. The games are based on The Witcher series of fantasy novels written by Andrzej Sapkowski.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/0c/Witcher_3_cover_art.jpg",
                Price = 5.99m,
                CategoryId = 1
            },

            new Product
            {
                Id = 3,
                Title = "Football Manager 2022",
                Description = "Football Manager 2022 (officially abbreviated as FM22) is a 2021 football-management simulation video game developed by Sports Interactive and published by Sega. It was released worldwide for Microsoft Windows and macOS on 8 November 2021.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/00/Football_Manager_2022_cover_image.jpg",
                Price = 19.99m,
                CategoryId = 1
            },
            new Product
            {
                Id = 4,
                Title = "Show No Mercy",
                Description = "Show No Mercy is the debut studio album by American thrash metal band Slayer, released on December 3, 1983, by Metal Blade Records. Brian Slagel signed the band to the label after watching them perform the song \"Phantom of the Opera\" by Iron Maiden. The band self-financed their full-length debut, combining the savings of vocalist Tom Araya, who was employed as a respiratory therapist, and money borrowed from guitarist Kerry King's father. Touring extensively promoting the album, the band brought close friends and family members along the trip, who helped backstage with lighting and sound.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/83/Slayer_-_Show_No_Mercy.jpg",
                Price = 30.99m,
                CategoryId = 2
            },
            new Product
            {
                Id = 5,
                Title = "Immortalized",
                Description = "Immortalized is the sixth studio album by American heavy metal band Disturbed. The album was released on August 21, 2015 by Reprise Records, and is Disturbed's first studio album since Asylum (2010), marking the longest gap between two studio albums in their career.With 98,000 album-equivalent units in its first week, Immortalized is Disturbed's fifth consecutive number one debut on the United States Billboard 200 chart. They are the third band in history to achieve this feat, after Metallica and Dave Matthews Band. The band also found crossover success in the album's third single, a cover of the 1964 song \"The Sound of Silence\" by Simon & Garfunkel, which marked Disturbed's highest ranked single on the Billboard Hot 100 at number 42 and has since become Disturbed's biggest song since \"Down with the Sickness\".",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/0b/Disturbed_immortalized_cover.jpg",
                Price = 55.99m,
                CategoryId = 2
            },
            new Product
            {
                Id = 6,
                Title = "Master of Puppets",
                Description = "Master of Puppets is the third studio album by the American heavy metal band Metallica, released on March 3, 1986, by Elektra Records.[1] Recorded in Denmark at Sweet Silence Studios with producer Flemming Rasmussen, it was the band's last album to feature bassist Cliff Burton, who died in a bus accident in Sweden during the album's promotional tour.The album's artwork, designed by Metallica and Peter Mensch and painted by Don Brautigam, depicts a cemetery field of white crosses tethered to strings, manipulated by a pair of hands in a clouded, blood-red sky, with a fiery orange glow on the horizon. Instead of releasing a single or video in advance of the album's release, Metallica embarked on a five-month American tour in support of Ozzy Osbourne. The European leg was canceled after Burton's death in September 1986, and the band returned home to audition a new bassist.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/b2/Metallica_-_Master_of_Puppets_cover.jpg",
                Price = 59.99m,
                CategoryId = 2
            },
            new Product
            {
                Id = 7,
                Title = "PlayStation 5",
                Description = "The PlayStation 5 (PS5) is a home video game console developed by Sony Interactive Entertainment. Announced in 2019 as the successor to the PlayStation 4, the PS5 was released on November 12, 2020, in Australia, Japan, New Zealand, North America, and South Korea, with worldwide release following a week later. The PS5 is part of the ninth generation of video game consoles, along with Microsoft's Xbox Series X and Series S consoles, which were released in the same month.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/1b/PlayStation_5_and_DualSense_with_transparent_background.png",
                Price = 800.99m,
                CategoryId = 3
            },          
            new Product
            {
                Id = 8,
                Title = "Nintendo Switch",
                Description = "The Nintendo Switch is a hybrid video game console developed by Nintendo and released worldwide in most regions on March 3, 2017. The console itself is a tablet that can either be docked for use as a home console or used as a portable device, making it a hybrid console. Its wireless Joy-Con controllers, with standard buttons and directional analog sticks for user input, motion sensing, and tactile feedback, can attach to both sides of the console to support handheld-style play.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/76/Nintendo-Switch-Console-Docked-wJoyConRB.jpg",
                Price = 390.00m,
                CategoryId = 3
            },
            new Product
            {
                Id = 9,
                Title = "Steam Deck",
                Description = "The Steam Deck is a handheld gaming computer developed by Valve Corporation. Released on February 25, 2022, the Steam Deck can be played as a handheld or connected to a monitor in the same manner as the Nintendo Switch. It is an x86-64-v3 device with integrated gaming inputs designed to play the full Steam library, including Windows PC games via the Linux-based Proton compatibility layer. The system is an open platform, allowing users to install other compatible games on the device or other operating systems.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/5/5d/Steam_Deck_%28front%29.png",
                Price = 649.00m,
                CategoryId = 3
            }


            );
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
