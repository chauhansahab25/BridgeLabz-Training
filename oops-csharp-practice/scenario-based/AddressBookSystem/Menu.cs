using System;

namespace CG_Practice.oopsscenario.AddressBookSystem
{
    //UC1 Menu class
    public class Menu
    {
        private IAddressBook addressBook;

        public Menu(IAddressBook addressBook)
        {
            this.addressBook = addressBook;
        }

        //UC2 display menu
        public void DisplayMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n=== Address Book Menu ===");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Add Multiple Contacts"); // UC5
                Console.WriteLine("3. Display All Contacts");
                Console.WriteLine("4. Edit Contact");
                Console.WriteLine("5. Delete Contact");
                Console.WriteLine("6. Exit");
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
                        exit = true;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
