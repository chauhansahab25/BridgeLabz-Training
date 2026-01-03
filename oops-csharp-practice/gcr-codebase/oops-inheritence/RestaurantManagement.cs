using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // base person class
    class Person
    {
        public string Name;  // person name
        public int Id;       // person id

        public Person(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + Id);
        }
    }

    // worker interface - defines work behavior
    interface IWorker
    {
        void PerformDuties();  // method to perform duties
    }

    // chef class inherits from person and implements worker (hybrid)
    class Chef : Person, IWorker
    {
        public string Specialty;  // chef specialty

        public Chef(string name, int id, string specialty) 
            : base(name, id)  // call parent constructor
        {
            Specialty = specialty;
        }

        // implement interface method
        public void PerformDuties()
        {
            Console.WriteLine(Name + " is cooking " + Specialty + " dishes");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();  // call parent method
            Console.WriteLine("Role: Chef");
            Console.WriteLine("Specialty: " + Specialty);
        }
    }

    // waiter class inherits from person and implements worker (hybrid)
    class Waiter : Person, IWorker
    {
        public int TablesAssigned;  // number of tables assigned

        public Waiter(string name, int id, int tablesAssigned) 
            : base(name, id)
        {
            TablesAssigned = tablesAssigned;
        }

        // implement interface method
        public void PerformDuties()
        {
            Console.WriteLine(Name + " is serving " + TablesAssigned + " tables");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Role: Waiter");
            Console.WriteLine("Tables Assigned: " + TablesAssigned);
        }
    }

    class Program
    {
        static void Main()
        {
            // create restaurant workers (hybrid inheritance)
            Chef chef = new Chef("gordon", 101, "italian cuisine");
            Waiter waiter = new Waiter("alice", 102, 5);

            // display worker information
            Console.WriteLine("Chef Information:");
            chef.DisplayInfo();
            chef.PerformDuties();  // interface method
            Console.WriteLine();

            Console.WriteLine("Waiter Information:");
            waiter.DisplayInfo();
            waiter.PerformDuties();  // interface method
            Console.WriteLine();

            // polymorphism with interface
            IWorker[] workers = { chef, waiter };
            Console.WriteLine("All Workers Performing Duties:");
            foreach (IWorker worker in workers)
            {
                worker.PerformDuties();  // interface method call
            }

            Console.ReadLine();
        }
    }
}