using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    class Book
    {
        static string LibraryName = "city library";  // same for all books

        readonly string ISBN;  // this cant be changed
        
        string Title;
        string Author;

        public Book(string Title, string Author, string ISBN)
        {
            this.Title = Title;      // using this to avoid confusion
            this.Author = Author;    
            this.ISBN = ISBN;        
        }

        static void DisplayLibraryName()
        {
            Console.WriteLine("library name: " + LibraryName);
        }

        void showBook()
        {
            Console.WriteLine("book: " + Title);
            Console.WriteLine("by: " + Author);
            Console.WriteLine("isbn: " + ISBN);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("c# book", "microsoft", "978-123");
            Book book2 = new Book("web dev", "john", "978-456");

            object obj = book1;
            if (obj is Book)  // checking if obj is book type
            {
                Console.WriteLine("its a book:");
                book1.showBook();
            }

            book2.showBook();
            Book.DisplayLibraryName();

            Console.ReadLine();
        }
    }
}