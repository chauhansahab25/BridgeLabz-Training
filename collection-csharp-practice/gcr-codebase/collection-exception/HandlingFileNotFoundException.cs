using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Exception
{
    public class HandlingFileNotFoundException
    {

        //Create a C# program that reads a file named "data.txt". If the file does not exist, handle the IOException properly and display a user-friendly message.
        public static void Main(string[] args)
        {
            try
            {
                
                string content = File.ReadAllText("data.txt");
                Console.WriteLine("File Contents:");
                Console.WriteLine(content);
            }

            catch (IOException)
            {
               
                Console.WriteLine("File not found");
            }

        }
    }
}
