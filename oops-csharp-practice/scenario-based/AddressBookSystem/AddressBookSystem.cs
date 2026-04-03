using System;
using System.Collections.Generic;

namespace CG_Practice.oopsscenario.AddressBookSystem
{
    public class AddressBookSystem
    {
        private Dictionary<string, AddressBook> addressBooks;
        private Dictionary<string, List<Contact>> cityMap;
        private Dictionary<string, List<Contact>> stateMap;

        public AddressBookSystem()
        {
            addressBooks = new Dictionary<string, AddressBook>();
            cityMap = new Dictionary<string, List<Contact>>();
            stateMap = new Dictionary<string, List<Contact>>();

            //Default Address Book
            AddressBook defaultBook = new AddressBook();
            Contact c = new Contact
            {
                FirstName = "Priyanshu",
                LastName = "Chauhan",
                City = "Bijnor",
                State = "Uttar Pradesh",
                PhoneNumber = "7906801474"
            };

            defaultBook.AddDefaultContact(c);
            addressBooks.Add("Default", defaultBook);
        }

        public void AddAddressBook()
        {
            Console.WriteLine("Enter Address Book Name:");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine("Already exists!");
                return;
            }

            addressBooks.Add(name, new AddressBook());
            Console.WriteLine("Address Book added!");
        }

        public void DisplayAddressBooks()
        {
            foreach (string name in addressBooks.Keys)
                Console.WriteLine("- " + name);
        }

        public AddressBook GetAddressBook()
        {
            Console.WriteLine("Enter Address Book Name:");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
                return addressBooks[name];

            Console.WriteLine("Not found.");
            return null;
        }

        //UC9 build dictionaries
        private void BuildMaps()
        {
            cityMap.Clear();
            stateMap.Clear();

            foreach (AddressBook book in addressBooks.Values)
            {
                foreach (Contact c in book.GetAllContacts())
                {
                    if (!cityMap.ContainsKey(c.City))
                        cityMap[c.City] = new List<Contact>();
                    cityMap[c.City].Add(c);

                    if (!stateMap.ContainsKey(c.State))
                        stateMap[c.State] = new List<Contact>();
                    stateMap[c.State].Add(c);
                }
            }
        }

        //UC9 view persons
        public void ViewPersonsByCity()
        {
            BuildMaps();
            Console.WriteLine("Enter City:");
            string city = Console.ReadLine();

            if (cityMap.ContainsKey(city))
                foreach (Contact c in cityMap[city]) c.DisplayContact();
            else
                Console.WriteLine("No persons found.");
        }

        public void ViewPersonsByState()
        {
            BuildMaps();
            Console.WriteLine("Enter State:");
            string state = Console.ReadLine();

            if (stateMap.ContainsKey(state))
                foreach (Contact c in stateMap[state]) c.DisplayContact();
            else
                Console.WriteLine("No persons found.");
        }

        //UC10 count by city
        public void CountByCity()
        {
            BuildMaps();
            Console.WriteLine("Enter City:");
            string city = Console.ReadLine();

            if (cityMap.ContainsKey(city))
                Console.WriteLine("Total persons in " + city + " = " + cityMap[city].Count);
            else
                Console.WriteLine("No persons found.");
        }

        //UC10 count by state
        public void CountByState()
        {
            BuildMaps();
            Console.WriteLine("Enter State:");
            string state = Console.ReadLine();

            if (stateMap.ContainsKey(state))
                Console.WriteLine("Total persons in " + state + " = " + stateMap[state].Count);
            else
                Console.WriteLine("No persons found.");
        }
    }
}
