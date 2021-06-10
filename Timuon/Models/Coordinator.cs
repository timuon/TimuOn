using System;

namespace Timuon.Models
{
    public class Coordinator : User
    {
        public string Courses { get; set; }
        public string Organization { get; set; }
        public string Department { get; set; }
        public string Level { get; set; }
        public string RescheduleRequests { get; set; }

        public Coordinator(string username, string password, string email,
            int phone_number, string address, DateTime registration_date,
            string firstName, string lastName, int id, string calendars,
            string platforms, string preferences, string courses, string organization,
            string department, string level, string rescheduleRequests) :
            base(username, password, email, phone_number, address,
                registration_date, firstName, lastName, id, calendars,
                platforms, preferences)
        {
            Courses = courses;
            Organization = organization;
            Department = department;
            Level = level;
            RescheduleRequests = rescheduleRequests;
        }
    }
}
