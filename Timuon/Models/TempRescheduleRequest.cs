using System;

namespace TempRescheduleRequestnamespace
{
    public class TempRescheduleRequest
    {
        public string Course { get; set; }
        public DateTime NewDate {get; set;}
        public string Coordinator { get; set;}
        public DateTime DateToReschedule {get; set;}
        
        public static void Main(string[] args)
        {
            TempRescheduleRequest tempreschedule01= new TempRescheduleRequest();
        }
    }
}

