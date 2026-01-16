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
                Console.WriteLine("2. Display All Contacts");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice: ");
                
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        addressBook.AddContact();
                        break;
                    case 2:
                        addressBook.DisplayAllContacts();
                        break;
                    case 3:
                        addressBook.EditContact();
                        break;
                    case 4:
                        addressBook.DeleteContact();
                        break;
                    case 5:
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
