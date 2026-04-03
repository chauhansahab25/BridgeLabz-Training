using System;

namespace CG_Practice.oopscsharp.OnlineFoodDeliverySystem
{
    // base food item class
    abstract class FoodItem
    {
        private string itemName;
        private double price;
        private int quantity;

        public string ItemName { get { return itemName; } set { itemName = value; } }
        public double Price { get { return price; } set { price = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }

        public FoodItem(string name, double cost, int qty)
        {
            itemName = name;
            price = cost;
            quantity = qty;
        }

        // must be implemented by child classes
        public abstract double CalculateTotalPrice();

        public void GetItemDetails()
        {
            Console.WriteLine("Item: " + itemName + " | Price: $" + price + " | Qty: " + quantity);
        }
    }
}