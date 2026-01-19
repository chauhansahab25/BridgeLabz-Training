namespace CG_Practice.oopsscenario.AddressBookSystem
{
    //UC1 Interface
    public interface IAddressBook
    {
        void AddContact();           // UC2 + UC7
        void AddMultipleContacts();  // UC5
        void DisplayAllContacts();   // UC2
        void EditContact();          // UC3
        void DeleteContact();        // UC4
    }
}
