using System;

namespace CG_Practice.dsascenario.PasswordCrackerSimulator
{
    public class CrackerUtility
    {
        public static void ShowComplexity(int n, int k)
        {
            Console.WriteLine("\n--- Complexity Analysis ---");
            Console.WriteLine("Time Complexity  : O(k^n)");
            Console.WriteLine("Space Complexity : O(n)");
            Console.WriteLine($"Where k = {k} (char set size), n = {n} (password length)");
        }
    }
}
