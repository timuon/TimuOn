using System;

namespace Timuon.Models
{
    public class User
    {
        private string Username { get; set; }
        private string Password { get; set; }
        private string Email { get; set; }
        private int Phone_number { get; set; }
        private string Address { get; set; }
        private DateTime Registration_date { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private int Id { get; set; }
        private string Calendars { get; set; }
        private string Platforms { get; set; }
        private string Preferences { get; set; }

        public User(string username, string password, string email,
            int phone_number, string address, DateTime registration_date,
            string firstName, string lastName, int id, string calendars,
            string platforms, string preferences)
        {
            Username = username;
            Password = password;
            Email = email;
            Phone_number = phone_number;
            Address = address;
            Registration_date = registration_date;
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Calendars = calendars;
            Platforms = platforms;
            Preferences = preferences;
        }
    }
}

