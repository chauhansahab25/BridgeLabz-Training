using System;

namespace CG_Practice.oopsscenario.BookShelf
{
    public class Menu
    {
        private IBookService service;

        public Menu(IBookService service)
        {
            this.service = service;
        }

        public void ShowMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- Library Menu ---");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. Display Books");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBookMenu();
                        break;

                    case 2:
                        RemoveBookMenu();
                        break;

                    case 3:
                        service.DisplayBooks();
                        break;

                    case 4:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 4);
        }

        private void AddBookMenu()
        {
            Console.Write("Enter Genre: ");
            string genre = Console.ReadLine();

            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Author Name: ");
            string author = Console.ReadLine();

            Book book = new Book(title, author);
            service.AddBook(genre, book);
        }

        private void RemoveBookMenu()
        {
            Console.Write("Enter Genre: ");
            string genre = Console.ReadLine();

            Console.Write("Enter Book Title to Remove: ");
            string title = Console.ReadLine();

            service.RemoveBook(genre, title);
        }
    }
}
