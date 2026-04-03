using System;

namespace HealthClinicApp
{
    public class BillingUtility
    {
        public static void PressAnyKey()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        public static void DisplayHeader(string title)
        {
            Console.WriteLine("=" + new string('=', title.Length + 2) + "=");
            Console.WriteLine(" " + title);
            Console.WriteLine("=" + new string('=', title.Length + 2) + "=");
            Console.WriteLine();
        }
    }
}
