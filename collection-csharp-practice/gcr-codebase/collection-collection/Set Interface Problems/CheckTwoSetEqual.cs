using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Collection
{
    //Compare two sets and determine if they contain the same elements, regardless of order.
    public class CheckTwoSetEqual
    {
        public static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int> { 2, 3, 4 };
            HashSet<int> set2 = new HashSet<int> { 1, 2, 3 };

            bool isEqual = set1.SetEquals(set2);

            Console.WriteLine("Is it equal- " + isEqual);
        }
    }
}

