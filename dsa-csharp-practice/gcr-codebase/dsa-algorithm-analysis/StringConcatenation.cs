using System;
using System.Diagnostics;
using System.Text;

namespace CG_Practice.dsacsharp
{
    class StringConcatenation
    {
        static void Main(string[] args)
        {
            int[] operations = { 1000, 10000, 100000 };
            
            Console.WriteLine("Operations\tstring\t\tStringBuilder");
            Console.WriteLine("-----------------------------------------------");
            
            foreach (int count in operations)
            {
                Stopwatch sw = Stopwatch.StartNew();
                string result = "";
                for (int i = 0; i < count; i++)
                    result += "test";
                sw.Stop();
                double stringTime = sw.Elapsed.TotalMilliseconds;
                
                sw.Restart();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < count; i++)
                    sb.Append("test");
                string builderResult = sb.ToString();
                sw.Stop();
                double builderTime = sw.Elapsed.TotalMilliseconds;
                
                Console.WriteLine($"{count,10}\t{stringTime:F2}ms\t\t{builderTime:F2}ms");
            }
        }
    }
}
