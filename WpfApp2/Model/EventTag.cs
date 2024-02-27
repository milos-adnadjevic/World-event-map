using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
    public class EventTag
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string TagDescription { get; set; }

        public EventTag(string id,string color, string name,  string tagDescription)
        {
            Id = id;
            Name = name;
            Color = color;
            TagDescription = tagDescription;
        }

        public EventTag()
        {
        }
    }
}
