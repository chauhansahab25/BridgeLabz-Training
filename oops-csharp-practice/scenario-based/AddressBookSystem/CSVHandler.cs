using System;
using System.Collections.Generic;
using System.IO;

namespace CG_Practice.oopsscenario.AddressBookSystem
{
    //UC14 CSV file operations
    public class CSVHandler
    {
        private string filePath = @"C:\Users\priya\OneDrive\Desktop\DotNetConsoleApp\AddressBookSystem\AddressBook.csv";

        //UC14 write contacts to CSV
        public void WriteToCSV(List<Contact> contacts)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email");
                foreach (Contact c in contacts)
                {
                    writer.WriteLine($"{c.FirstName},{c.LastName},{c.Address},{c.City},{c.State},{c.Zip},{c.PhoneNumber},{c.Email}");
                }
            }
            Console.WriteLine("Contacts written to CSV successfully!");
        }

        //UC14 read contacts from CSV
        public List<Contact> ReadFromCSV()
        {
            List<Contact> contacts = new List<Contact>();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("CSV file not found.");
                return contacts;
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                reader.ReadLine(); // skip header
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
            Console.WriteLine("Contacts read from CSV successfully!");
            return contacts;
        }
    }
}
