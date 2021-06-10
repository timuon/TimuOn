using System;

namespace Timuon.Models
{
    public class Auditorium
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string OrganizationName { get; set; }
        public string[] Courses { get; set; }
        public int Capacity { get; set; }
        public string Address { get; set; }
        public bool Availability { get; set; }
        public bool Accessibility { get; set; }
        public Event[] Events { get; set; }
        public string DisplayString { get; set; }

        public Auditorium(string name, string department,
            string organizationName, string[] courses, int capacity,
            string address, bool availability, bool accessibility, Event[] events)
        {
            Name = name;
            Department = department;
            OrganizationName = organizationName;
            Courses = courses;
            Capacity = capacity;
            Address = address;
            Availability = availability;
            Accessibility = accessibility;
            Events = events;
            DisplayString = "Capacity " + capacity.ToString() + " | ";
            if (accessibility)
            {
                DisplayString += "Accessible | ";
            }
            else
            {
                DisplayString += "Inaccessible | ";
            }
            if (availability)
            {
                DisplayString += "Available this Semester";
            }
            else
            {
                DisplayString += "Not Available this Semester";
            }
        }

        public Auditorium(string name, string department, string organizationName, int capacity, bool availability, bool accessibility)
        {
            Name = name;
            Department = department;
            OrganizationName = organizationName;
            Capacity = capacity;
            Availability = availability;
            Accessibility = accessibility;
            DisplayString = "Capacity " + capacity.ToString() + " | ";
            if (accessibility)
            {
                DisplayString += "Accessible | ";
            }
            else
            {
                DisplayString += "Inaccessible | ";
            }
            if (availability)
            {
                DisplayString += "Available this Semester";
            }
            else
            {
                DisplayString += "Not Available this Semester";
            }
        }

        public void UpdateDisplayString()
        {
            this.DisplayString = "Capacity " + this.Capacity.ToString() + " | ";
            if (this.Accessibility)
            {
                this.DisplayString += "Accessible | ";
            }
            else
            {
                this.DisplayString += "Inaccessible | ";
            }
            if (this.Availability)
            {
                this.DisplayString += "Available this Semester";
            }
            else
            {
                this.DisplayString += "Not Available this Semester";
            }
        }
    }
}
