using System;
using System.Collections.Generic;

namespace ContactGroup
{
    public static class Global
    {
        public static List<Group> contactsGroup = new List<Group>()
        {
            new Group ("Friends"),
            new Group ("Work"),
            new Group ("Family")
        };
    }
}
