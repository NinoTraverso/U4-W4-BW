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
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string ProfileImg { get; set; }
        public User() { }
        public User(string name, string surname, string username, string email, string password, string role, string profileImg)
        {
            Name = name;
            Surname = surname;
            Username = username;
            Email = email;
            Password = password;
            Role = role;
            ProfileImg = profileImg;
        }
    }
}