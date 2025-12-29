using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Strings
{
    public class ArrayIndexOutOfException
    {
        public static void DemonstrateArrayIndexOutOfRange()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            // Invalid index access
            Console.WriteLine("Element at index 10: " + numbers[10]);
        }

        // Method that handles the exception
        public static void HandleArrayIndexOutOfRange()
        {
            try
            {
                DemonstrateArrayIndexOutOfRange();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Exception Caught: IndexOutOfRangeException");
                Console.WriteLine("Message: " + ex.Message);
            }
        }

        static void Main(string[] args)
        {
            HandleArrayIndexOutOfRange();
            Console.WriteLine("\nProgram execution continues safely.");
        }
    }
}
