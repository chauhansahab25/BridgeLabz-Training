using System;
using System.Text;

namespace CG_Practice.dsacsharp
{
    class ReverseString
    {
        static void Main()
        {
            Console.WriteLine("=== Reverse String Using StringBuilder ===");
            Console.WriteLine();

            // get input from user
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // reverse using StringBuilder
            string reversed = ReverseUsingStringBuilder(input);

            Console.WriteLine("Original: " + input);
            Console.WriteLine("Reversed: " + reversed);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // simple method to reverse string
        static string ReverseUsingStringBuilder(string str)
        {
            StringBuilder sb = new StringBuilder();

            // add characters in reverse order
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            return sb.ToString();
        }
    }
}