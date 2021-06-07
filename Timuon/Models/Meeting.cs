using System;

namespace Timuon.Models
{
    public class Meeting : Calendar
    {
        // TODO: probably just associated with Calendar
        public string Users { get; set; }
        public DateTime Date { get; set; }
    }
}

