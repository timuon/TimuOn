using System;
using Calendarnamespace;

namespace Meetingnamespace
{
    public class Meeting : Calendar
    {
        public string Users { get; set; }
        public DateTime Date {get; set;}
        new public static void Main(string[] args)
        {
            Meeting meeting01= new Meeting();
        }
    }
}

