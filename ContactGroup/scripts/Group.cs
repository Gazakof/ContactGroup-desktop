using System;
using System.Collections.Generic;

namespace ContactGroup
{
    public class Group
    {
        private string name;
        private List<Contact> contactsList;

        public string Name { get => name; private set => name = value; }
        public List<Contact> Contacts { get => contactsList; private set => contactsList = value; }
        public Group() { }

        public Group(string groupName)
        {
            this.Name = groupName;
            this.Contacts = new List<Contact>();
        }

        public Group(string groupName, List<Contact> contacts) 
        {
            this.Name = groupName;
            this.Contacts = contacts;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
