using System;

using System.Collections.Generic;

namespace Timuon.Models
{
    public class Conflict
    {
        public string Reason { get; set; }
        public string Communication { get; set; }
        public string User { get; set; }
        public string Change { get; set; }

        public Conflict(string reason, string communication, string user, string change)
        {
            Reason = reason;
            Communication = communication;
            User = user;
            Change = change;
        }
    }
}

