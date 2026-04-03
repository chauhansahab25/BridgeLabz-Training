using System;

namespace BridgeLabsTrainingVS.ScenarioBased.FlashDealz
{
    public class FlashUtility
    {
        public static void ShowMenu()
        {
            Console.WriteLine("\n1. Add Product");
            Console.WriteLine("2. Sort by Discount (Quick Sort)");
            Console.WriteLine("3. Show Deals");
            Console.WriteLine("4. Exit");
            Console.Write("Select: ");
        }

        public static string GetString(string prompt)
        {
            Console.Write($"    {prompt}: ");
            return Console.ReadLine() ?? "";
        }

        public static int GetInt(string prompt)
        {
            Console.Write($"    {prompt}: ");
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("    Invalid input. Enter number: ");
            }
            return value;
        }
    }
}
