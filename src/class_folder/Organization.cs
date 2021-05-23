using System;
using Usernamespace;

namespace Organizationnamespace
{
    public class Organization : User
    {
        public string Departments { get; set; }
        public string Administrators {get; set; }
        public string Auditoriums {get; set;}
        public bool Availability {get; set;}
        public string Events {get; set;}

        new public static void Main(string[] args)
        {
            Organization organization01= new Organization();
        }



    }



}