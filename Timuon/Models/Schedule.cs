using System;
using Eventnamespace;

namespace Schedulegnamespace
{
    public class Schedule : Event
    {
        public Schedule(string Name, DateTime date, string Auditorium, int Duration, string Audience, string Channel, string Schedule) : base(Name, date, Auditorium, Duration, Audience, Channel, Schedule)
        {
        }

        public string Conflict { get; set; }
        
        //new public static void Main(string[] args)
        //{
        //    Schedule schedule01= new Schedule();
        //}
    }
}

