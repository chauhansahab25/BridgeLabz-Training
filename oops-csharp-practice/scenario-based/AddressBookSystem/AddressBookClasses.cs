using System;

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
        private Contact[] contacts;
        private int count;

        public AddressBook()
        {
            contacts = new Contact[100];
            count = 0;
            
            Contact defaultContact = new Contact();
            defaultContact.FirstName = "Priyanshu";
            defaultContact.LastName = "Chauhan";
            defaultContact.Address = "Moh.Farastoli";
            defaultContact.City = "Bijnor";
            defaultContact.State = "Uttar Pradesh";
            defaultContact.Zip = "246721";
            defaultContact.PhoneNumber = "7906801474";
            defaultContact.Email = "Priyanshu.chauhan_cs22@gla.ac.in";
            contacts[count] = defaultContact;
            count++;
        }

        //UC2 add contact
        public void AddContact()
        {
            Console.WriteLine("\n--- Add Contact ---");
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
            
            contacts[count] = contact;
            count++;
            Console.WriteLine("\nContact added successfully!");
        }

        //UC2 display all contacts
        public void DisplayAllContacts()
        {
            if (count == 0)
            {
                Console.WriteLine("\nNo contacts available.");
                return;
            }

            Console.WriteLine("\n--- All Contacts ---");
            for (int i = 0; i < count; i++)
            {
                contacts[i].DisplayContact();
            }
        }

        //UC3 edit contact
        public void EditContact()
        {
            if (count == 0)
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
            for (int i = 0; i < count; i++)
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

            Console.WriteLine("\nContact updated!");
        }

        //UC4 delete contact
        public void DeleteContact()
        {
            if (count == 0)
            {
                Console.WriteLine("\nNo contacts available.");
                return;
            }

            Console.WriteLine("\n--- Delete Contact ---");
            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();
            
            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();

            int index = -1;
            for (int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName.ToLower() == firstName.ToLower() && contacts[i].LastName.ToLower() == lastName.ToLower())
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("\nContact not found.");
                return;
            }

            Console.WriteLine("\nContact found:");
            contacts[index].DisplayContact();

            Console.WriteLine("\nDelete this contact? (yes/no): ");
            string confirm = Console.ReadLine();
            
            if (confirm.ToLower() != "yes")
            {
                Console.WriteLine("\nDelete cancelled.");
                return;
            }

            for (int i = index; i < count - 1; i++)
            {
                contacts[i] = contacts[i + 1];
            }
            count--;
            Console.WriteLine("\nContact deleted!");
        }
    }
}
