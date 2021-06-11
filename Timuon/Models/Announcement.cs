using System;

using System.Collections.Generic;

namespace Timuon.Models
{
    public class Announcement : Message
    {
        public string Audience { get; set; }

        public Announcement(string audience, string sender, string receiver, DateTime date, string content) :
           base(sender, receiver, date, content)
        {
            Audience = audience;
        }
    }
}

