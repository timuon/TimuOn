using System;

namespace Timuon.Models
{
    public class Schedule : Event
    {
        public string Conflict { get; set; }

        public Schedule(string Name, DateTime date,
            string Auditorium, int Duration, string Audience,
            string Channel, string Schedule, string conflict) :
            base(Name, date, Auditorium, Duration, Audience,
                Channel, Schedule)
        {
            Conflict = conflict;
        }
    }
}

