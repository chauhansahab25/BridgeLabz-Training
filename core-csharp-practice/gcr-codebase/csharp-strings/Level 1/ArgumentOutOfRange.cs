using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Strings
{
    public class ArgumentOutOfRange
    {
        public static void DemonstrateArgumentOutOfRange()
        {
            string text = "BridgeLabz";

            int startIndex = 6;
            int endIndex = 3;

            // This will throw ArgumentOutOfRangeException
            string result = text.Substring(startIndex, endIndex - startIndex + 1);

            Console.WriteLine(result);
        }

        // Method that handles the exception
        public static void HandleArgumentOutOfRange()
        {
            try
            {
                DemonstrateArgumentOutOfRange();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception Caught: ArgumentOutOfRangeException");
                Console.WriteLine("Message: " + ex.Message);
            }
        }

        static void Main(string[] args)
        {
            HandleArgumentOutOfRange();
            Console.WriteLine("\nProgram execution continues safely.");
        }
    }
}
