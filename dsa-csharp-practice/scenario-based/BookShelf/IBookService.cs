using System;

namespace CG_Practice.oopsscenario.BookShelf
{
    public interface IBookService
    {
        void AddBook(string genre, Book book);
        void RemoveBook(string genre, string bookTitle);
        void DisplayBooks();
    }
}
