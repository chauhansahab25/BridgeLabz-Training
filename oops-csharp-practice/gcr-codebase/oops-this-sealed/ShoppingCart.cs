using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    class Product
    {
        static double Discount = 10.0; // discount for all products

        readonly string ProductID;  // id wont change
        
        string ProductName;
        double Price;
        int Quantity;

        public Product(string ProductName, double Price, int Quantity, string ProductID)
        {
            this.ProductName = ProductName;  // this to avoid confusion
            this.Price = Price;              
            this.Quantity = Quantity;        
            this.ProductID = ProductID;      
        }

        static void UpdateDiscount(double newDiscount)
        {
            Discount = newDiscount;
            Console.WriteLine("discount changed to: " + Discount + "%");
        }

        void showProduct()
        {
            Console.WriteLine("product: " + ProductName);
            Console.WriteLine("id: " + ProductID);
            Console.WriteLine("price: $" + Price);
            Console.WriteLine("qty: " + Quantity);
            Console.WriteLine("discount: " + Discount + "%");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            Product p1 = new Product("laptop", 999.99, 2, "P001");
            Product p2 = new Product("mouse", 25.50, 5, "P002");

            object obj = p1;
            if (obj is Product)  // checking if product type
            {
                Console.WriteLine("yes its product:");
                p1.showProduct();
            }

            p2.showProduct();

            Product.UpdateDiscount(15.0);
            
            Console.WriteLine("after discount change:");
            p1.showProduct();

            Console.ReadLine();
        }
    }
}