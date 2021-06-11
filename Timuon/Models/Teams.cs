using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timuon.Models
{
    public class Teams
    {
        public List<string> Students_teams { get; set; }

        public Teams(List<string> students)
        {
            Students_teams = students;
        }

        public void get_Team_Info()
        {
            //returns info about teams. C# UWP does this in the back-code of View object. For simplicity it is left there. Can be moved here for more complicated hierarchy
        }

    }
}
