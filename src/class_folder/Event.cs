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

        public static void Main(string[] args)
        {
            Event event01= new Event();
        }
    }
}

