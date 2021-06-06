using System;
using Usernamespace;

namespace Coordinatornamespace
{
    public class Coordinator : User
    {
        public Coordinator(string Username, string Password, string Email, string FirstName, string LastName) : base(Username, Password, Email, FirstName, LastName)
        {
        }

        public string Courses { get; set; }
        public string Organization {get; set; }
        public string Department {get; set;}
        public string Level {get; set;}
        public string RescheduleRequests {get; set;}

        //new public static void Main(string[] args)
        //{
        //    Coordinator coordinator01= new Coordinator();
        //}

    }



}
