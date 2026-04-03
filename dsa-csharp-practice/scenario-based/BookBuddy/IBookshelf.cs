using System;
using System.Collections;

namespace CG_Practice.dsascenario.BookBuddy
{
    interface IBookshelf
    {
        void AddBook(string title, string author);
        void SortBooksAlphabetically();
        ArrayList SearchByAuthor(string author);
        string[] ExportBooks();
        void DisplayAllBooks();
    }
}
