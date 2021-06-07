using System;

namespace Timuon.Models
{
    public class Calendar
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Meeting { get; set; }
        public string Requests { get; set; }

        public Calendar(int iD, string type, string meeting, string requests)
        {
            ID = iD;
            Type = type;
            Meeting = meeting;
            Requests = requests;
        }
    }
}

