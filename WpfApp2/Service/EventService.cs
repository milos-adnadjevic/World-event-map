using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Model;
using WpfApp2.Repository;

namespace WpfApp2.Service
{
    public class EventService
    {
        public EventRepository eventRepository=new EventRepository();

        public EventService( )
        {
          
        }

        public List<Event> GetAll()
        {
           return eventRepository.GetAll();
        }

        public Event GetById(string id)
        {
            return eventRepository.GetById(id);
        }

        public void Create(Event events)
        {
            eventRepository.Create(events);
        }

        public void Delete (string id)
        {
            eventRepository.Delete(id);
        }

        public void Update(Event e)
        {
            eventRepository.Update(e);
        }

        public List<Event> Search (string name,string type,string description,string capacity)
        {
           // string[] listOfParametars = new string[3];
            //string[] listOfParametars = searchText.Split(',');
            List<Event> searched = eventRepository.Search(name,type,description,capacity);
            return searched;          
            
        }
        public List<Event> Filter(string filterText)
        {
          
            List<Event> filtered = eventRepository.Filter(filterText);
            return filtered;

        }

        public Event TakePosition (string id, double x, double y)
        {
            Event e = GetById(id);
            e.XPositions = x;
            e.YPositions = y;

             return eventRepository.TakePosition(e); 
        }


        public List<Event> FilterOnMap(string filterText)
        {
            return eventRepository.FilterOnMap(filterText);
        }

    }
}
