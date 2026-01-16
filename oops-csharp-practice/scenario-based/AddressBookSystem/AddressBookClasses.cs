using System;
using System.Collections.Generic;

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
            Console.WriteLine("\n--- Add Contact ---");
            Contact contact = new Contact();
            
            Console.Write("Enter First Name: ");
            contact.FirstName = Console.ReadLine();
            
            Console.Write("Enter Last Name: ");
            contact.LastName = Console.ReadLine();
            
            Console.Write("Enter Address: ");
            contact.Address = Console.ReadLine();
            
            Console.Write("Enter City: ");
            contact.City = Console.ReadLine();
            
            Console.Write("Enter State: ");
            contact.State = Console.ReadLine();
            
            Console.Write("Enter Zip: ");
            contact.Zip = Console.ReadLine();
            
            Console.Write("Enter Phone Number: ");
            contact.PhoneNumber = Console.ReadLine();
            
            Console.Write("Enter Email: ");
            contact.Email = Console.ReadLine();
            
            contacts.Add(contact);
            Console.WriteLine("\nContact added successfully!");
        }

        //UC2 display all contacts
        public void DisplayAllContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("\nNo contacts available.");
                return;
            }

            Console.WriteLine("\n--- All Contacts ---");
            for (int i = 0; i < contacts.Count; i++)
            {
                contacts[i].DisplayContact();
            }
        }

        //UC3 edit contact
        public void EditContact()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("\nNo contacts available.");
                return;
            }

            Console.WriteLine("\n--- Edit Contact ---");
            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();
            
            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Contact contact = null;
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].FirstName.ToLower() == firstName.ToLower() && contacts[i].LastName.ToLower() == lastName.ToLower())
                {
                    contact = contacts[i];
                    break;
                }
            }

            if (contact == null)
            {
                Console.WriteLine("\nContact not found.");
                return;
            }

            Console.WriteLine("\nContact found:");
            contact.DisplayContact();

            Console.WriteLine("\nEdit this contact? (yes/no): ");
            string confirm = Console.ReadLine();
            
            if (confirm.ToLower() != "yes")
            {
                Console.WriteLine("\nEdit cancelled.");
                return;
            }

            Console.WriteLine("\nEnter new details:");
            
            Console.Write("Enter First Name: ");
            contact.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            contact.LastName = Console.ReadLine();

            Console.Write("Enter Address: ");
            contact.Address = Console.ReadLine();

            Console.Write("Enter City: ");
            contact.City = Console.ReadLine();

            Console.Write("Enter State: ");
            contact.State = Console.ReadLine();

            Console.Write("Enter Zip: ");
            contact.Zip = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            contact.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            contact.Email = Console.ReadLine();

            Console.WriteLine("\nContact updated!");
        }

        //UC4 delete contact
        public void DeleteContact()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("\nNo contacts available.");
                return;
            }

            Console.WriteLine("\n--- Delete Contact ---");
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Contact contact = null;
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].FirstName.ToLower() == firstName.ToLower() && contacts[i].LastName.ToLower() == lastName.ToLower())
                {
                    contact = contacts[i];
                    break;
                }
            }

            if (contact == null)
            {
                Console.WriteLine("\nContact not found.");
                return;
            }

            Console.WriteLine("\nContact found:");
            contact.DisplayContact();

            Console.WriteLine("\nDelete this contact? (yes/no): ");
            string confirm = Console.ReadLine();
            
            if (confirm.ToLower() != "yes")
            {
                Console.WriteLine("\nDelete cancelled.");
                return;
            }

            contacts.Remove(contact);
            Console.WriteLine("\nContact deleted!");
        }
    }
}
