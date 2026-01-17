using System;
using System.Collections.Generic; // UC5: Collection class

namespace CG_Practice.oopsscenario.AddressBookSystem
{
    //UC1 Contact class
    public class Contact
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public string Zip;
        public string PhoneNumber;
        public string Email;

        //UC2 display contact
        public void DisplayContact()
        {
            Console.WriteLine("\nName: " + FirstName + " " + LastName);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("City: " + City + ", State: " + State + ", Zip: " + Zip);
            Console.WriteLine("Phone: " + PhoneNumber);
            Console.WriteLine("Email: " + Email);
        }
    }

    //UC1 AddressBook class
    public class AddressBook : IAddressBook
    {
        //UC5 use collection instead of array
        private List<Contact> contacts;

        public AddressBook()
        {
            contacts = new List<Contact>();

            Contact defaultContact = new Contact();
            defaultContact.FirstName = "Priyanshu";
            defaultContact.LastName = "Chauhan";
            defaultContact.Address = "Moh.Farastoli";
            defaultContact.City = "Bijnor";
            defaultContact.State = "Uttar Pradesh";
            defaultContact.Zip = "246721";
            defaultContact.PhoneNumber = "7906801474";
            defaultContact.Email = "Priyanshu.chauhan_cs22@gla.ac.in";

            contacts.Add(defaultContact);
        }

        //UC2 add contact
        public void AddContact()
        {
            Contact contact = new Contact();

            Console.WriteLine("Enter First Name: ");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            contact.Address = Console.ReadLine();

            Console.WriteLine("Enter City: ");
            contact.City = Console.ReadLine();

            Console.WriteLine("Enter State: ");
            contact.State = Console.ReadLine();

            Console.WriteLine("Enter Zip: ");
            contact.Zip = Console.ReadLine();

            Console.WriteLine("Enter Phone Number: ");
            contact.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Email: ");
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
                Console.WriteLine("Do you want to add another contact? (yes/no): ");
                choice = Console.ReadLine();
            }
        }

        //UC2 display all contacts
        public void DisplayAllContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts available.");
                return;
            }

            foreach (Contact contact in contacts)
            {
                contact.DisplayContact();
            }
        }

        //UC3 edit contact
        public void EditContact()
        {
            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();

            foreach (Contact contact in contacts)
            {
                if (contact.FirstName.ToLower() == firstName.ToLower() &&
                    contact.LastName.ToLower() == lastName.ToLower())
                {
                    Console.WriteLine("Enter new Address: ");
                    contact.Address = Console.ReadLine();

                    Console.WriteLine("Enter new City: ");
                    contact.City = Console.ReadLine();

                    Console.WriteLine("Enter new State: ");
                    contact.State = Console.ReadLine();

                    Console.WriteLine("Enter new Zip: ");
                    contact.Zip = Console.ReadLine();

                    Console.WriteLine("Enter new Phone Number: ");
                    contact.PhoneNumber = Console.ReadLine();

                    Console.WriteLine("Enter new Email: ");
                    contact.Email = Console.ReadLine();

                    Console.WriteLine("Contact updated!");
                    return;
                }
            }

            Console.WriteLine("Contact not found.");
        }

        //UC4 delete contact
        public void DeleteContact()
        {
            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
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
    }
}
