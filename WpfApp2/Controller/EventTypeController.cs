using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Model;
using WpfApp2.Service;

namespace WpfApp2.Controller
{
    public class EventTypeController
    {
        public EventTypeService eventTypeService=new EventTypeService();

  
        public List<EventType> GetAll()
        {
            return eventTypeService.GetAll();
        }

        public EventType GetById(string id)
        {
            return eventTypeService.GetById(id);
        }

        public void Create(EventType eventType)
        {
            eventTypeService.Create(eventType);
        }

        public void Delete(string id)
        {
            eventTypeService.Delete(id);
        }

        public void Update(EventType eventType)
        {
            eventTypeService.Update(eventType);
        }
       public List<string> GetEventTypeNames()
       {
           return eventTypeService.GetEventTypeNames();
       }

        public EventType GetByName(string name)
        {
            return eventTypeService.GetByName(name);
        }
    }
}
