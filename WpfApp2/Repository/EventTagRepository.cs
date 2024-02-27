using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.FileHandler;
using WpfApp2.Model;

namespace WpfApp2.Repository
{
    public class EventTagRepository
    {
        public EventTagFile eventTagFile=new EventTagFile();

        public List<EventTag> eventsTags = new List<EventTag>();


        public EventTagRepository()
        {
        }

        public List<EventTag> GetAll()
        {
            return eventTagFile.Read();
        }

        public EventTag GetById(string id)
        {
            eventsTags = GetAll();
            if (eventsTags == null)
            {
                eventsTags=new List<EventTag>();
            }
            foreach (EventTag e in eventsTags)
            {
                if (e.Id == id)
                    return e;
            }
            return null;
        }

        public void Create(EventTag eventsTag)
        {
            
            eventsTags = GetAll();
            if (eventsTags == null)
            {
                eventsTags=new List<EventTag>();
            }
            eventsTags.Add(eventsTag);
            eventTagFile.Save(eventsTags);
        }

        public void Delete(string id)
        {
             eventsTags = GetAll();
            if (eventsTags == null)
            {
                eventsTags = new List<EventTag>();
            }
            foreach (EventTag e in eventsTags)
            {
                if (e.Id == id)
                {
                    eventsTags.Remove(e);
                    break;
                }
            }
            eventTagFile.Save(eventsTags);
        }

        public void Update(EventTag e)
        {
            List<EventTag> tags = GetAll();
            if (tags == null)
            {
                tags = new List<EventTag>();
            }
            foreach (EventTag tag in tags)
            {
                if (tag.Id == e.Id)
                {
                    tags.Remove(tag);
                    tags.Add(e);
                    break;
                }
            }
            eventTagFile.Save(tags);
        }

        public EventTag GetByName(string name)
        {
            eventsTags = GetAll();
            if (eventsTags == null)
            {
                eventsTags = new List<EventTag>();
            }
            foreach (EventTag e in eventsTags)
            {
                if (e.Name == name)
                    return e;
            }
            return null;
        }
    }
}
