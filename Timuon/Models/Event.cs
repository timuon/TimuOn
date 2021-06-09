using System;

namespace Timuon.Models
{
    public class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Auditorium { get; set; }
        public TimeSpan Duration { get; set; }
        public string Audience { get; set; }
        public string Channel { get; set; }
        public string Schedule { get; set; }
        public Event(string name, DateTime date, string auditorium,
            TimeSpan duration, string audience, string channel, string schedule)
        {
            Name = name;
            Date = date;
            Auditorium = auditorium;
            Duration = duration;
            Audience = audience;
            Channel = channel;
            Schedule = schedule;
        }
    }
}

