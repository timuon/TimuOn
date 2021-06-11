using System;

namespace Timuon.Models
{
    public class Request
    {
        public string CourseName { get; set; }
        public int Students { get; set; }
        public string Reason { get; set; }
        public string NewSchedule { get; set; }
        public string DisplayString { get; set; }

        public Request(string courseName, int students, string reason, string newSchedule)
        {
            Students = students;
            Reason = reason;
            NewSchedule = newSchedule;
            DisplayString = "Requested by " + students.ToString() + " students";
        }

        public void UpdateDisplayString()
        {
            DisplayString = "Requested by " + Students.ToString() + " students";
        }
    }
}

