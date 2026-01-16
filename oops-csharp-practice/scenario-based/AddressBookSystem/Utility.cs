using System;

namespace CG_Practice.oopsscenario.AddressBookSystem
{
    // UC1: Utility class for input operations
    public class Utility
    {
        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static int GetIntInput(string prompt)
        {
            Console.Write(prompt);
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("Invalid input. " + prompt);
            }
            return result;
        }
    }
}
