using System;
using System.Collections.Generic;

namespace CG_Practice.oopscsharp.ECommercePlatform
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== E-COMMERCE PLATFORM ===");
            Console.WriteLine();

            // create different products
            List<Product> products = new List<Product>();
            products.Add(new Electronics(1, "Laptop", 50000, 24));
            products.Add(new Clothing(2, "T-Shirt", 1500, "L"));
            products.Add(new Groceries(3, "Rice", 200, DateTime.Now.AddDays(30)));
            products.Add(new Electronics(4, "Phone", 25000, 12));

            Console.WriteLine("=== PRODUCT DETAILS ===");
            foreach (Product item in products)
            {
                item.ShowDetails();
                double finalPrice = CalculateFinalPrice(item);
                Console.WriteLine("Final Price: $" + finalPrice);
                Console.WriteLine("------------------------");
            }

            Console.ReadKey();
        }

        // polymorphism - calculates final price for any product type
        static double CalculateFinalPrice(Product item)
        {
            double discount = item.CalculateDiscount();
            double tax = 0;

            if (item is ITaxable)
            {
                ITaxable taxableItem = (ITaxable)item;
                tax = taxableItem.CalculateTax();
                Console.WriteLine(taxableItem.GetTaxDetails());
            }

            double finalPrice = item.Price + tax - discount;
            Console.WriteLine("Discount: $" + discount + " | Tax: $" + tax);
            return finalPrice;
        }
    }
}