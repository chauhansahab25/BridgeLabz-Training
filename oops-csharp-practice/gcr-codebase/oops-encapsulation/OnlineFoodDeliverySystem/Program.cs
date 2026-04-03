using System;
using System.Collections.Generic;

namespace CG_Practice.oopscsharp.OnlineFoodDeliverySystem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ONLINE FOOD DELIVERY SYSTEM ===");
            Console.WriteLine();

            // create different food items
            List<FoodItem> foodItems = new List<FoodItem>();
            foodItems.Add(new VegItem("Veg Burger", 150, 2));
            foodItems.Add(new NonVegItem("Chicken Pizza", 300, 1));
            foodItems.Add(new VegItem("Pasta", 200, 1));

            Console.WriteLine("=== FOOD ORDER ===");
            double totalBill = 0;

            foreach (FoodItem item in foodItems)
            {
                item.GetItemDetails();

                if (item is IDiscountable)
                {
                    IDiscountable discountItem = (IDiscountable)item;
                    discountItem.ApplyDiscount(10); // 10% discount
                    Console.WriteLine(discountItem.GetDiscountDetails());
                }

                double itemTotal = item.CalculateTotalPrice();
                Console.WriteLine("Item Total: $" + itemTotal);
                totalBill += itemTotal;
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("TOTAL BILL: $" + totalBill);
            Console.ReadKey();
        }
    }
}