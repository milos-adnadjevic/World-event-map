using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Model;

namespace WpfApp2.FileHandler
{
    public class EventFile
    {
        private string path = @"..\..\Data\EventFile.txt";
        public List<Event> Read()
        {
            if(!System.IO.File.Exists(path))
            {
                return new List<Event>();
            }

            string eventSerialized = System.IO.File.ReadAllText(path);
            List<Event> events = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Event>>(eventSerialized);
            return events;
        }

        public void Save(List<Event> events)
        {
            string eventSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(events);
            System.IO.File.WriteAllText(path, eventSerialized);
        }

        public EventFile()
        {
        }
    }
}
