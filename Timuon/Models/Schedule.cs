using System;

namespace Timuon.Models
{
    public class Schedule : Event
    {
        public string Conflict { get; set; }

        public Schedule(string Name, DateTime date,
            string Auditorium, TimeSpan Duration, string Audience,
            string Channel, string Schedule, string description, string conflict) :
            base(Name, date, Auditorium, Duration, Audience,
                Channel, Schedule, description)
        {
            Conflict = conflict;
        }
        public void checkValidityonChange()
        {

        }

        public void passAuditoriumChange()
        {

        }

        public void checkConflict(Event event__)
        {

        }

        public void addEvent(Event event__)
        {

        }

        public void passNewEvent(Event event__, Calendar calendar__)
        {

        }


    }
}

