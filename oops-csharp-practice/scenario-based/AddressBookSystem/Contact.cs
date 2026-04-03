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

        //UC7 duplicate check
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Contact other = obj as Contact;
            if (other == null) return false;

            return this.FirstName.ToLower() == other.FirstName.ToLower() &&
                   this.LastName.ToLower() == other.LastName.ToLower();
        }

        public override int GetHashCode()
        {
            return (FirstName + LastName).ToLower().GetHashCode();
        }

        //UC11 override ToString to print contact
        public override string ToString()
        {
            return "Name: " + FirstName + " " + LastName +
                   ", City: " + City +
                   ", State: " + State +
                   ", Phone: " + PhoneNumber;
        }

        //UC2 display contact
        public void DisplayContact()
        {
            Console.WriteLine(ToString());
        }
    }
}
