using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // book class for library
    class Book
    {
        public string ISBN;         // everyone can see
        protected string title;     // only this class and child classes
        private string author;      // only this class

        public Book(string isbn, string t, string a)
        {
            ISBN = isbn;
            title = t;
            author = a;
        }

        // get author name
        public string getAuthor()
        {
            return author;
        }

        // change author name
        public void setAuthor(string newAuthor)
        {
            author = newAuthor;
            Console.WriteLine("Author changed to: " + author);
        }

        public void displayBook()
        {
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
        }
    }

    // ebook class inherits from book
    class EBook : Book
    {
        public double fileSize;
        public string format;

        public EBook(string isbn, string t, string a, double size, string fmt) 
            : base(isbn, t, a)
        {
            fileSize = size;
            format = fmt;
        }

        public void showEBookDetails()
        {
            Console.WriteLine("E-Book Info:");
            Console.WriteLine("ISBN: " + ISBN);              // public - can access
            Console.WriteLine("Title: " + title);            // protected - can access
            Console.WriteLine("Author: " + getAuthor());     // private - need method
            Console.WriteLine("Size: " + fileSize + " MB");
            Console.WriteLine("Format: " + format);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("978-123456", "C# Guide", "Microsoft");
            book1.displayBook();
            Console.WriteLine();

            book1.setAuthor("John Doe");
            Console.WriteLine();

            EBook ebook1 = new EBook("978-789012", "Web Dev", "Jane", 15.5, "PDF");
            ebook1.showEBookDetails();

            Console.ReadLine();
        }
    }
}