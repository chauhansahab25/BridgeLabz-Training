using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Strings
{
    public class RemoveSpecificCharacter
    {
        static string RemoveCharacter(string input, char removeChar)
        {

            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != removeChar)
                {
                    result += input[i];
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string input = Console.ReadLine();

            Console.Write("Enter the character to remove: ");
            char removeChar = Console.ReadLine()[0];

            Console.WriteLine("Modified String: \"" + RemoveCharacter(input, removeChar) + "\"");
        }
    }
}
