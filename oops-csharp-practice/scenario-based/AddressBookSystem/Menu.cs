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

        //UC6 + UC8 system menu
        public void DisplayMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n=== Address Book System Menu ===");
                Console.WriteLine("1. Add Address Book");
                Console.WriteLine("2. Display Address Books");
                Console.WriteLine("3. Open Address Book");
                Console.WriteLine("4. Search Person by City");   // UC8
                Console.WriteLine("5. Search Person by State");  // UC8
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter your choice: ");

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
                        {
                            AddressBookMenu(book);
                        }
                        break;
                    case 4:
                        system.SearchPersonByCity(); // UC8
                        break;
                    case 5:
                        system.SearchPersonByState(); // UC8
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        //Address book menu (same as before)
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

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        addressBook.AddContact();
                        break;
                    case 2:
                        addressBook.AddMultipleContacts();
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
                }
            }
        }
    }
}
