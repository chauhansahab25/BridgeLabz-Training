namespace CG_Practice.oopsscenario.AddressBookSystem
{
    //UC1 Interface for Address Book
    public interface IAddressBook
    {
        //UC2 add contact
        void AddContact();

        //UC5 add multiple contacts
        void AddMultipleContacts();

        //UC2 display all contacts
        void DisplayAllContacts();

        //UC3 edit contact
        void EditContact();

        //UC4 delete contact
        void DeleteContact();
    }
}
