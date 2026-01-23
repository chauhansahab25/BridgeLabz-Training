using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Exception
{
    public class UsingStatementFileExample
    {
        //Write a C# program that reads the first line of a file named "info.txt" using StreamReader.
        public static void Main(string[] args)
        {
            try
            {
                using (StreamReader reader = new StreamReader("info.txt"))
                {
                    string firstLine = reader.ReadLine();

                    Console.WriteLine(firstLine);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error reading file");
            }
        }

    }
}
