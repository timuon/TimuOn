using System;

using System.Collections.Generic;

namespace Timuon.Models
{
    public class Message
    {
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }

        public Message(string sender, string receiver, DateTime date, string content)
        {
            Sender = sender;
            Receiver = receiver;
            Date = date;
            Content = content;
        }
    }
}

