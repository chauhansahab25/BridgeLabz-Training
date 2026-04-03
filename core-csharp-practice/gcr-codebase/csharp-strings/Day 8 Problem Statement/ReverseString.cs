using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Strings
{
    public class ReverseString
    {
        static string ReverseText(string input)
        {
            string reversed = "";

            // Traverse the string from end to start
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }


            return reversed;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string result = ReverseText(input);

            Console.WriteLine("Reversed string: " + result);
        }
    }
}
