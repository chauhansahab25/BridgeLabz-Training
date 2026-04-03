using System;
using System.Text;

namespace CG_Practice.dsacsharp
{
    class RemoveDuplicates
    {
        static void Main()
        {
            Console.WriteLine("=== Remove Duplicates Using StringBuilder ===");
            Console.WriteLine();

            // get input from user
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // remove duplicates
            string result = RemoveDuplicateChars(input);

            Console.WriteLine("Original: " + input);
            Console.WriteLine("After removing duplicates: " + result);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // remove duplicate characters
        static string RemoveDuplicateChars(string str)
        {
            StringBuilder sb = new StringBuilder();
            bool[] seen = new bool[256]; // for ASCII characters

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                
                // if character not seen before, add it
                if (!seen[c])
                {
                    seen[c] = true;
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }
}