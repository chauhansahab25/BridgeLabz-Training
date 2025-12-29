using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Strings
{
    public class FormatExceptionDemo
    {
        public static void DemonstrateFormatException()
        {
            string input = "ABC123"; // Non-numeric string

            // This will throw FormatException
            int number = int.Parse(input);

            Console.WriteLine("Converted number: " + number);
        }

        // Method that handles the exception
        public static void HandleFormatException()
        {
            try
            {
                DemonstrateFormatException();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Exception Caught: FormatException");
                Console.WriteLine("Message: " + ex.Message);
            }
        }

        static void Main(string[] args)
        {
            HandleFormatException();
            Console.WriteLine("\nProgram execution continues safely.");
        }
    }
}
