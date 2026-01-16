using System;
using System.Collections;

namespace CG_Practice.dsascenario.BookBuddy
{
    class Bookshelf : IBookshelf
    {
        private ArrayList books;

        public Bookshelf()
        {
            books = new ArrayList();
        }

        public void AddBook(string title, string author)
        {
            Book book = new Book(title, author);
            books.Add(book);
            Console.WriteLine($"Book '{book}' added successfully!");
        }

        public void SortBooksAlphabetically()
        {
            BookUtility.SortBooks(books);
            Console.WriteLine("Books sorted alphabetically by title.");
        }

        public ArrayList SearchByAuthor(string author)
        {
            ArrayList result = BookUtility.FilterByAuthor(books, author);
            
            if (result.Count == 0)
                Console.WriteLine($"No books found by author '{author}'");
            else
                BookUtility.DisplayBooks(result);
            
            return result;
        }

        public string[] ExportBooks()
        {
            string[] bookArray = BookUtility.ConvertToArray(books);
            Console.WriteLine($"Exported {bookArray.Length} books to array.");
            return bookArray;
        }

        public void DisplayAllBooks()
        {
            BookUtility.DisplayBooks(books);
        }
    }
}
