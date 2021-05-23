using System;

namespace Usernamespace
{
    public class User
    {
        public string Username { get; set; }
        public string Password {get; set; }
        public string Email {get; set;}
        public int Phone_number {get; set;}
        public string Address {get; set;}
        public DateTime Registration_date {get; set;}
        public string First_name {get; set;}
        public string Last_name {get; set;}
        public int Id {get; set;}
        public string Calendars {get; set;}
        public string Platforms {get; set;}
        public string Preferences {get; set;}

        public static void Main(string[] args)
        {
            User user01= new User();
        }
    }
}

