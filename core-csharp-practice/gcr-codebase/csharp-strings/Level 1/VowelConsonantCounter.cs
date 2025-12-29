using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Strings
{
    class VowelConsonantCounter
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            CountVowelsAndConsonants(input);
        }
        static void CountVowelsAndConsonants(string text)
        {
            int vow = 0, cons = 0;
            text = text.ToLower();   //string function

            foreach (char ch in text)
            {
                if (char.IsLetter(ch))
                {
                    if ("aeiou".Contains(ch))
                        vow++;
                    else
                        cons++;
                }
            }

            Console.WriteLine("Vowels: " + vow);
            Console.WriteLine("Consonants: " + cons);
        }
    }

}
