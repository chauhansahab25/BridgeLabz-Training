using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Strings
{
    public class ToggleTheCase
    {
        static string Toggle(string input)
        {

            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (ch >= 'A' && ch <= 'Z')
                {
                    result += (char)(ch + 32);
                }
                else if (ch >= 'a' && ch <= 'z')
                {
                    result += (char)(ch - 32);
                }
                else
                {
                    result += ch;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.WriteLine("Toggled string: " + Toggle(input));
        }
    }
}
