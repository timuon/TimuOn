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
        public string Description { get; set; }
        public string DisplayString { get; set; }
        public Event(string name, DateTime date, string auditorium,
            TimeSpan duration, string audience, string channel,
            string schedule, string description)
        {
            Name = name;
            Date = date;
            Auditorium = auditorium;
            Duration = duration;
            Audience = audience;
            Channel = channel;
            Schedule = schedule;
            Description = description;
            if (duration.TotalDays >= 1)
            {
                DisplayString = name + " | All Day";
            }
            else
            {
                DisplayString = name + " | " + date.ToString("HH:mm") + " - "
                + date.Add(duration).ToString("HH:mm");
            }
        }
    }
}

