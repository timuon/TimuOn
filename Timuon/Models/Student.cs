using System;
using System.Collections.Generic;

namespace Timuon.Models
{
    public class Student : User
    {
        public int AM { get; set; }
        public string Department { get; set; }
        public string ActivityStatus { get; set; }
        public string StudyLevel { get; set; }
        //public string[] Courses { get; set; }
        public DateTime YearOfEnrollment { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }

        public static List<string> Courses = new List<string>();

        public Student(string username, string password, string email,
            int phone_number, string address, DateTime registration_date,
            string firstName, string lastName, int id, string calendars,
            string platforms, string preferences, int aM, string department,
            string activityStatus, string studyLevel, DateTime yearOfEnrollment,
            string fatherName, string motherName) :
            base(username, password, email, phone_number, address, registration_date,
                firstName, lastName, id, calendars, platforms, preferences)
        {
            AM = aM;
            Department = department;
            ActivityStatus = activityStatus;
            StudyLevel = studyLevel;
            YearOfEnrollment = yearOfEnrollment;
            FatherName = fatherName;
            MotherName = motherName;
        }

        public static void addCourse(string newCourse)
        {
            Courses.Add(newCourse);

        }
    }
}

