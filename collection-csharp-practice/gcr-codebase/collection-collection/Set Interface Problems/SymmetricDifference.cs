using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Collection
{
    //Find the symmetric difference (elements present in either set but not both).
    public class SymmetricDifference
    {
       
        public static void Main(string[] args)
        {
            HashSet<int> setOne = new HashSet<int> { 10, 11, 12 };
            HashSet<int> setTwo = new HashSet<int> { 12, 13, 14 };

            HashSet<int> symmetricdifference = new HashSet<int>(setOne);
            symmetricdifference.SymmetricExceptWith(setTwo);

            Console.WriteLine("Symmetric Difference: " + string.Join(", ", symmetricdifference));
        }
    }

}

