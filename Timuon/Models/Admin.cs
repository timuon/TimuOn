using System;

using System.Collections.Generic;

namespace Timuon.Models
{
    public class Admin : User
    {
        public string UserOrganization { get; set; }
        public string Department { get; set; }
        public List<Auditorium> Auditoriums { get; set; }
        public string[] Coordinators { get; set; }
        public string[] Students { get; set; }
        public List<Event> DepartmentCalendar { get; set; }
        public List<Request> RescheduleRequests { get; set; }
        //public Schedule DepartmentSchedule { get; set; }
        public string Channel { get; set; }

        public Admin(string username, string password, string email,
            int phone_number, string address, DateTime registration_date,
            string firstName, string lastName, int id, string calendars,
            string platforms, string preferences, string userOrganization,
            string department, List<Auditorium> auditoriums, string[] coordinators,
            string[] students, List<Event> departmentCalendar,
            List<Request> rescheduleRequests, string channel) :
            base(username, password, email, phone_number, address,
                registration_date, firstName, lastName, id, calendars,
                platforms, preferences)
        {
            UserOrganization = userOrganization;
            Department = department;
            Auditoriums = auditoriums;
            Coordinators = coordinators;
            Students = students;
            DepartmentCalendar = departmentCalendar;
            RescheduleRequests = rescheduleRequests;
            Channel = channel;
        }

        public List<Event> getEventsToday()
        {
            List<Event> EventsToday = new List<Event>();
            foreach (Event e in DepartmentCalendar)
            {
                if (DateTime.Compare(e.Date.Date, DateTime.Today) == 0)
                {
                    EventsToday.Add(e);
                };
            }
            return EventsToday;
        }
    }
}

