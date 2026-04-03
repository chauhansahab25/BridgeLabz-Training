using System;
using System.Diagnostics;
using System.Text;

namespace CG_Practice.dsacsharp
{
    class PerformanceComparison
    {
        static void Main()
        {
            Console.WriteLine("=== StringBuilder Performance Comparison ===");
            Console.WriteLine();

            int iterations = 10000;
            string word = "Hello";

            Console.WriteLine("Concatenating \"" + word + "\" " + iterations + " times");
            Console.WriteLine();

            // test regular string concatenation
            Stopwatch sw1 = Stopwatch.StartNew();
            string result1 = ConcatenateWithString(word, iterations);
            sw1.Stop();

            // test StringBuilder concatenation
            Stopwatch sw2 = Stopwatch.StartNew();
            string result2 = ConcatenateWithStringBuilder(word, iterations);
            sw2.Stop();

            // show results
            Console.WriteLine("Results:");
            Console.WriteLine("Regular String: " + sw1.ElapsedMilliseconds + " ms");
            Console.WriteLine("StringBuilder: " + sw2.ElapsedMilliseconds + " ms");
            Console.WriteLine();

            Console.WriteLine("Final length: " + result2.Length + " characters");
            Console.WriteLine("StringBuilder is " + (sw1.ElapsedMilliseconds / (double)sw2.ElapsedMilliseconds).ToString("F1") + "x faster");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // slow way using regular string
        static string ConcatenateWithString(string word, int times)
        {
            string result = "";
            for (int i = 0; i < times; i++)
            {
                result += word;
            }
            return result;
        }

        // fast way using StringBuilder
        static string ConcatenateWithStringBuilder(string word, int times)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < times; i++)
            {
                sb.Append(word);
            }
            return sb.ToString();
        }
    }
}