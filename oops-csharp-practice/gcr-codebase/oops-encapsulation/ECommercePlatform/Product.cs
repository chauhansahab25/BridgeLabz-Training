using System;

namespace CG_Practice.oopscsharp.ECommercePlatform
{
    // base product class
    abstract class Product
    {
        private int productId;
        private string name;
        private double price;

        public int ProductId { get { return productId; } set { productId = value; } }
        public string Name { get { return name; } set { name = value; } }
        public double Price { get { return price; } set { price = value; } }

        public Product(int id, string productName, double cost)
        {
            productId = id;
            name = productName;
            price = cost;
        }

        // must be implemented by child classes
        public abstract double CalculateDiscount();

        public void ShowDetails()
        {
            Console.WriteLine("ID: " + productId + " | " + name + " - $" + price);
        }
    }
}