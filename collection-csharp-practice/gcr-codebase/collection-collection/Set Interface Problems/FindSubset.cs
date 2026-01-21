using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Collection
{
    //Check if one set is a subset of another.
    public class FindSubset
    {
        public static void Main(string[] args)
        {
            HashSet<int> subset = new HashSet<int> { 2, 4 };
            HashSet<int> mainSet = new HashSet<int> { 1, 2, 3, 4 };

            bool isSubset = subset.IsSubsetOf(mainSet);

            Console.WriteLine(isSubset);
        }
    }
}

