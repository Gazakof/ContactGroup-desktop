using System;
using System.Collections.Generic;

namespace ContactGroup
{
    [Serializable]
    public class Group
    {
        private string name;
        private List<Contact> contactsList;

        public string Name { get => name; private set => name = value; }
        public List<Contact> Contacts { get => contactsList; private set => contactsList = value; }
        public Group() 
        {
            Name = "Undefined";
            Contacts = new List<Contact>();
        }

        public Group(string groupName)
        {
            Name = groupName;
            Contacts = new List<Contact>();
        }

        public Group(string groupName, List<Contact> contacts) 
        {
            Name = groupName;
            Contacts = contacts;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
