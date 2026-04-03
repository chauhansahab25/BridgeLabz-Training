using System;
using System.Collections.Generic;

namespace CG_Practice.oopsscenario.AddressBookSystem
{
    public class AddressBook : IAddressBook
    {
        private List<Contact> contacts;
        private FileIO fileIO; //UC13
        private CSVHandler csvHandler; //UC14
        private JSONHandler jsonHandler; //UC15

        public AddressBook()
        {
            contacts = new List<Contact>();
            fileIO = new FileIO(); //UC13
            csvHandler = new CSVHandler(); //UC14
            jsonHandler = new JSONHandler(); //UC15
        }

        //UC6 add default contact
        public void AddDefaultContact(Contact contact)
        {
            contacts.Add(contact);
        }

        //UC7 add contact with duplicate check
        public void AddContact()
        {
            Contact contact = new Contact();

            Console.WriteLine("Enter First Name:");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            contact.LastName = Console.ReadLine();

            if (contacts.Contains(contact))
            {
                Console.WriteLine("Duplicate contact not allowed.");
                return;
            }

            Console.WriteLine("Enter City:");
            contact.City = Console.ReadLine();

            Console.WriteLine("Enter State:");
            contact.State = Console.ReadLine();

            Console.WriteLine("Enter Phone:");
            contact.PhoneNumber = Console.ReadLine();

            contacts.Add(contact);
            Console.WriteLine("Contact added!");
        }

        //UC5 add multiple contacts
        public void AddMultipleContacts()
        {
            string choice = "yes";
            while (choice.ToLower() == "yes")
            {
                AddContact();
                Console.WriteLine("Add another? (yes/no)");
                choice = Console.ReadLine();
            }
        }

        //UC2 display contacts
        public void DisplayAllContacts()
        {
            foreach (Contact c in contacts)
                Console.WriteLine(c); // uses ToString()
        }

        //UC11 sort contacts alphabetically by name
        public void SortContactsByName() 
        {
            contacts.Sort((c1, c2) =>
            string.Compare(
            c1.FirstName + c1.LastName,
            c2.FirstName + c2.LastName,
            StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Contacts sorted alphabetically:");
            DisplayAllContacts();
        }

        //UC12 sort contacts by city
        public void SortContactsByCity()
        {
            contacts.Sort((c1, c2) => string.Compare(c1.City, c2.City, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Contacts sorted by City:");
            DisplayAllContacts();
        }

        //UC12 sort contacts by state
        public void SortContactsByState()
        {
            contacts.Sort((c1, c2) => string.Compare(c1.State, c2.State, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Contacts sorted by State:");
            DisplayAllContacts();
        }

        //UC12 sort contacts by zip
        public void SortContactsByZip()
        {
            contacts.Sort((c1, c2) => string.Compare(c1.Zip, c2.Zip, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Contacts sorted by Zip:");
            DisplayAllContacts();
        }


        //UC3 edit contact
        public void EditContact()
        {
            Console.WriteLine("Enter First Name:");
            string fn = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            string ln = Console.ReadLine();

            foreach (Contact c in contacts)
            {
                if (c.FirstName.ToLower() == fn.ToLower() &&
                    c.LastName.ToLower() == ln.ToLower())
                {
                    Console.WriteLine("Enter new City:");
                    c.City = Console.ReadLine();
                    Console.WriteLine("Contact updated!");
                    return;
                }
            }
            Console.WriteLine("Contact not found.");
        }

        //UC4 delete contact
        public void DeleteContact()
        {
            Console.WriteLine("Enter First Name:");
            string fn = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            string ln = Console.ReadLine();

            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].FirstName.ToLower() == fn.ToLower() &&
                    contacts[i].LastName.ToLower() == ln.ToLower())
                {
                    contacts.RemoveAt(i);
                    Console.WriteLine("Contact deleted!");
                    return;
                }
            }
            Console.WriteLine("Contact not found.");
        }

        //UC8–UC10
        public List<Contact> GetAllContacts()
        {
            return contacts;
        }

        //UC13 write to file
        public void WriteToFile()
        {
            fileIO.WriteToFile(contacts);
        }

        //UC13 read from file
        public void ReadFromFile()
        {
            contacts = fileIO.ReadFromFile();
        }

        //UC14 write to CSV
        public void WriteToCSV()
        {
            csvHandler.WriteToCSV(contacts);
        }

        //UC14 read from CSV
        public void ReadFromCSV()
        {
            contacts = csvHandler.ReadFromCSV();
        }

        //UC15 write to JSON
        public void WriteToJSON()
        {
            jsonHandler.WriteToJSON(contacts);
        }

        //UC15 read from JSON
        public void ReadFromJSON()
        {
            contacts = jsonHandler.ReadFromJSON();
        }
    }
}
