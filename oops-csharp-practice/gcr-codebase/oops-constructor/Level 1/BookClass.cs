using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // Book class with constructors
    class Book
    {
        public string title;
        public string author;
        public double price;

        // default constructor
        public Book()
        {
            title = "Unknown";
            author = "Unknown";
            price = 0.0;
        }

        // parameterized constructor
        public Book(string t, string a, double p)
        {
            title = t;
            author = a;
            price = p;
        }

        // method to display book info
        public void showBookInfo()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: $" + price);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // using default constructor
            Book book1 = new Book();
            Console.WriteLine("Book 1 (Default Constructor):");
            book1.showBookInfo();

            // using parameterized constructor
            Book book2 = new Book("Harry Potter", "J.K. Rowling", 25.99);
            Console.WriteLine("Book 2 (Parameterized Constructor):");
            book2.showBookInfo();

            Console.ReadLine();
        }
    }
}