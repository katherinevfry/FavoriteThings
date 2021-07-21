using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings.Faves
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public bool Favorite { get; set; }
        public bool Read { get; set; }
        public Book (string name, string author, bool favorite, bool read)
        {
            Name = name;
            Author = author;
            Favorite = favorite;
            Read = read;
        }

        public void ReadBook()
        {
            if (Read == false)
            {
                Console.WriteLine($"You are reading {Name} by {Author}");
            }
            else if (Read == true)
            {
                Console.WriteLine($"You have already read {Name} by {Author}");

            }
        }

        public void FaveBook()
        {
            Console.WriteLine("Would you like to favorite this book? Type yes or no");
            var response = Console.ReadLine();
            if (response.ToLower() == "yes")
            {
                Favorite = true;
                Console.WriteLine($"{Name} by {Author} is now your favorite.");
            }
            else
            {
                Console.WriteLine($"okay fine");
            }
        }

   
    }
}
