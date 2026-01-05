using System;
using System.Collections.Generic;

namespace FoodDelivery
{
    // abstract food item class
    abstract class FoodItem
    {
        private string itemName;
        private double price;
        private int quantity;

        // properties for encapsulation
        public string ItemName 
        { 
            get { return itemName; } 
            set { itemName = value; } 
        }
        
        public double Price 
        { 
            get { return price; } 
            set { price = value; } 
        }
        
        public int Quantity 
        { 
            get { return quantity; } 
            set { quantity = value; } 
        }

        public FoodItem(string name, double itemPrice, int qty)
        {
            itemName = name;
            price = itemPrice;
            quantity = qty;
        }

        // abstract method
        public abstract double CalculateTotalPrice();

        // concrete method
        public void GetItemDetails()
        {
            Console.WriteLine("Item: " + itemName);
            Console.WriteLine("Price: $" + price);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Total: $" + CalculateTotalPrice());
        }
    }

    // interface for discount
    interface IDiscountable
    {
        void ApplyDiscount(double percentage);
        string GetDiscountDetails();
    }

    // veg item class
    class VegItem : FoodItem, IDiscountable
    {
        private double discountApplied;

        public VegItem(string name, double price, int quantity) 
            : base(name, price, quantity)
        {
            discountApplied = 0;
        }

        public override double CalculateTotalPrice()
        {
            double total = Price * Quantity;
            total = total - (total * discountApplied / 100);
            return total;
        }

        public void ApplyDiscount(double percentage)
        {
            discountApplied = percentage;
            Console.WriteLine("Veg discount applied: " + percentage + "%");
        }

        public string GetDiscountDetails()
        {
            return "Veg Item Discount: " + discountApplied + "%";
        }
    }

    // non-veg item class
    class NonVegItem : FoodItem, IDiscountable
    {
        private double discountApplied;

        public NonVegItem(string name, double price, int quantity) 
            : base(name, price, quantity)
        {
            discountApplied = 0;
        }

        public override double CalculateTotalPrice()
        {
            double total = Price * Quantity;
            total = total + (total * 0.1);  // 10% extra charge for non-veg
            total = total - (total * discountApplied / 100);
            return total;
        }

        public void ApplyDiscount(double percentage)
        {
            discountApplied = percentage;
            Console.WriteLine("Non-veg discount applied: " + percentage + "%");
        }

        public string GetDiscountDetails()
        {
            return "Non-Veg Item Discount: " + discountApplied + "% (after 10% extra charge)";
        }
    }

    class Program
    {
        static void Main()
        {
            // create different food items
            List<FoodItem> foodItems = new List<FoodItem>();
            
            foodItems.Add(new VegItem("veg burger", 8.99, 2));
            foodItems.Add(new NonVegItem("chicken pizza", 15.99, 1));
            foodItems.Add(new VegItem("salad", 6.50, 3));

            Console.WriteLine("Online Food Delivery System");
            Console.WriteLine("===========================");

            // process all items using polymorphism
            foreach (FoodItem item in foodItems)
            {
                item.GetItemDetails();

                // apply discount if possible
                if (item is IDiscountable)
                {
                    IDiscountable discountableItem = (IDiscountable)item;
                    discountableItem.ApplyDiscount(5);  // 5% discount
                    Console.WriteLine(discountableItem.GetDiscountDetails());
                    
                    Console.WriteLine("After discount: $" + item.CalculateTotalPrice());
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}