using System;
using Usernamespace;

namespace Studentnamespace
{
    public class Student : User
    {
        public int AM { get; set; }
        public string Department {get; set; }
        public string ActivityStatus {get; set;}
        public string StudyLevel {get; set;}
        public string Courses {get; set;}
        public DateTime YearOfEnrollment {get; set;}
        public string FatherName {get; set;}
        public string MotherName {get; set;}

        new public static void Main(string[] args)
        {
            Student student01= new Student();
        }
    }
}

