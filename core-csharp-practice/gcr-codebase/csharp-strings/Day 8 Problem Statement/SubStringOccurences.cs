using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Strings
{
    public class SubStringOccurences
    {

        static int CountOccurrences(string text, string sub)
        {
            int count = 0;

            for (int i = 0; i <= text.Length - sub.Length; i++)
            {
                bool match = true;

                for (int j = 0; j < sub.Length; j++)
                {
                    if (text[i + j] != sub[j])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the main string: ");
            string text = Console.ReadLine();

            Console.Write("Enter the substring: ");
            string sub = Console.ReadLine();

            Console.WriteLine("Occurrences: " + CountOccurrences(text, sub));
        }
    }
}
