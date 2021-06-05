using System;
using Usernamespace;

namespace Coordinatornamespace
{
    public class Coordinator : User
    {
        public string Courses { get; set; }
        public string Organization {get; set; }
        public string Department {get; set;}
        public string Level {get; set;}
        public string RescheduleRequests {get; set;}

        new public static void Main(string[] args)
        {
            Coordinator coordinator01= new Coordinator();
        }

    }



}