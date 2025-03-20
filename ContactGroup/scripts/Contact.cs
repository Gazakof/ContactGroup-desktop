using System;
using System.Collections.Generic;
using System.Drawing;

namespace ContactGroup
{
    public class Contact
    {
        //Variables
        private string firstName;
        private string lastName;
        private string email;
        private string phone;
        private string city;
        private string address;
        private Image photo;

        //Propriétés
        public string FirstName { get => firstName; private set => firstName = value; }
        public string LastName { get => lastName; private set => lastName = value; }
        public string Email { get => email; private set => email = value; }
        public string Phone { get => phone; private set => phone = value; }
        public string Address { get => address; private set => address = value; }
        public string City { get => city; private set => city = value; }
        public Image Photo { get => photo; private set => photo = value; }

        //Constructeurs
        public Contact() { }
        public Contact(string firstName, string lastName, string email, string phone, string city, string address, Image photo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;
            this.City = city;
            this.Address = address;
            this.Photo = photo;
        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
