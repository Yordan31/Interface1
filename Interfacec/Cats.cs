using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Interfacec//IEquitable
{
    public class Cats :IEquatable<Cats>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Cats(string name, int age)
        {
            Name = name;
            Age = age;
        }

             public bool Equals([AllowNull] Cats other)
             {
                if (Age == other.Age)
                {
                     return true;
                }
                  return false;
             }
       

        //public bool Equals([AllowNull] Cats other)
        //{
        //    return this.Name.Equals(other.Name) && this.Age.Equals(other.Age);
        //}
        //public static bool IsEqual(Cats first , Cats second)
        //{
        //    return first.Name.Equals(second.Name) && first.Age.Equals(second.Age);

        //}
        //public static bool IsNotEqual(Cats first,Cats second)
        //{
        //    return !(first == second);
        //}


    }
}
