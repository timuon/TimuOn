using System;
using Usernamespace;

namespace Adminnamespace
{
    public class Admin : User
    {
        public string Organization { get; set; }
        public string Department {get; set; }
        public string Auditoriums {get; set;}
        public string Coordinators {get; set;}
        public string Students {get; set;}
        public string Channel {get; set;}

        new public static void Main(string[] args)
        {
            Admin admin01= new Admin();
        }
    }
}

