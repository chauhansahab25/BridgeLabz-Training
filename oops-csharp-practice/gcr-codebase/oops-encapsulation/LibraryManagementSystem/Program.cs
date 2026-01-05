using System;
using System.Collections.Generic;

namespace CG_Practice.oopscsharp.LibraryManagementSystem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== LIBRARY MANAGEMENT SYSTEM ===");
            Console.WriteLine();

            // create different library items
            List<LibraryItem> items = new List<LibraryItem>();
            items.Add(new Book(1, "C# Programming", "John Smith", 500));
            items.Add(new Magazine(2, "Tech Today", "Editor", "Jan 2024"));
            items.Add(new DVD(3, "Learning OOP", "Director", 120));

            Console.WriteLine("=== LIBRARY ITEMS ===");
            foreach (LibraryItem item in items)
            {
                item.GetItemDetails();

                if (item is IReservable)
                {
                    IReservable reservable = (IReservable)item;
                    bool available = reservable.CheckAvailability();
                    Console.WriteLine("Available: " + available);
                    
                    if (available)
                    {
                        reservable.ReserveItem("Student123");
                    }
                }
                Console.WriteLine("------------------------");
            }

            Console.ReadKey();
        }
    }
}