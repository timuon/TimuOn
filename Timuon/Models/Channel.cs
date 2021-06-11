using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timuon.Models
{
    public class Channel
    {
        public string Name { get; set; }
        public Course Course_channel { get; set; }
        public Event Event_channel { get; set; }
        public User User_channel { get; set; }
        public Admin Admin_channel { get; set; }


        public Channel(string name)
        {
            Name = name;

        }

        public Channel get_Channel_Info(Channel c)
        {
            return c;
        }

    }
}
