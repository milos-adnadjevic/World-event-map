using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.FileHandler;
using WpfApp2.Model;

namespace WpfApp2.Repository
{
    public class EventTypeRepository
    {
        public EventTypeFile eventTypeFile=new EventTypeFile();

        public EventTypeRepository()
        {
        }

        public List<EventType> GetAll()
        {
            return eventTypeFile.Read();
        }

        public EventType GetById(string id)
        {
            List<EventType> eventTypes = GetAll();
            if(eventTypes == null)
            {
                eventTypes = new List<EventType> ();
            }
            foreach (EventType e in eventTypes)
            {
                if (e.Id == id)
                    return e;
            }
            return null;
        }

        public void Create(EventType eventType)
        {
            List<EventType> eventTypes = GetAll();
            if (eventTypes == null)
            {
                eventTypes = new List<EventType>();
            }
            eventTypes.Add(eventType);
            eventTypeFile.Save(eventTypes);
        }

        public void Delete(string id)
        {
            List<EventType> eventTypes = GetAll();
            if (eventTypes == null)
            {
                eventTypes = new List<EventType>();
            }
            foreach (EventType e in eventTypes)
            {
                if (e.Id == id)
                {
                    eventTypes.Remove(e);
                    break;
                }
            }
            eventTypeFile.Save(eventTypes);
        }

        public void Update(EventType e)
        {
            List<EventType> types = GetAll();
            if (types == null)
            {
                types = new List<EventType>();
            }
            foreach (EventType type in types)
            {
                if (type.Id == e.Id)
                {
                    types.Remove(type);
                    types.Add(e);
                    break;
                }
            }
            eventTypeFile.Save(types);
        }
        public EventType GetByName(string name)
        {
            List<EventType> eventTypes = GetAll();
            if (eventTypes == null)
            {
                eventTypes = new List<EventType>();
            }
            foreach (EventType e in eventTypes)
            {
                if (e.Name == name)
                    return e;
            }
            return null;
        }
    }
}
