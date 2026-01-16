using System;
using System.Collections.Generic;

namespace CG_Practice.oopsscenario.AddressBookSystem
{
    // UC1: Contact class with encapsulation
    public class Contact
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string zip;
        private string phoneNumber;
        private string email;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }

        public void DisplayContact()
        {
            Console.WriteLine($"\nName: {FirstName} {LastName}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"City: {City}, State: {State}, Zip: {Zip}");
            Console.WriteLine($"Phone: {PhoneNumber}");
            Console.WriteLine($"Email: {Email}");
        }
    }

    // UC1: AddressBook class implementing IAddressBook interface
    public class AddressBook : IAddressBook
    {
        private List<Contact> contacts;

        public AddressBook()
        {
            contacts = new List<Contact>();
        }

        public void AddContact()
        {
            Contact contact = new Contact
            {
                FirstName = Utility.GetInput("Enter First Name: "),
                LastName = Utility.GetInput("Enter Last Name: "),
                Address = Utility.GetInput("Enter Address: "),
                City = Utility.GetInput("Enter City: "),
                State = Utility.GetInput("Enter State: "),
                Zip = Utility.GetInput("Enter Zip: "),
                PhoneNumber = Utility.GetInput("Enter Phone Number: "),
                Email = Utility.GetInput("Enter Email: ")
            };

            contacts.Add(contact);
            Console.WriteLine("\nContact added successfully!");
        }

        public void DisplayAllContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("\nNo contacts available.");
                return;
            }

            Console.WriteLine("\n--- All Contacts ---");
            foreach (var contact in contacts)
            {
                contact.DisplayContact();
            }
        }
    }
}
