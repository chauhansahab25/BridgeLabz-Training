using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // product class for shopping cart
    class Product
    {
        // static variable - shared by all products
        public static double Discount = 10.0; // 10% discount

        // readonly - cant change after assignment
        public readonly string ProductID;
        
        // regular variables
        public string ProductName;
        public double Price;
        public int Quantity;

        // constructor using this keyword
        public Product(string ProductName, double Price, int Quantity, string ProductID)
        {
            this.ProductName = ProductName;  // this resolves ambiguity
            this.Price = Price;              // this resolves ambiguity
            this.Quantity = Quantity;        // this resolves ambiguity
            this.ProductID = ProductID;      // this resolves ambiguity
        }

        // static method
        public static void UpdateDiscount(double newDiscount)
        {
            Discount = newDiscount;
            Console.WriteLine("Discount updated to: " + Discount + "%");
        }

        public void showProduct()
        {
            Console.WriteLine("Product: " + ProductName);
            Console.WriteLine("ID: " + ProductID);
            Console.WriteLine("Price: $" + Price);
            Console.WriteLine("Quantity: " + Quantity);
            Console.WriteLine("Discount: " + Discount + "%");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // create products
            Product p1 = new Product("Laptop", 999.99, 2, "P001");
            Product p2 = new Product("Mouse", 25.50, 5, "P002");

            // using is operator to check type
            object obj = p1;
            if (obj is Product)
            {
                Console.WriteLine("Object is Product - showing details:");
                p1.showProduct();
            }

            p2.showProduct();

            // update discount using static method
            Product.UpdateDiscount(15.0);
            
            Console.WriteLine("After discount update:");
            p1.showProduct();

            Console.ReadLine();
        }
    }
}