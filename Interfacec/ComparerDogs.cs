using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Interfacec//IComparer
{
    public class ComparerDogs : IComparer<Dogs>
    {
        public int Compare([AllowNull] Dogs left, [AllowNull] Dogs right)
        {
            return left.Weight - right.Weight;
        }
    }
}
