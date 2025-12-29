using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Strings
{
    public class LexicographicalOrder
    {

        static int CompareStrings(string s1, string s2)
        {
            int minLength = s1.Length < s2.Length ? s1.Length : s2.Length;

            for (int i = 0; i < minLength; i++)
            {
                if (s1[i] != s2[i])
                {
                    return s1[i] - s2[i];
                }
            }

            return s1.Length - s2.Length;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter String 1: ");
            string s1 = Console.ReadLine();

            Console.Write("Enter String 2: ");
            string s2 = Console.ReadLine();

            int result = CompareStrings(s1, s2);

            if (result < 0)
            {
                Console.WriteLine($"\"{s1}\" comes before \"{s2}\" in lexicographical order");
            }
            else if (result > 0)
            {
                Console.WriteLine($"\"{s1}\" comes after \"{s2}\" in lexicographical order");
            }
            else
            {
                Console.WriteLine("Both strings are equal");
            }
        }
    }
}
