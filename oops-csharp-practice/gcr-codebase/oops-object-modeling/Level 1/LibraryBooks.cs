using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // book class - can exist independently
    class Book
    {
        public string Title;
        public string Author;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void showBook()
        {
            Console.WriteLine("Book: " + Title + " by " + Author);
        }
    }

    // library class - has many books (aggregation)
    class Library
    {
        public string LibraryName;
        public List<Book> books;  // list of books

        public Library(string name)
        {
            LibraryName = name;
            books = new List<Book>();  // initialize empty list
        }

        // add book to library
        public void addBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Added book to " + LibraryName);
        }

        // show all books in library
        public void showAllBooks()
        {
            Console.WriteLine("Books in " + LibraryName + ":");
            foreach (Book book in books)
            {
                book.showBook();
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // create books - they exist independently
            Book book1 = new Book("C# Programming", "Microsoft");
            Book book2 = new Book("Web Development", "John Doe");
            Book book3 = new Book("Database Design", "Jane Smith");

            // create libraries
            Library lib1 = new Library("City Library");
            Library lib2 = new Library("College Library");

            // add books to libraries (aggregation)
            lib1.addBook(book1);
            lib1.addBook(book2);
            
            lib2.addBook(book2);  // same book can be in multiple libraries
            lib2.addBook(book3);

            // show library contents
            lib1.showAllBooks();
            lib2.showAllBooks();

            // books still exist even if library is removed
            Console.WriteLine("Books exist independently:");
            book1.showBook();

            Console.ReadLine();
        }
    }
}