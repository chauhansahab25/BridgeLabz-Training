using System;
using System.Collections.Generic;
using System.IO;

namespace CG_Practice.oopsscenario.AddressBookSystem
{
    //UC13 File IO operations
    public class FileIO
    {
        private string filePath = @"C:\Users\priya\OneDrive\Desktop\DotNetConsoleApp\AddressBookSystem\AddressBook.txt";

        //UC13 write contacts to file
        public void WriteToFile(List<Contact> contacts)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Contact c in contacts)
                {
                    writer.WriteLine(c.FirstName + "," + c.LastName + "," + c.Address + "," + 
                                   c.City + "," + c.State + "," + c.Zip + "," + 
                                   c.PhoneNumber + "," + c.Email);
                }
            }
            Console.WriteLine("Contacts written to file successfully!");
        }

        //UC13 read contacts from file
        public List<Contact> ReadFromFile()
        {
            List<Contact> contacts = new List<Contact>();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return contacts;
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    Contact c = new Contact
                    {
                        FirstName = data[0],
                        LastName = data[1],
                        Address = data[2],
                        City = data[3],
                        State = data[4],
                        Zip = data[5],
                        PhoneNumber = data[6],
                        Email = data[7]
                    };
                    contacts.Add(c);
                }
            }
            Console.WriteLine("Contacts read from file successfully!");
            return contacts;
        }
    }
}
