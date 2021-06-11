using System;

namespace Timuon.Models
{
    public class Platform : Communication
    {
        public string Name { get; set; }
        public string UserName { get; set; }

        public Platform(string name, string userName)
        {
            Name = name;
            UserName = userName;
        }
    }
}
