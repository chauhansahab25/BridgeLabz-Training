using System;
using System.Collections.Generic;

namespace CG_Practice.oopsscenario.AddressBookSystem
{
    public class AddressBook : IAddressBook
    {
        private List<Contact> contacts;

        public AddressBook()
        {
            contacts = new List<Contact>();
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
       // UC11 sort contacts alphabetically by person's name
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
    }
}
