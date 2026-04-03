using System;
using System.Diagnostics;

namespace CG_Practice.dsacsharp
{
    class FibonacciComparison
    {
        static void Main(string[] args)
        {
            int[] values = { 10, 20, 30, 35 };
            
            Console.WriteLine("Fibonacci(N)\tRecursive\tIterative");
            Console.WriteLine("-----------------------------------------------");
            
            foreach (int n in values)
            {
                Stopwatch sw = Stopwatch.StartNew();
                int recursiveResult = FibonacciRecursive(n);
                sw.Stop();
                double recursiveTime = sw.Elapsed.TotalMilliseconds;
                
                sw.Restart();
                int iterativeResult = FibonacciIterative(n);
                sw.Stop();
                double iterativeTime = sw.Elapsed.TotalMilliseconds;
                
                Console.WriteLine($"Fib({n})\t\t{recursiveTime:F4}ms\t\t{iterativeTime:F4}ms");
            }
        }
        
        static int FibonacciRecursive(int n)
        {
            if (n <= 1) 
                return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
        
        static int FibonacciIterative(int n)
        {
            if (n <= 1) 
                return n;
                
            int a = 0, b = 1, sum = 0;
            
            for (int i = 2; i <= n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            
            return b;
        }
    }
}
