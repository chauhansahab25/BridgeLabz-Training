using System;

namespace CG_Practice.oopsscenario.AddressBookSystem
{
    public class Menu
    {
        private AddressBookSystem system;

        public Menu(AddressBookSystem system)
        {
            this.system = system;
        }

        public void DisplayMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n=== Address Book System ===");
                Console.WriteLine("1. Add Address Book");
                Console.WriteLine("2. Display Address Books");
                Console.WriteLine("3. Open Address Book");
                Console.WriteLine("4. View Persons by City");
                Console.WriteLine("5. View Persons by State");
                Console.WriteLine("6. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        system.AddAddressBook();
                        break;
                    case 2:
                        system.DisplayAddressBooks();
                        break;
                    case 3:
                        AddressBook book = system.GetAddressBook();
                        if (book != null)
                            AddressBookMenu(book);
                        break;
                    case 4:
                        system.ViewPersonsByCity();
                        break;
                    case 5:
                        system.ViewPersonsByState();
                        break;
                    case 6:
                        exit = true;
                        break;
                }
            }
        }

        private void AddressBookMenu(IAddressBook book)
        {
            bool back = false;

            while (!back)
            {
                Console.WriteLine("\n--- Address Book Menu ---");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Add Multiple Contacts");
                Console.WriteLine("3. Display Contacts");
                Console.WriteLine("4. Edit Contact");
                Console.WriteLine("5. Delete Contact");
                Console.WriteLine("6. Back");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        book.AddContact();
                        break;
                    case 2:
                        book.AddMultipleContacts();
                        break;
                    case 3:
                        book.DisplayAllContacts();
                        break;
                    case 4:
                        book.EditContact();
                        break;
                    case 5:
                        book.DeleteContact();
                        break;
                    case 6:
                        back = true;
                        break;
                }
            }
        }
    }
}
