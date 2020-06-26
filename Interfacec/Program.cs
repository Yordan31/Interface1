using System;
using System.Collections.Generic;
using System.Linq;

namespace Interfacec
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Dogs> myDog = new List<Dogs>
            { new Dogs("Radka","pudel",5),
              new Dogs("Maya","pincher",3),
              new Dogs("Galya","karakachan",60),
              new Dogs("Geroge","dobreman",24),
              new Dogs("Maestro","alabai",70),
              new Dogs("Ani","huski",30)
            };
            myDog.Sort(new ComparerDogs());
            myDog.ForEach(Console.WriteLine);
            var cat1 = new Cats("Maya", 3);
            var cat2 = new Cats("Patya", 5);
            //cat2.Age = cat1.Age;

            Console.WriteLine(cat1.Equals(cat2));
            

        }

    }  
} 

