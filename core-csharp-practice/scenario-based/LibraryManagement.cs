using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.scenariobased
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string status { get; set; }

        public Book(string title, string author, string status)
        {
            Title = title;
            Author = author;
            this.status = status;
        }
    }
    public class Library
    {
        private Book[] books;
        private int count;
        public Library(int capacity)
        {
            books = new Book[capacity];
            count = 0;
        }

        public void AddBook(string title ,string author,string Availability)
        {
            if(count < books.Length)
            {
                books[count] = new Book(title, author, "Avalaible");
                count++;
                Console.WriteLine("Book " + title + " " + "added");
            }
            else
            {
                Console.WriteLine("Library is full");
            }
        }

        public void SearchByPartialTitle(string searchTerm)
        {
            Console.WriteLine("Search result for" + searchTerm + ":");
            bool found = false;
            for (int i=0; i < count; i++)
            {
                if (books[i].Title.ToLower().Contains(searchTerm.ToLower()))
                {
                    Console.WriteLine("Title: " + books[i].Title + " " + "Author:" + books[i].Author + " Status: "  + books[i].status);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No Books found");
            }
        }
        public void DisplayAllBooks()
        {
            Console.WriteLine("All Books: ");
            for(int i=0; i<count; i++)
            {
                Console.WriteLine("Title: " + books[i].Title + " Author: " + books[i].Author + " Status :" + books[i].status);
            }
        }
        public void UpdateBookStatus(string title, string newStatus)
        {
            for (int i = 0; i < count; i++)
            {
                if (books[i].Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    books[i].status = newStatus;
                    Console.WriteLine("Book" +title + "status updated to" + newStatus);
                    return;
                }
            }
            Console.WriteLine("Book" + title + "not found.");
        }
    }
    class Program
    {
        static void Main()
        {
            Library library = new Library(5);
            library.AddBook("C# Programming", "John Doe", "Available");
            library.AddBook("Java Fundamentals", "Jane Smith", "Available");
            library.AddBook("Python Basics", "Mike Johnson", "Available");

            library.DisplayAllBooks();

            library.SearchByPartialTitle("java");
            library.UpdateBookStatus("Java Fundamentals", "Checked Out");
            library.DisplayAllBooks();
        }
    }

}

