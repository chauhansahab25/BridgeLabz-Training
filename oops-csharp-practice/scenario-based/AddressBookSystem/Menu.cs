using System;

namespace CG_Practice.oopsscenario.AddressBookSystem
{
    // UC1: Menu class for user interface
    public class Menu
    {
        private IAddressBook addressBook;

        public Menu(IAddressBook addressBook)
        {
            this.addressBook = addressBook;
        }

        public void DisplayMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n1. Add Contact");
                Console.WriteLine("2. Display All Contacts");
                Console.WriteLine("3. Exit");

                int choice = Utility.GetIntInput("Enter your choice: ");

                switch (choice)
                {
                    case 1:
                        addressBook.AddContact();
                        break;
                    case 2:
                        addressBook.DisplayAllContacts();
                        break;
                    case 3:
                        exit = true;
                        Console.WriteLine("Exiting Address Book Program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
