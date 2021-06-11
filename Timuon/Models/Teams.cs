using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timuon.Models
{
    public class Teams
    {
        public string Name { get; set; }
        public List<string> Students_teams { get; set; }
        public int num_of { get; set; }


        public Teams(List<string> students, int num, string name)
        {
            Students_teams = students;
            num_of = num;
            Name = name;
            
    }

        public string get_Team_Info(List<string> myList)
        {
            string combindedString = string.Join(",", myList);
            return combindedString;
            //returns info about teams. C# UWP does this in the back-code of View object. For simplicity it is left there. Can be moved here for more complicated hierarchy
        }

    }
}
