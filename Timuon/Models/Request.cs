using System;

namespace Timuon.Models
{
    public class Request
    {
        public string[] Students { get; set; }
        public string Reason { get; set; }
        public string NewSchedule { get; set; }

        public Request(string[] students, string reason, string newSchedule)
        {
            Students = students;
            Reason = reason;
            NewSchedule = newSchedule;
        }
    }
}

