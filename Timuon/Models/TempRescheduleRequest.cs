using System;

namespace Timuon.Models
{
    public class TempRescheduleRequest : Request
    {
        public string Course { get; set; }
        public DateTime NewDate { get; set; }
        public string Coordinator { get; set; }
        public DateTime DateToReschedule { get; set; }

        public TempRescheduleRequest(string[] students, string reason,
            string newSchedule, string course, DateTime newDate,
            string coordinator, DateTime dateToReschedule) :
            base(students, reason, newSchedule)
        {
            Course = course;
            NewDate = newDate;
            Coordinator = coordinator;
            DateToReschedule = dateToReschedule;
        }
    }
}

