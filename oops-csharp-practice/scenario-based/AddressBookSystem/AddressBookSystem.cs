using System;
using System.Collections.Generic;

namespace CG_Practice.oopsscenario.AddressBookSystem
{
    //UC6 AddressBookSystem class
    public class AddressBookSystem
    {
        private Dictionary<string, AddressBook> addressBooks;

        //UC9 city and state dictionaries
        private Dictionary<string, List<Contact>> cityMap;
        private Dictionary<string, List<Contact>> stateMap;

        public AddressBookSystem()
        {
            addressBooks = new Dictionary<string, AddressBook>();
            cityMap = new Dictionary<string, List<Contact>>();
            stateMap = new Dictionary<string, List<Contact>>();

            //Default Address Book
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

        //UC6 add address book
        public void AddAddressBook()
        {
            Console.WriteLine("Enter Address Book Name:");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine("Address Book already exists!");
                return;
            }

            addressBooks.Add(name, new AddressBook());
            Console.WriteLine("Address Book added!");
        }

        //UC6 display address books
        public void DisplayAddressBooks()
        {
            foreach (string name in addressBooks.Keys)
            {
                Console.WriteLine("- " + name);
            }
        }

        //UC6 get address book
        public AddressBook GetAddressBook()
        {
            Console.WriteLine("Enter Address Book Name:");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
                return addressBooks[name];

            Console.WriteLine("Address Book not found.");
            return null;
        }

        //UC9 build city & state dictionaries
        private void BuildCityStateMaps()
        {
            cityMap.Clear();
            stateMap.Clear();

            foreach (AddressBook book in addressBooks.Values)
            {
                foreach (Contact contact in book.GetAllContacts())
                {
                    if (!cityMap.ContainsKey(contact.City))
                        cityMap[contact.City] = new List<Contact>();

                    cityMap[contact.City].Add(contact);

                    if (!stateMap.ContainsKey(contact.State))
                        stateMap[contact.State] = new List<Contact>();

                    stateMap[contact.State].Add(contact);
                }
            }
        }

        //UC9 view persons by city
        public void ViewPersonsByCity()
        {
            BuildCityStateMaps();

            Console.WriteLine("Enter City:");
            string city = Console.ReadLine();

            if (cityMap.ContainsKey(city))
            {
                foreach (Contact c in cityMap[city])
                    c.DisplayContact();
            }
            else
            {
                Console.WriteLine("No persons found.");
            }
        }

        //UC9 view persons by state
        public void ViewPersonsByState()
        {
            BuildCityStateMaps();

            Console.WriteLine("Enter State:");
            string state = Console.ReadLine();

            if (stateMap.ContainsKey(state))
            {
                foreach (Contact c in stateMap[state])
                    c.DisplayContact();
            }
            else
            {
                Console.WriteLine("No persons found.");
            }
        }
    }
}
