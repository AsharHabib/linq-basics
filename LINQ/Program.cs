using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bird> birds = new List<Bird> {
                new Bird {Name = "Cardinal", Color = "Red", Sightings = 3},
                new Bird {Name = "Dove", Color = "White", Sightings = 2},
                new Bird {Name = "Robin", Color = "Red", Sightings = 5},
                new Bird {Name = "Blue Jay", Color = "Blue", Sightings = 1},
                new Bird {Name = "Canary", Color = "Yellow", Sightings = 0},
                new Bird {Name = "Crow", Color = "Black", Sightings = 11}
            };
            var birdsByColor = from b in birds group b by b.Color;
            foreach (var bird in birdsByColor)
            {
                Console.WriteLine(bird.Key + " " + bird.Count());
            }
        }
    }
}
