using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings.Faves
{
    class Coffee
    {
        public Coffee(string name, string location, bool favorite, string drinkOfChoice)
        {
            Name = name;
            Location = location;
            Favorite = favorite;
            DrinkOfChoice = drinkOfChoice;
        }

        public string Name { get; set; }
        public string Location { get; set; }
        public bool Favorite { get; set; }
        public string DrinkOfChoice { get; set; }

        public void GoGetCoffee()
        {
            Console.WriteLine($"You are at {Name} which is in {Location}. You ordered a {DrinkOfChoice}");
        }

        public void MyFavoriteShop()
        {
            if (Favorite == true)
            {
                Console.WriteLine($"{Name} was already your favorite coffee shop. How could you forget?");
            }
            else if (Favorite == false)
            {
                Console.WriteLine("Would you like to favorite this coffee shop? Type yes or no.");
                var resp = Console.ReadLine();
                if (resp.ToLower() == "yes")
                {
                    Favorite = true;
                    Console.WriteLine($"Congrats, {Name}, is now your favorite");
                }
                else
                {
                    Console.WriteLine("Okay bye");
                }
            }
        }
    }
}
