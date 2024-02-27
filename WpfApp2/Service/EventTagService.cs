using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Model;
using WpfApp2.Repository;

namespace WpfApp2.Service
{
    public class EventTagService
    {

        public EventTagRepository eventTagRepository=new EventTagRepository();

      

        public EventTagService()
        {
        }

        public List<EventTag> GetAll()
        {
            return eventTagRepository.GetAll();
        }

        public EventTag GetById(string id)
        {
            return eventTagRepository.GetById(id);
        }

        public void Create(EventTag eventTag)
        {
            eventTagRepository.Create(eventTag);
        }

        public void Delete(string id)
        {
            eventTagRepository.Delete(id);
        }
        public void Update(EventTag eventTag)
        {
            eventTagRepository.Update(eventTag);
        }

        public List<string> GetEventTagNames()
        {
            List<string> eventTagNames = new List<string>();
            List<EventTag> eventTags = eventTagRepository.GetAll();
            foreach (EventTag eventTag in eventTags)
            {
                eventTagNames.Add(eventTag.Name);
            }

            return eventTagNames;

        }

        public EventTag GetByName(string name)
        {
            return eventTagRepository.GetByName(name);
        }

    }
}
