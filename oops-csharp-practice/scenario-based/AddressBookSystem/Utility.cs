using System;
using System.Collections.Generic;

namespace CG_Practice.oopsscenario.AddressBookSystem
{
    //UC1 AddressBook class
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

            Console.WriteLine("Enter Address:");
            contact.Address = Console.ReadLine();

            Console.WriteLine("Enter City:");
            contact.City = Console.ReadLine();

            Console.WriteLine("Enter State:");
            contact.State = Console.ReadLine();

            Console.WriteLine("Enter Zip:");
            contact.Zip = Console.ReadLine();

            Console.WriteLine("Enter Phone Number:");
            contact.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Email:");
            contact.Email = Console.ReadLine();

            contacts.Add(contact);
            Console.WriteLine("Contact added successfully!");
        }

        //UC5 add multiple contacts
        public void AddMultipleContacts()
        {
            string choice = "yes";

            while (choice.ToLower() == "yes")
            {
                AddContact();
                Console.WriteLine("Add another contact? (yes/no)");
                choice = Console.ReadLine();
            }
        }

        //UC2 display contacts
        public void DisplayAllContacts()
        {
            foreach (Contact contact in contacts)
            {
                contact.DisplayContact();
            }
        }

        //UC3 edit contact
        public void EditContact()
        {
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();

            foreach (Contact contact in contacts)
            {
                if (contact.FirstName.ToLower() == firstName.ToLower() &&
                    contact.LastName.ToLower() == lastName.ToLower())
                {
                    Console.WriteLine("Enter new City:");
                    contact.City = Console.ReadLine();

                    Console.WriteLine("Enter new State:");
                    contact.State = Console.ReadLine();

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
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();

            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].FirstName.ToLower() == firstName.ToLower() &&
                    contacts[i].LastName.ToLower() == lastName.ToLower())
                {
                    contacts.RemoveAt(i);
                    Console.WriteLine("Contact deleted!");
                    return;
                }
            }

            Console.WriteLine("Contact not found.");
        }

        //UC8/UC9 get all contacts
        public List<Contact> GetAllContacts()
        {
            return contacts;
        }
    }
}
