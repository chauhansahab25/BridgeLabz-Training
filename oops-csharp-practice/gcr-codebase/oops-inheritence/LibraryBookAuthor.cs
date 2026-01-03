using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // base book class
    class Book
    {
        public string Title;           // book title
        public int PublicationYear;    // year published

        public Book(string title, int year)
        {
            Title = title;
            PublicationYear = year;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Publication Year: " + PublicationYear);
        }
    }

    // author class inherits from book (single inheritance)
    class Author : Book
    {
        public string Name;  // author name
        public string Bio;   // author biography

        public Author(string title, int year, string name, string bio) 
            : base(title, year)  // call parent constructor
        {
            Name = name;
            Bio = bio;
        }

        // override parent method
        public override void DisplayInfo()
        {
            base.DisplayInfo();  // show book info first
            Console.WriteLine("Author: " + Name);
            Console.WriteLine("Bio: " + Bio);
        }
    }

    class Program
    {
        static void Main()
        {
            // create book with author info
            Author book1 = new Author("C# Programming", 2020, "john doe", "experienced programmer");
            Author book2 = new Author("web development", 2021, "jane smith", "web expert");

            // display book and author info
            Console.WriteLine("Book 1 Details:");
            book1.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Book 2 Details:");
            book2.DisplayInfo();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}