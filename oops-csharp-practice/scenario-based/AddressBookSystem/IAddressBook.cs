namespace CG_Practice.oopsscenario.AddressBookSystem
{
    //UC1 Interface for Address Book operations
    public interface IAddressBook
    {
        //UC2: add contact
        void AddContact();
        
        //UC2 display all contacts
        void DisplayAllContacts();
        
        //UC3 edit existing contact by name
        void EditContact();
    }
}
