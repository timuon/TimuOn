using System;

namespace Usernamespace
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
        
        public User(string Username, string Password, string Email, string FirstName, string LastName)
        {
            this.Username = Username;
            this.Password = Password;
            this.Email = Email;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
}

