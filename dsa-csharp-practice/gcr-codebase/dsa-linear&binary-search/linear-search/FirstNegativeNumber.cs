using System;

namespace CG_Practice.dsacsharp.linearsearch
{
    class FirstNegativeNumber
    {
        static void Main()
        {
            int[] numbers = { 5, 3, -2, 8, -7, 1, 4 };
            
            Console.WriteLine("Array: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            
            int result = FindFirstNegative(numbers);
            
            if (result != -1)
            {
                Console.WriteLine("First negative number: " + result);
            }
            else
            {
                Console.WriteLine("No negative number found");
            }
            
            Console.ReadKey();
        }
        
        static int FindFirstNegative(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    return arr[i];
                }
            }
            return -1; // not found
        }
    }
}