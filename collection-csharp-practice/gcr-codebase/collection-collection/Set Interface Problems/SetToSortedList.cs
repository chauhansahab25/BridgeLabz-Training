using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Collection
{
    //Convert a HashSet<int> into a sorted list in ascending order.

    public class SetToSortedList
    {
        public static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int> { 5, 6, 9, 2 };

            List<int> sortedList = new List<int>(set);
            sortedList.Sort();

            Console.WriteLine("Sorted List: [" + string.Join(", ", sortedList) + "]");
        }
    }
}

