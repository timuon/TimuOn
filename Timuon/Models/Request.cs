using System;

namespace Timuon.Models
{
    public class Request
    {
        public int Students { get; set; }
        public string Reason { get; set; }
        public string NewSchedule { get; set; }

        public Request(int students, string reason, string newSchedule)
        {
            Students = students;
            Reason = reason;
            NewSchedule = newSchedule;
        }
    }
}

