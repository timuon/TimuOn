using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timuon.Models
{
    public class History
    {
        public List<Organization> Organizations_hist { get; set; }
        private List<Course> Courses_hist { get; set; }
        private List<Teams> Teams_hist { get; set; }

        public History(List<Organization> org_hist, List<Course> course_hist, List<Teams> teams_hist)
        {

            Organizations_hist = org_hist;
            Courses_hist = course_hist;
            Teams_hist = teams_hist;
            
        }

        public void Previous_Subs()
        {
            //returns all subs. C# integrates setters and getters automatically. Use this class only for sending data not set in constructor
        }

        public void click_Team()
        {
            //returns info about teams. C# UWP does this in back-code of View object
        }

        public void Click_Course()
        {
            //returns info about teams. C# UWP does this in back-code of View object
        }


    }
}
