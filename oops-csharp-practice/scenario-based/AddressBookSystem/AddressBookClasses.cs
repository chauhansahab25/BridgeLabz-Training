using System;
using System.Collections.Generic;

namespace CG_Practice.oopsscenario.AddressBookSystem
{
    //UC1 Contact class with encapsulation
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

        //UC2 display contact details
        public void DisplayContact()
        {
            Console.WriteLine($"\nName: {FirstName} {LastName}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"City: {City}, State: {State}, Zip: {Zip}");
            Console.WriteLine($"Phone: {PhoneNumber}");
            Console.WriteLine($"Email: {Email}");
        }
    }

    public class AddressBook : IAddressBook
    {
        private List<Contact> contacts;

        public AddressBook()
        {
            contacts = new List<Contact>();
            InitializeWithDefaultContact();
        }

        //UC2 initialize with default contact
        private void InitializeWithDefaultContact()
        {
            Contact defaultContact = new Contact
            {
                FirstName = "Priyanshu",
                LastName = "Chauhan",
                Address = "Moh.Farastoli",
                City = "Bijnor",
                State = "Uttar Pradesh",
                Zip = "246721",
                PhoneNumber = "7906801474",
                Email = "Priyanshu.chauhan_cs22@gla.ac.in"
            };
            contacts.Add(defaultContact);
            Console.WriteLine("Default contact added: Priyanshu Chauhan");
        }

        //UC2 add new contact to address book
        public void AddContact()
        {
            Console.WriteLine("\n--- Add New Contact ---");
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

        //UC2 display all contacts in address book
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

        //UC3 edit existing contact by name
        public void EditContact()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("\nNo contacts available to edit.");
                return;
            }

            Console.WriteLine("\n--- Edit Contact ---");
            string firstName = Utility.GetInput("Enter First Name: ");
            string lastName = Utility.GetInput("Enter Last Name: ");

            Contact contact = contacts.Find(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) && 
                                                  c.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));

            if (contact == null)
            {
                Console.WriteLine("\nContact not found.");
                return;
            }

            Console.WriteLine("\nContact found:");
            contact.DisplayContact();

            string confirm = Utility.GetInput("\nDo you want to edit this contact? (yes/no): ");
            if (!confirm.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nEdit cancelled.");
                return;
            }

            Console.WriteLine("\nEnter new details (press Enter to keep current value):");
            
            string input = Utility.GetInput($"First Name [{contact.FirstName}]: ");
            if (!string.IsNullOrWhiteSpace(input)) contact.FirstName = input;

            input = Utility.GetInput($"Last Name [{contact.LastName}]: ");
            if (!string.IsNullOrWhiteSpace(input)) contact.LastName = input;

            input = Utility.GetInput($"Address [{contact.Address}]: ");
            if (!string.IsNullOrWhiteSpace(input)) contact.Address = input;

            input = Utility.GetInput($"City [{contact.City}]: ");
            if (!string.IsNullOrWhiteSpace(input)) contact.City = input;

            input = Utility.GetInput($"State [{contact.State}]: ");
            if (!string.IsNullOrWhiteSpace(input)) contact.State = input;

            input = Utility.GetInput($"Zip [{contact.Zip}]: ");
            if (!string.IsNullOrWhiteSpace(input)) contact.Zip = input;

            input = Utility.GetInput($"Phone Number [{contact.PhoneNumber}]: ");
            if (!string.IsNullOrWhiteSpace(input)) contact.PhoneNumber = input;

            input = Utility.GetInput($"Email [{contact.Email}]: ");
            if (!string.IsNullOrWhiteSpace(input)) contact.Email = input;

            Console.WriteLine("\nContact updated successfully!");
        }
    }
}
