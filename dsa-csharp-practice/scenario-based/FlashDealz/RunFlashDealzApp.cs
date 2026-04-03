using System;

namespace BridgeLabsTrainingVS.ScenarioBased.FlashDealz
{
    public class RunFlashDealzApp
    {
        public static void Main(string[] args)
        {
            IFlashManager manager = new FlashManagerImpl();
            bool running = true;

            Console.WriteLine("=== FLASH DEALZ MANAGER ===");

            while (running)
            {
                FlashUtility.ShowMenu();
                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        string name = FlashUtility.GetString("Product Name");
                        int discount = FlashUtility.GetInt("Discount %");
                        manager.AddProduct(name, discount);
                        break;

                    case "2":
                        manager.SortProducts();
                        break;

                    case "3":
                        manager.DisplayDeals();
                        break;

                    case "4":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
