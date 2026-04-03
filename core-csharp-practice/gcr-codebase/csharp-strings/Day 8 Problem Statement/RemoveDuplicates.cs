using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Strings
{
    public class RemoveDuplicates
    {
        static string RemoveDuplicateCharacters(string input)
        {
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {

                char currentChar = input[i];

                // Check if character already exists in result
                if (!result.Contains(currentChar))
                {
                    result += currentChar;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string output = RemoveDuplicateCharacters(input);

            Console.WriteLine("String after removing duplicates: " + output);
        }

    }
}
