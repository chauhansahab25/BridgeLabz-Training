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
                Console.WriteLine("6. Count Persons by City");
                Console.WriteLine("7. Count Persons by State");
                Console.WriteLine("8. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: system.AddAddressBook(); break;
                    case 2: system.DisplayAddressBooks(); break;
                    case 3:
                        AddressBook book = system.GetAddressBook();
                        if (book != null) AddressBookMenu(book);
                        break;
                    case 4: system.ViewPersonsByCity(); break;
                    case 5: system.ViewPersonsByState(); break;
                    case 6: system.CountByCity(); break;
                    case 7: system.CountByState(); break;
                    case 8: exit = true; break;
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
                Console.WriteLine("6. Sort Contacts by Name"); // UC11
                Console.WriteLine("7. Sort Contacts by City"); // UC12
                Console.WriteLine("8. Sort Contacts by State"); // UC12
                Console.WriteLine("9. Sort Contacts by Zip"); // UC12
                Console.WriteLine("10. Write to File"); // UC13
                Console.WriteLine("11. Read from File"); // UC13
                Console.WriteLine("12. Write to CSV"); // UC14
                Console.WriteLine("13. Read from CSV"); // UC14
                Console.WriteLine("14. Write to JSON"); // UC15
                Console.WriteLine("15. Read from JSON"); // UC15
                Console.WriteLine("16. Back");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: book.AddContact(); break;
                    case 2: book.AddMultipleContacts(); break;
                    case 3: book.DisplayAllContacts(); break;
                    case 4: book.EditContact(); break;
                    case 5: book.DeleteContact(); break;
                    case 6: book.SortContactsByName(); break; // UC11
                    case 7: book.SortContactsByCity(); break; // UC12
                    case 8: book.SortContactsByState(); break; // UC12
                    case 9: book.SortContactsByZip(); break; // UC12
                    case 10: book.WriteToFile(); break; // UC13
                    case 11: book.ReadFromFile(); break; // UC13
                    case 12: book.WriteToCSV(); break; // UC14
                    case 13: book.ReadFromCSV(); break; // UC14
                    case 14: book.WriteToJSON(); break; // UC15
                    case 15: book.ReadFromJSON(); break; // UC15
                    case 16: back = true; break;
                }
            }
        }
    }
}
