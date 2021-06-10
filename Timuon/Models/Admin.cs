using System;

namespace Timuon.Models
{
    public class Admin : User
    {
        public string UserOrganization { get; set; }
        public string Department { get; set; }
        public string[] Auditoriums { get; set; }
        public string[] Coordinators { get; set; }
        public string[] Students { get; set; }
        public string Channel { get; set; }

        public Admin(string username, string password, string email,
            int phone_number, string address, DateTime registration_date,
            string firstName, string lastName, int id, string calendars,
            string platforms, string preferences, string userOrganization,
            string department, string[] auditoriums, string[] coordinators,
            string[] students, string channel) :
            base(username, password, email, phone_number, address,
                registration_date, firstName, lastName, id, calendars,
                platforms, preferences)
        {
            UserOrganization = userOrganization;
            Department = department;
            Auditoriums = auditoriums;
            Coordinators = coordinators;
            Students = students;
            Channel = channel;
        }
    }
}

