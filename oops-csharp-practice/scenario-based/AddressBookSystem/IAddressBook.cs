namespace CG_Practice.oopsscenario.AddressBookSystem
{
    public interface IAddressBook
    {
        void AddContact();           // UC2 + UC7
        void AddMultipleContacts();  // UC5 + UC7
        void DisplayAllContacts();   // UC2
        void EditContact();          // UC3
        void DeleteContact();        // UC4
    }
}
