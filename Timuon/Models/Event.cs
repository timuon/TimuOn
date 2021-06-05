using System;

namespace Eventnamespace
{
    public class Event
    {
        public string Name { get; set; }
        public DateTime Date {get; set;}
        public string Auditorium {get; set;}
        public int Duration {get; set;}
        public string Audience {get; set;}
        public string Channel {get; set;}
        public string Schedule {get; set;}

        public Event( String Name, DateTime date, string Auditorium, int Duration, string Audience, string Channel, string Schedule)
        {
            this.Name = Name;
            this.Date = Date;
            this.Auditorium = Auditorium;
            this.Duration = Duration;
            this.Audience = Audience;
            this.Channel = Channel;
            this.Schedule = Schedule;
        }
    }
}

