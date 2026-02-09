public interface IAddressBook
{
    void AddContact();
    void AddMultipleContacts();
    void DisplayAllContacts();
    void EditContact();
    void DeleteContact();

    // UC11
    void SortContactsByName();

    // UC12
    void SortContactsByCity();
    void SortContactsByState();
    void SortContactsByZip();

    // UC13
    void WriteToFile();
    void ReadFromFile();

    // UC14
    void WriteToCSV();
    void ReadFromCSV();

    // UC15
    void WriteToJSON();
    void ReadFromJSON();
}
