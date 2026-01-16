using System;
using System.Collections.Generic;

namespace CG_Practice.oopsscenario.BookShelf
{
    public class LibraryUtility : IBookService
    {
        private Dictionary<string, LinkedList<Book>> library;
        private HashSet<Book> bookSet;

        public LibraryUtility()
        {
            library = new Dictionary<string, LinkedList<Book>>();
            bookSet = new HashSet<Book>();
        }

        public void AddBook(string genre, Book book)
        {
            if (bookSet.Contains(book))
            {
                Console.WriteLine("Book already exists. Duplicate not allowed.");
                return;
            }

            if (!library.ContainsKey(genre))
            {
                library[genre] = new LinkedList<Book>();
            }

            library[genre].AddLast(book);
            bookSet.Add(book);

            Console.WriteLine("Book added successfully.");
        }

        public void RemoveBook(string genre, string bookTitle)
        {
            if (!library.ContainsKey(genre))
            {
                Console.WriteLine("Genre not found.");
                return;
            }

            LinkedList<Book> books = library[genre];

            foreach (Book book in books)
            {
                if (book.Title.Equals(bookTitle))
                {
                    books.Remove(book);
                    bookSet.Remove(book);
                    Console.WriteLine("Book removed successfully.");
                    return;
                }
            }

            Console.WriteLine("Book not found.");
        }

        public void DisplayBooks()
        {
            if (library.Count == 0)
            {
                Console.WriteLine("Library is empty.");
                return;
            }

            foreach (var genre in library)
            {
                Console.WriteLine($"\nGenre: {genre.Key}");
                foreach (Book book in genre.Value)
                {
                    Console.WriteLine(book);
                }
            }
        }
    }
}
