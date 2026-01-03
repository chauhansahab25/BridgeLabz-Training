using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // Library book system
    class LibraryBook
    {
        public string title;
        public string author;
        public double price;
        public bool availability; // true = available, false = borrowed

        // constructor
        public LibraryBook(string t, string a, double p)
        {
            title = t;
            author = a;
            price = p;
            availability = true; // book is available by default
        }

        // method to borrow book
        public void BorrowBook()
        {
            if (availability == true)
            {
                availability = false;
                Console.WriteLine("Book '" + title + "' has been borrowed successfully!");
            }
            else
            {
                Console.WriteLine("Sorry, book '" + title + "' is already borrowed.");
            }
        }

        // method to return book
        public void returnBook()
        {
            availability = true;
            Console.WriteLine("Book '" + title + "' has been returned.");
        }

        // display book status
        public void showBookStatus()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: $" + price);
            Console.WriteLine("Status: " + (availability ? "Available" : "Borrowed"));
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // create library book
            LibraryBook book = new LibraryBook("C# Programming", "Microsoft", 45.99);
            
            Console.WriteLine("Initial book status:");
            book.showBookStatus();

            // try to borrow book
            book.BorrowBook();
            book.showBookStatus();

            // try to borrow again
            book.BorrowBook();

            // return book
            book.returnBook();
            book.showBookStatus();

            Console.ReadLine();
        }
    }
}