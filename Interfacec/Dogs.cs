using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Interfacec//IComparable
{
    public  class Dogs:IComparable<Dogs>
    {
        

        public string Name { get; set; }
        public string Breed { get; set; }
        public int Weight { get; set; }
        

        //public static Random rand = new Random();
        public Dogs(string name,string breed,int weight)
        {
            Breed = breed;
            Name = name;
            Weight = weight;
        }



        public int CompareTo([AllowNull] Dogs other)
        {
            return Name.CompareTo(other.Name);
        }
        public override string ToString()
        {
            return " the dog name is: " + Name +   " the dog breeds is: "  + Breed + " The dog weight is = " + Weight ;
        }
    }
} 
