using System;
using Eventnamespace;

namespace Schedulegnamespace
{
    public class Schedule : Event
    {
        public string Conflict { get; set; }
        
        new public static void Main(string[] args)
        {
            Schedule schedule01= new Schedule();
        }
    }
}

