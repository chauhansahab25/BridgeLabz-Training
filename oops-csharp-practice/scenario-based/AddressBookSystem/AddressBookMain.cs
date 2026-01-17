using System;

namespace CG_Practice.oopsscenario.AddressBookSystem
{
    //UC1 Main class
    class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            //UC6 AddressBookSystem
            AddressBookSystem system = new AddressBookSystem();
            Menu menu = new Menu(system);
            menu.DisplayMenu();
        }
    }
}
