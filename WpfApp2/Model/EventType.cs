using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
    public class EventType
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string ImagePath { get; set; }

        public EventType(string id, string name, string imagePath)
        {
            Id = id;
            Name = name;
            ImagePath = imagePath;
        }

        public EventType()
        {
        }
    }
}
