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
            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Title = "XCOM: Enemy Unknown",
                Description = "XCOM: Enemy Unknown is a 2012 turn-based tactical video game developed by Firaxis Games and published by 2K Games. The game is a reimagined remake of the 1994 cult classic strategy game X-COM: UFO Defense (also known as UFO: Enemy Unknown) and a reboot of MicroProse's 1990s X-COM series.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/f/fd/XCOM_Enemy_Unknown_Game_Cover.jpg",
                Price = 9.99m
            },

            new Product
            {
                Id = 2,
                Title = "The Witcher 3: Wild Hunt",
                Description = "The Witcher 3: Wild Hunt is a 2015 action role-playing game developed and published by CD Projekt. It is the sequel to the 2011 game The Witcher 2: Assassins of Kings and the third game in The Witcher video game series, played in an open world with a third-person perspective. The games are based on The Witcher series of fantasy novels written by Andrzej Sapkowski.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/0c/Witcher_3_cover_art.jpg",
                Price = 5.99m
            },

            new Product
            {
                Id = 3,
                Title = "Football Manager 2022",
                Description = "Football Manager 2022 (officially abbreviated as FM22) is a 2021 football-management simulation video game developed by Sports Interactive and published by Sega. It was released worldwide for Microsoft Windows and macOS on 8 November 2021.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/00/Football_Manager_2022_cover_image.jpg",
                Price = 19.99m
            }
        
                );
        }

        public DbSet<Product> Products { get; set; }
    }
}
