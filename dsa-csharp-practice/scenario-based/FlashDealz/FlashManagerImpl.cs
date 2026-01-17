using System;


namespace BridgeLabsTrainingVS.ScenarioBased.FlashDealz
{
    public class FlashManagerImpl : IFlashManager
    {
        public Product[] Inventory;
        public int Count;
        public int Capacity = 50;

        public FlashManagerImpl()
        {
            Inventory = new Product[Capacity];
            Count = 0;
        }

        public void AddProduct(string name, int discount)
        {
            if (Count >= Capacity)
            {
                Console.WriteLine("    [!] Inventory Full.");
                return;
            }

            Inventory[Count] = new Product(name, discount);
            Count++;
            Console.WriteLine($"    Added: {name} ({discount}% OFF)");
        }

        public void SortProducts()
        {
            if (Count > 1)
            {
                PerformQuickSort(Inventory, 0, Count - 1);
                Console.WriteLine("    Products sorted by Discount (High to Low).");
            }
        }

        private void PerformQuickSort(Product[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                PerformQuickSort(arr, low, pi - 1);
                PerformQuickSort(arr, pi + 1, high);
            }
        }

        private int Partition(Product[] arr, int low, int high)
        {
            int pivot = arr[high].DiscountPercentage;
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j].DiscountPercentage > pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }

            (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
            return i + 1;
        }

        public void DisplayDeals()
        {
            Console.WriteLine("\n=== FLASH SALE DEALS ===");
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Inventory[i].Name} - {Inventory[i].DiscountPercentage}% OFF");
            }
        }
    }
}
