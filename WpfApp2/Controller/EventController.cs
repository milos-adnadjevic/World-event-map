using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Model;
using WpfApp2.Service;

namespace WpfApp2.Controller
{
    public class EventController
    {
        public EventService eventService=new EventService();



        public List<Event> GetAll()
        {
            return eventService.GetAll();
        }

        public Event GetById(string id)
        {
            return eventService.GetById(id);
        }

        public void Create(Event events)
        {
            eventService.Create(events);
        }

        public void Delete(string id)
        {
            eventService.Delete(id);
        }

        public void Update(Event e) 
        { 
            eventService.Update(e);
        }

        public List<Event> Search(string name,string type,string description,string capacity)
        {           
            List<Event> searched = eventService.Search(name,type,description,capacity);
            return searched;
        }

        public List<Event> Filter(string filterText)
        {
            List<Event> filtered = eventService.Filter(filterText);
            return filtered;
        }

        public Event TakePosition(string id , double x, double y) 
        { 
            return eventService.TakePosition(id, x, y);
        }

        public List<Event> FilterOnMap(string filterText)
        {
          return  eventService.FilterOnMap(filterText);
        }
    }
}
