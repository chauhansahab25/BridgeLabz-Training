using System;
using System.Text;

namespace CG_Practice.dsacsharp
{
    class ConcatenateStrings
    {
        static void Main()
        {
            Console.WriteLine("=== Concatenate Strings Using StringBuilder ===");
            Console.WriteLine();

            // sample array of strings
            string[] words = { "Hello", " ", "World", "!", " ", "How", " ", "are", " ", "you", "?" };

            Console.WriteLine("Array of strings:");
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write("\"" + words[i] + "\" ");
            }
            Console.WriteLine();
            Console.WriteLine();

            // concatenate using StringBuilder
            string result = ConcatenateArray(words);

            Console.WriteLine("Concatenated result: " + result);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // efficient concatenation using StringBuilder
        static string ConcatenateArray(string[] strings)
        {
            StringBuilder sb = new StringBuilder();

            // add each string to StringBuilder
            for (int i = 0; i < strings.Length; i++)
            {
                sb.Append(strings[i]);
            }

            return sb.ToString();
        }
    }
}