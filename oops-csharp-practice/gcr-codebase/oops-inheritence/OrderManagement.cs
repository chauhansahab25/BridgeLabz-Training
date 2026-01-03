using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // base order class (level 1)
    class Order
    {
        public int OrderId;      // order identifier
        public string OrderDate; // order date

        public Order(int orderId, string orderDate)
        {
            OrderId = orderId;
            OrderDate = orderDate;
        }

        public virtual string GetOrderStatus()
        {
            return "Order Placed";
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Order ID: " + OrderId);
            Console.WriteLine("Order Date: " + OrderDate);
            Console.WriteLine("Status: " + GetOrderStatus());
        }
    }

    // shipped order class inherits from order (level 2)
    class ShippedOrder : Order
    {
        public string TrackingNumber;  // additional attribute

        public ShippedOrder(int orderId, string orderDate, string trackingNumber) 
            : base(orderId, orderDate)  // call parent constructor
        {
            TrackingNumber = trackingNumber;
        }

        public override string GetOrderStatus()
        {
            return "Order Shipped";
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();  // call parent method
            Console.WriteLine("Tracking Number: " + TrackingNumber);
        }
    }

    // delivered order class inherits from shipped order (level 3)
    class DeliveredOrder : ShippedOrder
    {
        public string DeliveryDate;  // additional attribute

        public DeliveredOrder(int orderId, string orderDate, string trackingNumber, string deliveryDate) 
            : base(orderId, orderDate, trackingNumber)  // call parent constructor
        {
            DeliveryDate = deliveryDate;
        }

        public override string GetOrderStatus()
        {
            return "Order Delivered";
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();  // call parent method
            Console.WriteLine("Delivery Date: " + DeliveryDate);
        }
    }

    class Program
    {
        static void Main()
        {
            // create orders at different levels
            Order order1 = new Order(1001, "2024-01-01");
            ShippedOrder order2 = new ShippedOrder(1002, "2024-01-02", "TRK123456");
            DeliveredOrder order3 = new DeliveredOrder(1003, "2024-01-03", "TRK789012", "2024-01-05");

            // display order info (multilevel inheritance)
            Console.WriteLine("Basic Order:");
            order1.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Shipped Order:");
            order2.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Delivered Order:");
            order3.DisplayInfo();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}