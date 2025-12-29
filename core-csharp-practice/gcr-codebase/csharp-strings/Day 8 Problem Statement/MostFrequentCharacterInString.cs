using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Strings
{
    public class MostFrequentCharacterInString
    {
        static char FindMostFrequent(string input)
        {

            int maxCount = 0;
            char mostFrequent = input[0];

            for (int i = 0; i < input.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    mostFrequent = input[i];
                }
            }

            return mostFrequent;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string input = Console.ReadLine();

            Console.WriteLine("Most Frequent Character: '" + FindMostFrequent(input) + "'");
        }
    }
}
