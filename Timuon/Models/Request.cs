using System;
using TempRescheduleRequestnamespace;

namespace Requestnamespace
{
    public class Request : TempRescheduleRequest
    {
        public string Students { get; set; }
        public string Reason {get; set;}
        public string NewSchedule {get; set;}
        
        //new public static void Main(string[] args)
        //{
        //    Request request01= new Request();
        //}
    }
}

