using FavoriteThings.Faves;
using System;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            //define some things
            var book1 = new Book("Station Eleven", "Emily St. John Mandel", true, true);
            var book2 = new Book("Song of Achilles", "I Don't Remember", false, false);

            var paris = new Trip("Paris, France", 8, "Audrey", "Plane");
            var banff = new Trip("Banff, CA", 5, "Ashley", "Car");

            var stayGolden = new Coffee("StayGolden", "Sidco", false, "Iced Cuban");
            var crema = new Coffee("Crema", "Downtown", true, "Iced Mocha");

            var trashBabe = new Animal("Paul", "Racoon", "gray");
            var baby = new Animal("Edgar", "Kitty", "Black");

            // do some things

            book1.ReadBook();
            book2.FaveBook();

            paris.ExtendTrip(5);
            paris.ExtendTrip(2);
            banff.StartTrip();

            stayGolden.GoGetCoffee();
            crema.MyFavoriteShop();
            crema.GoGetCoffee();
            stayGolden.MyFavoriteShop();

            trashBabe.AdoptAnimal();
            baby.Cuddle();

        }
    }
}
