using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timuon.Models
{
    public class Course
    {
        public string Students { get; set; }
        private string Auditoriums { get; set; }
        private string Coordinators { get; set; }
        private string Department { get; set; }
        private string Organization_course { get; set; }
        private string Title { get; set; }
        private DateTime Start_Date { get; set; }
        private DateTime End_Date { get; set; }
        private string Level { get; set; }
        private string Timetable { get; set; }
        public List<Schedule> Course_Schedules { get; set;}
        private string Preferences { get; set; }

        public string Status { get; set; }

        public Course(string students, string auditoriums, string coordinator,
            string department, string organization, string title, DateTime start_date,
            DateTime end_date, string level, string timetable, List<Schedule> course_schedules,
            string preferences, string status)
        {

            Students = students;
            Auditoriums = auditoriums;
            Coordinators = coordinator;
            Department = department;
            Organization_course = organization;
            Title = title;
            Start_Date = start_date;
            End_Date = end_date;
            Level = level;
            Timetable = timetable;
            Course_Schedules = course_schedules;
            Preferences = preferences;
            Status = status;
        }
    }
}


