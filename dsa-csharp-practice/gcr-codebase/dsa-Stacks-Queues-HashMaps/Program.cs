using System;
using System.Collections.Generic;

namespace CG_Practice.dsa_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DSA - Stacks, Queues & HashMaps Demo");
            
            // Test Stack Problems
            var sp = new StackProblems();
            Console.WriteLine("Valid Parentheses: " + sp.IsValidParentheses("()[]{}"));
            
            // Test Queue using Stacks
            var qus = new AdvancedStackProblems.QueueUsingStacks();
            qus.Enqueue(1);
            qus.Enqueue(2);
            Console.WriteLine("Queue using Stacks: " + qus.Dequeue());
            
            // Test HashMap
            var hm = new HashMapProblems();
            int[] arr = {1, 2, 3, 4, 5};
            Console.WriteLine("Has pair sum 9: " + hm.HasPairSum(arr, 9));
            
            // Test Custom HashMap
            var chm = new CustomHashMap<string, int>();
            chm.Put("key1", 100);
            Console.WriteLine("Custom HashMap get: " + chm.Get("key1"));
            
            Console.WriteLine("All tests completed!");
        }
    }
}