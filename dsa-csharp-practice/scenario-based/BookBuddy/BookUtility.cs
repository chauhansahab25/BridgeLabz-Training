using System;
using System.Collections;

namespace CG_Practice.dsascenario.BookBuddy
{
    class BookUtility
    {
        public static Book ParseBook(string input)
        {
            string[] parts = input.Split('-');
            return new Book(parts[0].Trim(), parts[1].Trim());
        }

        public static void SortBooks(ArrayList books)
        {
            for (int i = 0; i < books.Count - 1; i++)
            {
                for (int j = 0; j < books.Count - i - 1; j++)
                {
                    Book book1 = (Book)books[j];
                    Book book2 = (Book)books[j + 1];
                    
                    if (string.Compare(book1.Title, book2.Title, StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        books[j] = book2;
                        books[j + 1] = book1;
                    }
                }
            }
        }

        public static ArrayList FilterByAuthor(ArrayList books, string author)
        {
            ArrayList result = new ArrayList();
            
            foreach (Book book in books)
            {
                if (book.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
                    result.Add(book);
            }
            
            return result;
        }

        public static string[] ConvertToArray(ArrayList books)
        {
            string[] bookArray = new string[books.Count];
            
            for (int i = 0; i < books.Count; i++)
                bookArray[i] = books[i].ToString();
            
            return bookArray;
        }

        public static void DisplayBooks(ArrayList books)
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books found.");
                return;
            }

            Console.WriteLine("\n--- Books ---");
            for (int i = 0; i < books.Count; i++)
                Console.WriteLine($"{i + 1}. {books[i]}");
        }

        public static void AddBookMenu(Bookshelf bookshelf)
        {
            Console.Write("Enter book in format 'Title - Author': ");
            string input = Console.ReadLine();
            
            Book book = ParseBook(input);
            bookshelf.AddBook(book.Title, book.Author);
        }

        public static void SearchByAuthorMenu(Bookshelf bookshelf)
        {
            Console.Write("Enter author name: ");
            string author = Console.ReadLine();
            bookshelf.SearchByAuthor(author);
        }

        public static void ExportBooksMenu(Bookshelf bookshelf)
        {
            string[] books = bookshelf.ExportBooks();
            
            if (books.Length > 0)
            {
                Console.WriteLine("\nExported Books:");
                foreach (string book in books)
                    Console.WriteLine($"- {book}");
            }
        }
    }
}
