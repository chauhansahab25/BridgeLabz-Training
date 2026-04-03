using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Strings
{
    public class CompareStrings
    {
        public static bool Compare(string first, string second)
        {
            if (first.Length != second.Length)
            {
                return false;
            }
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                {
                    return false;
                }
            }
            return true;


        }
        static void Main(string[] args)
        {
            Console.Write("Enter First String : ");
            string first = Console.ReadLine();

            Console.Write("Enter Second String : ");
            string second = Console.ReadLine();

            bool selfMade = Compare(first, second);

            bool preDefined = string.Equals(first, second);

            Console.WriteLine("\n Comparison");
            Console.WriteLine("use charAt logic :" + selfMade);
            Console.WriteLine("using build in method :" + preDefined);

        }
    }
}
