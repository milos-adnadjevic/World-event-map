using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Model;

namespace WpfApp2.FileHandler
{
    public class EventTagFile
    {
        private string path = @"..\..\Data\EventTagFile.txt";
        public List<EventTag> Read()
        {
            if (!System.IO.File.Exists(path))
            {
                return new List<EventTag>();
            }

            string eventTagSerialized = System.IO.File.ReadAllText(path);
            List<EventTag> eventsTag = Newtonsoft.Json.JsonConvert.DeserializeObject<List<EventTag>>(eventTagSerialized);
            return eventsTag;
        }

        public void Save(List<EventTag> eventsTag)
        {
            string eventTagSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(eventsTag);
            System.IO.File.WriteAllText(path, eventTagSerialized);
        }

        public EventTagFile()
        {
        }
    }
}
