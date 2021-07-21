using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings.Faves
{
    class Animal
    {
        public Animal(string name, string type, string color)
        {
            Name = name;
            Type = type;
            Color = color;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

        public void AdoptAnimal()
        {
            Console.WriteLine($"Congrats, you adopted a {Color} {Type} named {Name}");
        }

        public void Cuddle()
        {
            Console.WriteLine($"Cuddle the baby");
        }
    }
}
