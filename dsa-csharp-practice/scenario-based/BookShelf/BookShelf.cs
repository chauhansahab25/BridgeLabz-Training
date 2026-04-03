using System;

namespace CG_Practice.oopsscenario.BookShelf
{
    class BookShelf
    {
        static void Main(string[] args)
        {
            IBookService libraryService = new LibraryUtility();
            Menu menu = new Menu(libraryService);
            menu.ShowMenu();
        }
    }
}
