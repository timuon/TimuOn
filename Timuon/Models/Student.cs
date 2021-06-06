using System;
using Usernamespace;
using System.Collections.Generic;

namespace Studentnamespace
{
    public class Student : User
    {
        public int AM { get; set; }
        public string Department {get; set; }
        public string ActivityStatus {get; set;}
        public string StudyLevel {get; set;}
        //public string[] Courses { get; set; }
        public DateTime YearOfEnrollment {get; set;}
        public string FatherName {get; set;}
        public string MotherName {get; set;}

        public static List<string> Courses = new List<string>() ;

        public Student(string Username, string Password, string Email, string FirstName, string LastName) : base(Username, Password, Email, FirstName, LastName)
        {
        }

        public static void addCourse(string newCourse) 
        {
            Courses.Add(newCourse);
    
        }

        
        //new public static void Main(string[] args)
        //{
        //    Student student01= new Student();
        //}
    }
}

