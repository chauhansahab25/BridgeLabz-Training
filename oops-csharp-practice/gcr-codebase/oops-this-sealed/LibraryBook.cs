using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // book class for library
    class Book
    {
        // static variable - shared by all books
        public static string LibraryName = "City Library";

        // readonly - cant change after assignment
        public readonly string ISBN;
        
        // regular variables
        public string Title;
        public string Author;

        // constructor using this keyword
        public Book(string Title, string Author, string ISBN)
        {
            this.Title = Title;      // this resolves ambiguity
            this.Author = Author;    // this resolves ambiguity  
            this.ISBN = ISBN;        // this resolves ambiguity
        }

        // static method
        public static void DisplayLibraryName()
        {
            Console.WriteLine("Library: " + LibraryName);
        }

        public void showBook()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // create books
            Book book1 = new Book("C# Programming", "Microsoft", "978-123");
            Book book2 = new Book("Web Development", "John Doe", "978-456");

            // using is operator to check type
            object obj = book1;
            if (obj is Book)
            {
                Console.WriteLine("Object is Book - showing details:");
                book1.showBook();
            }

            book2.showBook();

            // call static method
            Book.DisplayLibraryName();

            Console.ReadLine();
        }
    }
}