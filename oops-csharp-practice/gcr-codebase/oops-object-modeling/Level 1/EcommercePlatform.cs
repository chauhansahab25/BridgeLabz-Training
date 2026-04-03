using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // product class
    class Product
    {
        public string ProductName;
        public double Price;
        public int Quantity;

        public Product(string name, double price, int qty)
        {
            ProductName = name;
            Price = price;
            Quantity = qty;
        }

        public void showProduct()
        {
            Console.WriteLine(ProductName + " - $" + Price + " (Qty: " + Quantity + ")");
        }
    }

    // order class - aggregates products
    class Order
    {
        public int OrderId;
        public List<Product> products;  // order contains products (aggregation)
        public double TotalAmount;

        public Order(int id)
        {
            OrderId = id;
            products = new List<Product>();
            TotalAmount = 0;
        }

        // add product to order
        public void addProduct(Product product)
        {
            products.Add(product);
            TotalAmount += product.Price * product.Quantity;
            Console.WriteLine("Added " + product.ProductName + " to order");
        }

        public void showOrder()
        {
            Console.WriteLine("Order #" + OrderId + ":");
            foreach (Product product in products)
            {
                product.showProduct();
            }
            Console.WriteLine("Total: $" + TotalAmount);
            Console.WriteLine();
        }
    }

    // customer class
    class Customer
    {
        public string Name;
        public string Email;
        public List<Order> orders;  // customer has orders

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
            orders = new List<Order>();
        }

        // place order (communication)
        public Order placeOrder()
        {
            int orderId = orders.Count + 1;
            Order order = new Order(orderId);
            orders.Add(order);
            Console.WriteLine(Name + " placed order #" + orderId);
            return order;
        }

        public void showCustomerOrders()
        {
            Console.WriteLine(Name + "'s orders:");
            foreach (Order order in orders)
            {
                order.showOrder();
            }
        }
    }

    // ecommerce platform class
    class EcommercePlatform
    {
        public string PlatformName;
        public List<Customer> customers;
        public List<Product> availableProducts;

        public EcommercePlatform(string name)
        {
            PlatformName = name;
            customers = new List<Customer>();
            availableProducts = new List<Product>();
        }

        // register customer
        public void registerCustomer(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine(customer.Name + " registered on " + PlatformName);
        }

        // add product to platform
        public void addProduct(Product product)
        {
            availableProducts.Add(product);
            Console.WriteLine(product.ProductName + " added to platform");
        }
    }

    class Program
    {
        static void Main()
        {
            // create platform
            EcommercePlatform platform = new EcommercePlatform("ShopEasy");

            // create products
            Product p1 = new Product("laptop", 999.99, 1);
            Product p2 = new Product("mouse", 25.50, 2);
            Product p3 = new Product("keyboard", 75.00, 1);

            // add products to platform
            platform.addProduct(p1);
            platform.addProduct(p2);
            platform.addProduct(p3);

            // create customer
            Customer customer = new Customer("john", "john@email.com");
            platform.registerCustomer(customer);

            // customer places order
            Order order1 = customer.placeOrder();
            order1.addProduct(p1);
            order1.addProduct(p2);

            Order order2 = customer.placeOrder();
            order2.addProduct(p3);

            // show customer orders
            customer.showCustomerOrders();

            Console.ReadLine();
        }
    }
}