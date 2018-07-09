using deleohynekwedding.Models;
using System;
using System.Linq;

namespace deleohynekwedding.Data.SeedData
{
    public static class MenuOptionInitializer
    {
        public static void SeeMenuOptions(this WeddingContext context)
        {
            context.Database.EnsureCreated();
            
            if (context.MenuOptions.Any()) return;

            var menuOptions = new MenuOption[]
            {
                new MenuOption { Name = "Brisket Sandwich", Caterer = "Oakmont BBQ" },
                new MenuOption { Name = "Pulled Pork Nachos", Caterer = "Oakmont BBQ" },
                new MenuOption { Name = "Brisket Mac", Caterer = "Oakmont BBQ" },
                new MenuOption { Name = "St Louis Ribs", Caterer = "Oakmont BBQ" },
                new MenuOption { Name = "Salmon Poke", Caterer = "Chop Shop" },
                new MenuOption { Name = "Chicken Kale Caesar", Caterer = "Chop Shop" },
                new MenuOption { Name = "Glorious Steak", Caterer = "Chop Shop" },
                new MenuOption { Name = "Hearty Vegan", Caterer = "Chop Shop" }
            };

            Array.ForEach(menuOptions, x => context.MenuOptions.Add(x));
            context.SaveChanges();
        }
    }
}
