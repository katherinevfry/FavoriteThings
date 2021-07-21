using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings.Faves
{
    class Trip
    {
        public Trip(string location, int numberOfDays, string friend, string travelMethod)
        {
            Location = location;
            NumberOfDays = numberOfDays;
            Friend = friend;
            TravelMethod = travelMethod;
        }

        public string Location { get; set; }
        public int NumberOfDays { get; set; }
        public string Friend { get; set; }
        public string TravelMethod { get; set; }

        public void ExtendTrip(int howLong)
        {
            NumberOfDays += howLong;
            Console.WriteLine($"Your trip is now {NumberOfDays} day(s) long. You have extended your trip by {howLong} day(s)");
        }

        public void StartTrip()
        {
            Console.WriteLine($"You are going to {Location} for {NumberOfDays} day(s) " +
                $"with {Friend}. You are taking a {TravelMethod} to get there.");
        }
    }
}
