using System;

namespace Calendarnamespace
{
    public class Calendar
    {
        public int ID { get; set; }
        public string Type {get; set; }
        public string Meeting {get; set;}
        public string Requests {get; set;}
        public static void Main(string[] args)
        {
            Calendar calendar01= new Calendar();
        }
    }
}

