using System;
using Eventnamespace;
using Usernamespace;

namespace Organizationnamespace
{
    public class Organization : User
    {
        public Organization(string Username, string Password, string Email, string FirstName, string LastName) : base(Username, Password, Email, FirstName, LastName)
        {
        }

        public string Departments { get; set; }
        public string Administrators {get; set; }
        public string Auditoriums {get; set;}
        public bool Availability {get; set;}
        public string Events {get; set;}

        public static void addEvent(string name, DateTime Date1, string auditorium, int days_duration, string Audience, string Channel, string Schedule)
        {
            Event event02 = new Event(name, Date1, auditorium, days_duration, Audience, Channel, Schedule);

            //var event02 = new Event(Name = name, Date = Date1, Auditorium = auditorium, Duration = days_duration);
        }
        //new public static void Main(string[] args)
        //{
        //    Organization organization01= new Organization();
        //}



    }



}
