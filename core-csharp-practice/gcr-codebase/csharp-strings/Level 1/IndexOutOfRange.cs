using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Strings
{
    public class IndexOutOfRange
    {
        // Method that causes IndexOutOfRangeException
        public static void DemonstrateIndexOutOfRange()
        {
            string text = "BridgeLabz";

            // Invalid index access
            Console.WriteLine("Character at index 20: " + text[20]);
        }

        // Method that handles the exception
        public static void HandleIndexOutOfRange()
        {
            try
            {
                DemonstrateIndexOutOfRange();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Exception Caught: IndexOutOfRangeException");
                Console.WriteLine("Message: " + ex.Message);
            }
        }

        static void Main(string[] args)
        {
            HandleIndexOutOfRange();
            Console.WriteLine("\nProgram execution continues safely.");
        }
    }
}

