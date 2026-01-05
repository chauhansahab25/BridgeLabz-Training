using System;
using System.Collections.Generic;

namespace ECommercePlatform
{
    // abstract product class
    abstract class Product
    {
        private int productId;
        private string name;
        private double price;

        // properties for encapsulation
        public int ProductId 
        { 
            get { return productId; } 
            set { productId = value; } 
        }
        
        public string Name 
        { 
            get { return name; } 
            set { name = value; } 
        }
        
        public double Price 
        { 
            get { return price; } 
            set { price = value; } 
        }

        public Product(int id, string productName, double productPrice)
        {
            productId = id;
            name = productName;
            price = productPrice;
        }

        // abstract method
        public abstract double CalculateDiscount();

        public void DisplayProduct()
        {
            Console.WriteLine("Product: " + name + " (ID: " + productId + ")");
            Console.WriteLine("Price: $" + price);
        }
    }

    // interface for tax calculation
    interface ITaxable
    {
        double CalculateTax();
        string GetTaxDetails();
    }

    // electronics class
    class Electronics : Product, ITaxable
    {
        public Electronics(int id, string name, double price) 
            : base(id, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return Price * 0.1;  // 10% discount
        }

        public double CalculateTax()
        {
            return Price * 0.18;  // 18% GST
        }

        public string GetTaxDetails()
        {
            return "GST 18%";
        }
    }

    // clothing class
    class Clothing : Product, ITaxable
    {
        public Clothing(int id, string name, double price) 
            : base(id, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return Price * 0.15;  // 15% discount
        }

        public double CalculateTax()
        {
            return Price * 0.12;  // 12% GST
        }

        public string GetTaxDetails()
        {
            return "GST 12%";
        }
    }

    // groceries class
    class Groceries : Product
    {
        public Groceries(int id, string name, double price) 
            : base(id, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return Price * 0.05;  // 5% discount
        }
    }

    class Program
    {
        // method to calculate final price (polymorphism)
        static void CalculateFinalPrice(Product product)
        {
            double finalPrice = product.Price;
            double discount = product.CalculateDiscount();
            finalPrice = finalPrice - discount;

            // check if taxable
            if (product is ITaxable)
            {
                ITaxable taxableProduct = (ITaxable)product;
                double tax = taxableProduct.CalculateTax();
                finalPrice = finalPrice + tax;
                
                Console.WriteLine("Tax: $" + tax + " (" + taxableProduct.GetTaxDetails() + ")");
            }

            Console.WriteLine("Discount: $" + discount);
            Console.WriteLine("Final Price: $" + finalPrice);
        }

        static void Main()
        {
            // create different products
            List<Product> products = new List<Product>();
            
            products.Add(new Electronics(1, "laptop", 1000));
            products.Add(new Clothing(2, "shirt", 50));
            products.Add(new Groceries(3, "rice", 20));

            Console.WriteLine("E-Commerce Platform");
            Console.WriteLine("==================");

            // process all products using polymorphism
            foreach (Product product in products)
            {
                product.DisplayProduct();
                CalculateFinalPrice(product);  // polymorphic behavior
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}