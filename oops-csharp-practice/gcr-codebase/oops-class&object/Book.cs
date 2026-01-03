using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // Book class to store book information
    class Book
    {
        public string title;  // book title
        public string author; // book author name
        public double price;  // book price
        
        // method to print book details
        public void printDetails()
        {
            Console.WriteLine("Book Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: $" + price);
        }
    }

    class Program
    {
        static void Main()
        {
            Book b = new Book(); // create book object
            // set book properties
            b.title = "Harry Potter";
            b.author = "J.K. Rowling";
            b.price = 15.99;
            
            b.printDetails(); // display book info
            
            Console.ReadLine(); // wait for enter key
        }
    }
}