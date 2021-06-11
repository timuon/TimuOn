using System;

using System.Collections.Generic;

namespace Timuon.Models
{
    public class CloudDrive
    {
        public string Name { get; set; }
        public CloudDrive(string name)
        {
            Name = name;
        }
        public void create_Drive()
        {
            CloudDrive d = new CloudDrive("Drive");
        }
    }
}

