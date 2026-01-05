using System;
using System.Collections.Generic;

namespace LibraryManagement
{
    // abstract library item class
    abstract class LibraryItem
    {
        private int itemId;
        private string title;
        private string author;

        // properties for encapsulation
        public int ItemId 
        { 
            get { return itemId; } 
            set { itemId = value; } 
        }
        
        public string Title 
        { 
            get { return title; } 
            set { title = value; } 
        }
        
        public string Author 
        { 
            get { return author; } 
            set { author = value; } 
        }

        public LibraryItem(int id, string itemTitle, string itemAuthor)
        {
            itemId = id;
            title = itemTitle;
            author = itemAuthor;
        }

        // abstract method
        public abstract int GetLoanDuration();

        // concrete method
        public void GetItemDetails()
        {
            Console.WriteLine("ID: " + itemId);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Loan Duration: " + GetLoanDuration() + " days");
        }
    }

    // interface for reservation
    interface IReservable
    {
        void ReserveItem(string borrowerName);
        bool CheckAvailability();
    }

    // book class
    class Book : LibraryItem, IReservable
    {
        private bool isAvailable;
        private string reservedBy;

        public Book(int id, string title, string author) 
            : base(id, title, author)
        {
            isAvailable = true;
        }

        public override int GetLoanDuration()
        {
            return 14;  // 14 days for books
        }

        public void ReserveItem(string borrowerName)
        {
            if (isAvailable)
            {
                isAvailable = false;
                reservedBy = borrowerName;
                Console.WriteLine("Book reserved by: " + borrowerName);
            }
            else
            {
                Console.WriteLine("Book already reserved by: " + reservedBy);
            }
        }

        public bool CheckAvailability()
        {
            return isAvailable;
        }
    }

    // magazine class
    class Magazine : LibraryItem, IReservable
    {
        private bool isAvailable;
        private string reservedBy;

        public Magazine(int id, string title, string author) 
            : base(id, title, author)
        {
            isAvailable = true;
        }

        public override int GetLoanDuration()
        {
            return 7;  // 7 days for magazines
        }

        public void ReserveItem(string borrowerName)
        {
            if (isAvailable)
            {
                isAvailable = false;
                reservedBy = borrowerName;
                Console.WriteLine("Magazine reserved by: " + borrowerName);
            }
            else
            {
                Console.WriteLine("Magazine already reserved by: " + reservedBy);
            }
        }

        public bool CheckAvailability()
        {
            return isAvailable;
        }
    }

    // dvd class
    class DVD : LibraryItem, IReservable
    {
        private bool isAvailable;
        private string reservedBy;

        public DVD(int id, string title, string director) 
            : base(id, title, director)
        {
            isAvailable = true;
        }

        public override int GetLoanDuration()
        {
            return 3;  // 3 days for DVDs
        }

        public void ReserveItem(string borrowerName)
        {
            if (isAvailable)
            {
                isAvailable = false;
                reservedBy = borrowerName;
                Console.WriteLine("DVD reserved by: " + borrowerName);
            }
            else
            {
                Console.WriteLine("DVD already reserved by: " + reservedBy);
            }
        }

        public bool CheckAvailability()
        {
            return isAvailable;
        }
    }

    class Program
    {
        static void Main()
        {
            // create different library items
            List<LibraryItem> items = new List<LibraryItem>();
            
            items.Add(new Book(1, "C# Programming", "john doe"));
            items.Add(new Magazine(2, "Tech Today", "jane smith"));
            items.Add(new DVD(3, "Learning C#", "bob wilson"));

            Console.WriteLine("Library Management System");
            Console.WriteLine("========================");

            // process all items using polymorphism
            foreach (LibraryItem item in items)
            {
                item.GetItemDetails();  // polymorphic call

                // check if reservable
                if (item is IReservable)
                {
                    IReservable reservableItem = (IReservable)item;
                    Console.WriteLine("Available: " + reservableItem.CheckAvailability());
                    reservableItem.ReserveItem("alice");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}