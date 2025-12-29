using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Strings
{

    public class AnagramCheck
    {
        static bool AreAnagrams(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            int[] count = new int[256];

            for (int i = 0; i < s1.Length; i++)
            {
                count[s1[i]]++;
                count[s2[i]]--;
            }

            for (int i = 0; i < 256; i++)
            {
                if (count[i] != 0)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter first string: ");
            string s1 = Console.ReadLine();

            Console.Write("Enter second string: ");
            string s2 = Console.ReadLine();

            if (AreAnagrams(s1, s2))
                Console.WriteLine("The strings are anagrams.");
            else
                Console.WriteLine("The strings are NOT anagrams.");
        }
    }
}
