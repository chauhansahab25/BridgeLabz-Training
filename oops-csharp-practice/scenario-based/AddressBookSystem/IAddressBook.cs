public interface IAddressBook
{
    void AddContact();
    void AddMultipleContacts();
    void DisplayAllContacts();
    void EditContact();
    void DeleteContact();

    // UC11
    void SortContactsByName();
}
