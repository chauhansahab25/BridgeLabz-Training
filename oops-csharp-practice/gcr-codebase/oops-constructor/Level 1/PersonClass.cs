using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // Person class with copy constructor
    class Person
    {
        public string name;
        public int age;
        public string city;

        // regular constructor
        public Person(string n, int a, string c)
        {
            name = n;
            age = a;
            city = c;
        }

        // copy constructor - copies another person's data
        public Person(Person other)
        {
            name = other.name;
            age = other.age;
            city = other.city;
            Console.WriteLine("Copy constructor used!");
        }

        // display person info
        public void showPerson()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("City: " + city);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // create original person
            Person person1 = new Person("John", 25, "New York");
            Console.WriteLine("Original Person:");
            person1.showPerson();

            // create copy using copy constructor
            Person person2 = new Person(person1);
            Console.WriteLine("Copied Person:");
            person2.showPerson();

            // modify copy to show they are separate objects
            person2.name = "Jane";
            Console.WriteLine("After modifying copy:");
            Console.WriteLine("Original:");
            person1.showPerson();
            Console.WriteLine("Copy:");
            person2.showPerson();

            Console.ReadLine();
        }
    }
}