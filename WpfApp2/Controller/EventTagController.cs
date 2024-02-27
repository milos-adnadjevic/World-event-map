using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Model;
using WpfApp2.Service;

namespace WpfApp2.Controller
{
    public class EventTagController
    {
        public EventTagService eventTagService=new EventTagService();

        



        public EventTagController()
        {
        }

        public List<EventTag> GetAll()
        {
            return eventTagService.GetAll();
        }

        public EventTag GetById(string id)
        {
            return eventTagService.GetById(id);
        }

        public void Create(EventTag eventTag)
        {
            eventTagService.Create(eventTag);
        }

        public void Delete(string id)
        {
            eventTagService.Delete(id);
        }

        public void Update(EventTag eventTag)
        {
            eventTagService.Update(eventTag);
        }

        public List<string> GetEventTagNames()
        {
            return eventTagService.GetEventTagNames();
        }

        public EventTag GetByName(string name)
        {
            return eventTagService.GetByName(name);
        }
    }
}
