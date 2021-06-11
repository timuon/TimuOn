using System;

namespace Timuon.Models
{
    public class Organization : User
    {
        public Organization(string username, string password,
            string email, int phone_number, string address,
            DateTime registration_date, string firstName,
            string lastName, int id, string calendars, string platforms,
            string preferences, string departments, string administrators,
            string auditoriums, bool availability, string events) :
            base(username, password, email, phone_number, address,
                registration_date, firstName, lastName, id, calendars,
                platforms, preferences)
        {
            Departments = departments;
            Administrators = administrators;
            Auditoriums = auditoriums;
            Availability = availability;
            Events = events;
        }

        

        public string Departments { get; set; }
        public string Administrators { get; set; }
        public string Auditoriums { get; set; }
        public bool Availability { get; set; }
        public string Events { get; set; }

        public static void addEvent(string name, DateTime Date1, string auditorium, TimeSpan days_duration, string Audience, string Channel, string Schedule, string description)
        {
            Event event02 = new Event(name, Date1, auditorium, days_duration, Audience, Channel, Schedule, description);

            //var event02 = new Event(Name = name, Date = Date1, Auditorium = auditorium, Duration = days_duration);
        }

        public string getDepartmentAuditoriums(string departments)
        {
            return departments;
        }

        public string getStudentRequests(string studentrequests)
        {
            return studentrequests;
        }
        public string getDepartmentSchedule(string departSchedule)
        {
            return departSchedule;
        }
      
        public static void editEvent(string name, DateTime Date1, string auditorium, TimeSpan days_duration, string Audience, string Channel, string Schedule, string description)
        {
            Event event02 = new Event(name, Date1, auditorium, days_duration, Audience, Channel, Schedule, description);

            //var event02 = new Event(Name = name, Date = Date1, Auditorium = auditorium, Duration = days_duration);
        }

        public static string deleteEvent(string name)
        {
            string x = "delete event with name {name}"
            return x;
        }
        public void changeAuditoriumAvai()
        {
        }

        public void changeOrganizationAvai()
        {
        }
        public void additionalInfoAndSubmit()
        {
        }
    }
}
