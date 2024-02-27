using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Model;

namespace WpfApp2.FileHandler
{
    public class EventTypeFile
    {
        private string path = @"..\..\Data\EventTypeFile.txt";
        public List<EventType> Read()
        {
            if (!System.IO.File.Exists(path))
            {
                return new List<EventType>();
            }

            string eventTypeSerialized = System.IO.File.ReadAllText(path);
            List<EventType> eventsType = Newtonsoft.Json.JsonConvert.DeserializeObject<List<EventType>>(eventTypeSerialized);
            return eventsType;
        }

        public void Save(List<EventType> eventsType)
        {
            string eventTypeSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(eventsType);
            System.IO.File.WriteAllText(path, eventTypeSerialized);
        }

        public EventTypeFile()
        {
        }
    }
}
