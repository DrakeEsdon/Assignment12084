using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace VideoGameStore.Models
{
    public class GameDbInit : DropCreateDatabaseAlways<ApplicationDbContext>//creates a database with this seed
    {
        protected override void Seed (ApplicationDbContext context)
        {
            context.Genres.Add(new Genre // creates a new genre item
            {
                Name = "RPG",
                Description = "Role Playing Games"
            });
            context.Genres.Add(new Genre
            {
                Name = "Card Game",
                Description = "A game that requires you to collect playing cards"
            });
            context.Games.Add(new Game // creates a new game item
            {
                Title = "Skyrim",
                Description = "Travel the world as the Drgon Born!",
                MinimumRequirements = "i3 intel processor, 21 gbs of free memory, and a gtx 550TI or better",
                Publisher = "Bethesda",
                Developer = "Bethesda Studios, Iron Galaxy",
                price = 89.99m

            });
            context.Games.Add(new Game
            {
                Title = "Hearthstone",
                Description = "World of Warcraft, the card game",
                MinimumRequirements = "Fresh Potatoe. Old potatoes will have some significant lag.",
                Publisher = "Blizzard",
                Developer = "Blizzard",
                price = 0m

            });
            base.Seed(context);
        }

    }
}