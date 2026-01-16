using System;

namespace CG_Practice.oopsscenario.AddressBookSystem
{
    //UC1 Utility class
    public class Utility
    {
        //UC2 get string input
        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        //UC2 get integer input
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
