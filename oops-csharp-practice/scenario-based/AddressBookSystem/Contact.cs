using System;

namespace CG_Practice.oopsscenario.AddressBookSystem
{
    //UC1 Contact class
    public class Contact
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public string Zip;
        public string PhoneNumber;
        public string Email;

        //UC7 override equals for duplicate check
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Contact other = obj as Contact;
            if (other == null)
                return false;

            return this.FirstName.ToLower() == other.FirstName.ToLower() &&
                   this.LastName.ToLower() == other.LastName.ToLower();
        }

        //UC7 override gethashcode
        public override int GetHashCode()
        {
            return (FirstName + LastName).ToLower().GetHashCode();
        }

        //UC2 display contact
        public void DisplayContact()
        {
            Console.WriteLine("\nName: " + FirstName + " " + LastName);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("City: " + City);
            Console.WriteLine("State: " + State);
            Console.WriteLine("Zip: " + Zip);
            Console.WriteLine("Phone: " + PhoneNumber);
            Console.WriteLine("Email: " + Email);
        }
    }
}
