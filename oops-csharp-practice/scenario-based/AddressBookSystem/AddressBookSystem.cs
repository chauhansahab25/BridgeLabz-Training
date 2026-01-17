using System;
using System.Collections.Generic;

namespace CG_Practice.oopsscenario.AddressBookSystem
{
    //UC6 AddressBookSystem class
    public class AddressBookSystem
    {
        //UC6 Dictionary to store multiple Address Books
        private Dictionary<string, AddressBook> addressBooks;

        public AddressBookSystem()
        {
            addressBooks = new Dictionary<string, AddressBook>();
        }

        //UC6 Add new Address Book with unique name
        public void AddAddressBook()
        {
            Console.WriteLine("Enter Address Book Name: ");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine("Address Book already exists!");
                return;
            }

            AddressBook addressBook = new AddressBook();
            addressBooks.Add(name, addressBook);

            Console.WriteLine("Address Book added successfully!");
        }

        //UC6 Display all Address Book names
        public void DisplayAddressBooks()
        {
            if (addressBooks.Count == 0)
            {
                Console.WriteLine("No Address Books available.");
                return;
            }

            Console.WriteLine("Available Address Books:");
            foreach (string name in addressBooks.Keys)
            {
                Console.WriteLine("- " + name);
            }
        }

        //UC6 Select Address Book to work on
        public AddressBook GetAddressBook()
        {
            Console.WriteLine("Enter Address Book Name: ");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
            {
                return addressBooks[name];
            }

            Console.WriteLine("Address Book not found!");
            return null;
        }
    }
}
