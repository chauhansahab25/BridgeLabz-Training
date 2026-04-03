using System;

namespace CG_Practice.dsascenario.BookBuddy
{
    class Menu
    {
        private Bookshelf bookshelf;

        public Menu()
        {
            bookshelf = new Bookshelf();
        }

        public void Start()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n=== BookBuddy - Digital Bookshelf ===");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Display All Books");
                Console.WriteLine("3. Sort Books Alphabetically");
                Console.WriteLine("4. Search by Author");
                Console.WriteLine("5. Export Books");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BookUtility.AddBookMenu(bookshelf);
                        break;
                    case "2":
                        bookshelf.DisplayAllBooks();
                        break;
                    case "3":
                        bookshelf.SortBooksAlphabetically();
                        break;
                    case "4":
                        BookUtility.SearchByAuthorMenu(bookshelf);
                        break;
                    case "5":
                        BookUtility.ExportBooksMenu(bookshelf);
                        break;
                    case "6":
                        running = false;
                        Console.WriteLine("Thank you for using BookBuddy!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }


    }
}
