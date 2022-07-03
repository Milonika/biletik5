using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biletik5.Data
{
    public class User
    {
        public User(string name, string surame, DateTime dateOfAdding)
        {
            Name = name;
            Surame = surame;
            DateOfAdding = dateOfAdding;
        }

        public string Name { get; set; }
        public string Surame { get; set; }
        public DateTime DateOfAdding { get; set; }

        public static List<User> users = new List<User>();
        public static List<string> title = new List<string>() {"Name","Surname", "DateOfAdding"};

    }
}
