// // Priority Customer Processing
// // Problem
// // A customer service center has N customers waiting in a queue.
// // Each customer has:
// // Customer ID
// // Priority
// // There are two priority levels:
// // 1 → High priority
// // 2 → Normal priority
// // Customers initially enter the queue in the given order.
// // The service center follows these rules:
// // Take the customer from the front of the queue.
// // If the customer's priority is 1, serve the customer and remove them permanently from the queue.
// // If the customer's priority is 2, move the customer to the back of the queue.
// // Continue until all customers are served.
// // Print the order in which the customers are served.
// // Input Format
// // The first line contains an integer N, representing the number of customers.
// // The next N lines contain two integers:
// // CustomerID Priority
// // It is guaranteed that at least one customer has priority 1.
// // Input
// // 5
// // 101 2
// // 102 1
// // 103 2
// // 104 1
// // 105 2
// // Output
// // 102 104 101 103 105

// using System;
// class Customer
// {
//     public int Id { get; set; }
//     public int priority { get; set; }
//     public Customer(int id, int priority)
//     {
//         this.Id = id;
//         this.priority = priority;
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Enter the number of customers");
//         int n = Convert.ToInt32(Console.ReadLine());
//         Queue<Customer> queue = new Queue<Customer>();
//         Console.WriteLine("Enter the customer details");
//         for (int i = 0; i < n; i++)
//         {
//             string[] inp = Console.ReadLine().Split();
//             int id = Convert.ToInt32(inp[0]);
//             int priority = Convert.ToInt32(inp[1]);
//             queue.Enqueue(new Customer(id, priority));
//         }
//         List<int> result = new List<int>();
//         while (queue.Count > 0)
//         {
//             Customer customer = queue.Dequeue();
//             if (customer.priority == 1)
//             {
//                 result.Add(customer.Id);
//             }
//             else
//             {
//                 queue.Enqueue(customer);
//             }
//         }
//         for (int i = 0; i < result.Count; i++)
//         {
//             Console.Write(result[i] + " ");
//         }



//     }
// }