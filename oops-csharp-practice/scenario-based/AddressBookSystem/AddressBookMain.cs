using System;

namespace CG_Practice.oopsscenario.AddressBookSystem
{
    //UC1 Main class
    class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            IAddressBook addressBook = new AddressBook();
            Menu menu = new Menu(addressBook);
            menu.DisplayMenu();
        }
    }
}
