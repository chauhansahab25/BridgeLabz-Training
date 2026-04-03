using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CG_Practice.oopsscenario.AddressBookSystem
{
    //UC15 JSON file operations
    public class JSONHandler
    {
        private string filePath = @"C:\Users\priya\OneDrive\Desktop\DotNetConsoleApp\AddressBookSystem\AddressBook.json";

        //UC15 write contacts to JSON
        public void WriteToJSON(List<Contact> contacts)
        {
            string json = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
            Console.WriteLine("Contacts written to JSON successfully!");
        }

        //UC15 read contacts from JSON
        public List<Contact> ReadFromJSON()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("JSON file not found.");
                return new List<Contact>();
            }

            string json = File.ReadAllText(filePath);
            List<Contact> contacts = JsonSerializer.Deserialize<List<Contact>>(json);
            Console.WriteLine("Contacts read from JSON successfully!");
            return contacts;
        }
    }
}
