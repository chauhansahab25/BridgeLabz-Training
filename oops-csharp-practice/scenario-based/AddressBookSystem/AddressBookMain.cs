using System;

namespace CG_Practice.oopsscenario.AddressBookSystem
{
    class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBookSystem system = new AddressBookSystem();
            Menu menu = new Menu(system);
            menu.DisplayMenu();
        }
    }
}
