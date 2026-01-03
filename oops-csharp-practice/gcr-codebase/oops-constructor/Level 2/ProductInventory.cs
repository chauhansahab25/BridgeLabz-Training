using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // Product inventory system
    class Product
    {
        // instance variables - different for each product
        public string productName;
        public double price;
        
        // class variable - shared among all products
        public static int totalProducts = 0;

        // constructor
        public Product(string name, double p)
        {
            productName = name;
            price = p;
            totalProducts++; // increment total count when new product created
        }

        // instance method - shows details of this specific product
        public void DisplayProductDetails()
        {
            Console.WriteLine("Product Name: " + productName);
            Console.WriteLine("Price: $" + price);
            Console.WriteLine();
        }

        // class method - shows total products (static method)
        public static void DisplayTotalProducts()
        {
            Console.WriteLine("Total Products Created: " + totalProducts);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // create some products
            Product p1 = new Product("Laptop", 999.99);
            Product p2 = new Product("Mouse", 25.50);
            Product p3 = new Product("Keyboard", 75.00);

            // display individual product details
            Console.WriteLine("Product Details:");
            p1.DisplayProductDetails();
            p2.DisplayProductDetails();
            p3.DisplayProductDetails();

            // display total products using class method
            Product.DisplayTotalProducts();

            Console.ReadLine();
        }
    }
}