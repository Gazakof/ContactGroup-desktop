using System;
using System.Collections.Generic;
using System.Drawing;

namespace ContactGroup
{
    [Serializable]
    public class Contact
    {
        //Propriétés
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }
        public string City { get; private set; }
        public Image Photo { get; private set; }

        //Constructeurs
        public Contact() { }
        public Contact(string firstName, string lastName, string email, string phone, string city, string address, Image photo)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            City = city;
            Address = address;
            Photo = photo;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
