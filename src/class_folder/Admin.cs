using System;
using Usernamespace;

namespace Adminnamespace
{
    public class Admin : User
    {
        public string Organization { get; set; }
        public string Department { get; set; }
        public string Auditoriums { get; set; }
        public string Coordinators { get; set; }
        public string Students { get; set; }
        public string Channel { get; set; }

        public Admin(string Username, string Password, string Email, string FirstName, string LastName, string Organization, string Department) : 
            base(string Username, string Password, string Email, string FirstName, string LastName)
        {
            this.Organization = Organization;
            this.Department = Department;
        }


    }
}

