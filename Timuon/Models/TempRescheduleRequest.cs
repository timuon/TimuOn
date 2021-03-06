using System;

namespace Timuon.Models
{
    public class TempRescheduleRequest : Request
    {
        public string Course { get; set; }
        public DateTime NewDate { get; set; }
        public string Coordinator { get; set; }
        public DateTime DateToReschedule { get; set; }

        public TempRescheduleRequest(string courseName, int students, string reason,
            string newSchedule, string course, DateTime newDate,
            string coordinator, DateTime dateToReschedule) :
            base(courseName, students, reason, newSchedule)
        {
            Course = course;
            NewDate = newDate;
            Coordinator = coordinator;
            DateToReschedule = dateToReschedule;
        }
    }
}

