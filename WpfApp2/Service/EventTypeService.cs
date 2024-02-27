using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Model;
using WpfApp2.Repository;

namespace WpfApp2.Service
{
    public class EventTypeService
    {
        public EventTypeRepository eventTypeRepository=new EventTypeRepository();

        public EventTypeService( )
        {
     
        }

        public List<EventType> GetAll()
        {
            return eventTypeRepository.GetAll();
        }

        public EventType GetById(string id)
        {
            return eventTypeRepository.GetById(id);
        }

        public void Create(EventType eventType)
        {
            eventTypeRepository.Create(eventType);
        }

        public void Delete(string id)
        {
            eventTypeRepository.Delete(id);
        }
        public void Update(EventType eventType)
        {
            eventTypeRepository.Update(eventType);
        }

        public List<string> GetEventTypeNames()
        {
            List<string> eventTypeNames = new List<string>();
            List<EventType> eventTypes = eventTypeRepository.GetAll();
            foreach( EventType eventType in eventTypes)
            {
                eventTypeNames.Add(eventType.Name);
            }

            return eventTypeNames;

        }

        public EventType GetByName(string name)
        {
            return eventTypeRepository.GetByName(name);
        }
    }
}
