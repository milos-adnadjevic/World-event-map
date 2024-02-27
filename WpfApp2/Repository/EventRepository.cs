using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.FileHandler;
using WpfApp2.Model;

namespace WpfApp2.Repository
{
    public class EventRepository
    {
        public EventFile eventFile=new EventFile();

        public EventRepository( )
        {
           
        }
        public List<Event> GetAll()
        {
            return eventFile.Read();
        }

        public Event GetById(string id)
        {
            List<Event> events = GetAll();
            if (events == null)
            {
                events= new List<Event>();
            }
            foreach(Event e in events)
            {
                if(e.Id == id)
                    return e;
            }
            return null;
        }

        public void Create(Event events)
        {
            List<Event> events1 = GetAll();
            if (events1 == null)
            {
                events1 = new List<Event>();
            }
            events1.Add(events);
            eventFile.Save(events1);
        }

        public void Delete(string id)
        {
            List<Event> events = GetAll();
            if (events == null)
            {
                events = new List<Event>();
            }
            foreach (Event e in events)
            {
                if (e.Id == id)
                {
                    events.Remove(e);
                    break;
                }
            }
            eventFile.Save(events);
        }
        public void Update(Event e)
        {
            List<Event> events = GetAll();
            if (events == null)
            {
                events = new List<Event>();
            }  
            foreach (Event e1 in events)
            {
                if (e1.Id == e.Id)
                {
                    events.Remove(e1);
                    events.Add(e);
                    break;
                }
            }
            eventFile.Save(events);
        }

        public List<Event> Search(string name , string type, string description, string capacity)
        {
            List<Event> events = GetAll();
            List<Event> searched = new List<Event>();
            bool findName = false;
            bool findType = false;
            bool findDescription = false;
            bool findCapacity = false;
            if (events == null)
            {
                events = new List<Event>();
            }
            if(name=="" && type == "" && description == "" && capacity == "")
            {
                return events;
            }

            foreach (Event e in events)
            { 
                findName = false;
                findType= false;
                findDescription = false;
                findCapacity = false;
             
                
                    if (e.Name.ToLower().Equals(name.ToLower()) == true)
                    {
                        findName = true;
                    }
                

                   
                
                    if (e.Type.Name.ToLower().Equals(type.ToLower()) == true)
                    {
                        findType = true;
                    }
                
             
                     if (e.Description.ToLower().Equals(description.ToLower()) == true)
                    {
                        findDescription = true;
                    }
                
                    
            
                
                     if (e.Capacity.Equals(capacity.ToLower()) == true )
                    {
                        findCapacity = true;
                    }



                //}
                if (name == "" && findType == true && findDescription == true && findCapacity == true)
                {
                    searched.Add(e);
                }
                if (findName == true && type == "" && findDescription == true && findCapacity == true)
                {
                    searched.Add(e);
                }
                if (findName == true && findType == true && description == "" && findCapacity == true)
                {
                    searched.Add(e);
                }
                if (findName == true && findType == true && findDescription == true && capacity == "")
                {
                    searched.Add(e);
                }


                if (name == "" && type == "" && findDescription == true && findCapacity == true)
                {
                    searched.Add(e);
                }
                if (name == "" && findType == true && description == "" && findCapacity == true)
                {
                    searched.Add(e);
                }
                if (name == "" && findType == true && findDescription == true && capacity == "")
                {
                    searched.Add(e);
                }


                if (name == "" && type == "" && description == "" && findCapacity == true)
                {
                    searched.Add(e);
                }
                if (name == "" && type == "" && findDescription == true && capacity == "")
                {
                    searched.Add(e);
                }
                if (name == "" && findType == true && description == "" && capacity == "")
                {
                    searched.Add(e);
                }


                if (findName == true && type == "" && description == "" && findCapacity == true)
                {
                    searched.Add(e);
                }
                if (findName == true && type == "" && findDescription == true && capacity == "")
                {
                    searched.Add(e);
                }


                if (findName == true && type == "" && description == "" && capacity == "")
                {
                    searched.Add(e);
                }

                if (findName == true && findType == true && description == "" && capacity == "")
                {
                    searched.Add(e);
                }
     
                if (findName == true  && findType == true && findDescription == true && findCapacity ==true)
                {
                    searched.Add(e);
                }
                                              
            }

            return searched;
        }


        public List<Event> Filter(string filterText)
        {
            List<Event> events = GetAll();
            List<Event> filtered = new List<Event>();
           
            if (events == null)
            {
                events = new List<Event>();
            }

            foreach(Event e in events)
            {
                if(e.Name.ToLower().Contains(filterText.ToLower()) || e.Type.Name.ToLower().Contains(filterText.ToLower()) || e.Description.ToLower().Contains(filterText.ToLower()) || e.Capacity.ToLower().Contains(filterText.ToLower()) == true)
                {
                    filtered.Add(e);
                }
            }

            return filtered;
        }

        public Event TakePosition (Event e)
        {

            List<Event> events = GetAll();
            if (events == null)
            {
                events = new List<Event>();
            }
            foreach(Event e1  in events) 
            {
                if(e1.Id==e.Id)
                {
                    events.Add(e);
                    events.Remove(e1);
                    break;
                }
            }
            
            
            eventFile.Save(events);
            return e;

        }


        public List<Event> FilterOnMap(string filterText)
        {
            List<Event> events = GetAll();
            List<Event> filtered = new List<Event>();
            List<Event> eventsOnMap=new List<Event>();

            if (events == null)
            {
                events = new List<Event>();
            }
            foreach (Event e in events)
            {
                if(e.XPositions!=0 && e.YPositions != 0)
                {
                    eventsOnMap.Add(e);
                }
            }

            foreach (Event e in eventsOnMap)
            {
                if (e.Name.ToLower().Contains(filterText.ToLower()))
                {
                    filtered.Add(e);
                }
            }

            return filtered;
        }





    }
}
