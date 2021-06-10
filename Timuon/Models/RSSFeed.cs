using System;

namespace Timuon.Models
{
    public class RSSFeed
    {
        public string URL { get; set; }
        public string Name { get; set; }
        public string[] Categories { get; set; }

        public RSSFeed() { }

        public RSSFeed(string uRL)
        {
            URL = uRL;
        }

        public RSSFeed(string uRL, string name, string[] categories) : this(uRL)
        {
            URL = uRL;
            Name = name;
            Categories = categories;
        }

        public void UpdateFeed(string name, string[] categories)
        {
            this.Name = name;
            this.Categories = categories;
        }
    }
}
