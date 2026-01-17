using System;

namespace CG_Practice.oopsscenario.AddressBookSystem
{
    //UC1 Menu class
    public class Menu
    {
        private AddressBookSystem system;

        public Menu(AddressBookSystem system)
        {
            this.system = system;
        }

        //UC6 display system menu
        public void DisplayMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n=== Address Book System Menu ===");
                Console.WriteLine("1. Add Address Book");
                Console.WriteLine("2. Display Address Books");
                Console.WriteLine("3. Open Address Book");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        system.AddAddressBook(); // UC6
                        break;

                    case 2:
                        system.DisplayAddressBooks(); // UC6
                        break;

                    case 3:
                        AddressBook book = system.GetAddressBook(); // UC6
                        if (book != null)
                        {
                            AddressBookMenu(book);
                        }
                        break;

                    case 4:
                        exit = true;
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        //UC6 Menu for selected Address Book
        private void AddressBookMenu(IAddressBook addressBook)
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
                Console.WriteLine("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        addressBook.AddContact();
                        break;
                    case 2:
                        addressBook.AddMultipleContacts(); // UC5
                        break;
                    case 3:
                        addressBook.DisplayAllContacts();
                        break;
                    case 4:
                        addressBook.EditContact();
                        break;
                    case 5:
                        addressBook.DeleteContact();
                        break;
                    case 6:
                        back = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
