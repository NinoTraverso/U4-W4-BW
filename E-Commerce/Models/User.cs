using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Image { get ; set; }

        public User() { }
        public User(string name, string surname, string username, string password, string role, string image)
        {
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
            Role = role;
            Image = image;
        }
    }
}