using System;
using System.Collections.Generic;

public class Book
{
    public string Isbn;
    public string Title;
    public bool IsAvailable;

    public Book(string isbn, string title, bool isAvailable)
    {
        Isbn = isbn;
        Title = title;
        IsAvailable = isAvailable;
    }
}

public class Library
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

    public void AddBook(Book b)
    {
        int left = 0;
        int right = books.Count;
        while (left < right)
        {
            int mid = (left + right) / 2;

            if (string.Compare(books[mid].Isbn, b.Isbn) < 0)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }
        books.Insert(left, b);
    }

    public Book FindByIsbn(string isbn)
    {
        int left = 0;
        int right = books.Count - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;

            int result = string.Compare(
                books[mid].Isbn,
                isbn
            );
            if (result == 0)
            {
                return books[mid];
            }
            else if (result < 0)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return null;
    }

    public bool CheckOut(string isbn)
    {
        Book book = FindByIsbn(isbn);
        if (book == null)
        {
            return false;
        }
        if (!book.IsAvailable)
        {
            return false;
        }
        book.IsAvailable = false;
        return true;
    }

    public void ShowAllBooks()
    {
        foreach (Book book in books)
        {
            string status;
            if (book.IsAvailable)
            {
                status = "Available";
            }
            else
            {
                status = "Not Available";
            }
            Console.WriteLine(
                "ISBN: " + book.Isbn +
                ", Title: " + book.Title +
                ", Status: " + status
            );
        }
    }
}
class Program
{
    static void Main()
    {
        Library lib = new Library();
        int choice;
        do
        {
            Console.WriteLine("\n1. Add Book");
            Console.WriteLine("2. Find Book");
            Console.WriteLine("3. Check Out Book");
            Console.WriteLine("4. Show All Books");
            Console.WriteLine("5. Exit");

            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter ISBN: ");
                    string isbn = Console.ReadLine();
                    Console.Write("Enter Book Title: ");
                    string title = Console.ReadLine();
                    lib.AddBook(new Book(isbn, title, true));
                    Console.WriteLine("Book added.");
                    break;
                case 2:
                    Console.Write("Enter ISBN to search: ");
                    string searchIsbn = Console.ReadLine();
                    Book found = lib.FindByIsbn(searchIsbn);
                    if (found == null)
                    {
                        Console.WriteLine("Book not found.");
                    }
                    else
                    {
                        Console.WriteLine("Book Found:");
                        Console.WriteLine("Title: " + found.Title);
                        Console.WriteLine(
                            "Available: " + found.IsAvailable
                        );
                    }
                    break;
                case 3:
                    Console.Write("Enter ISBN to check out: ");
                    string checkoutIsbn = Console.ReadLine();
                    bool success = lib.CheckOut(checkoutIsbn);
                    if (success)
                    {
                        Console.WriteLine("Book checked out successfully.");
                    }
                    else
                    {
                        Console.WriteLine(
                            "Book not found or already checked out."
                        );
                    }
                    break;
                case 4:
                    lib.ShowAllBooks();
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        } while (choice != 5);
    }
}