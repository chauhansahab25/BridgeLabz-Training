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

            //UC6 Default Address Book with one default contact
            AddressBook defaultBook = new AddressBook();

            Contact defaultContact = new Contact();
            defaultContact.FirstName = "Priyanshu";
            defaultContact.LastName = "Chauhan";
            defaultContact.Address = "Moh.Farastoli";
            defaultContact.City = "Bijnor";
            defaultContact.State = "Uttar Pradesh";
            defaultContact.Zip = "246721";
            defaultContact.PhoneNumber = "7906801474";
            defaultContact.Email = "Priyanshu.chauhan_cs22@gla.ac.in";

            defaultBook.AddDefaultContact(defaultContact);

            addressBooks.Add("Default", defaultBook);
        }

        //UC6 Add new Address Book
        public void AddAddressBook()
        {
            Console.WriteLine("Enter Address Book Name: ");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine("Address Book already exists!");
                return;
            }

            addressBooks.Add(name, new AddressBook());
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

        //UC6 Get selected Address Book
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
