using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
    public class Event
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public EventType Type { get; set; }
        public double OrganizationFee { get; set; }
        public string Capacity { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public DateTime Date { get; set; }
        public double TicketPrice { get; set; }
        public bool Humanitarian { get; set; }
        public string Description { get; set; }
        public EventTag Tag { get; set; }

        public string ImagePath { get; set; }

        public double XPositions { get; set; } = 0;
        public double YPositions { get; set; } = 0;

        public Event(string id, string name, EventType type, double organizationFee, string capacity,string state, string city, DateTime date, double ticketPrice, bool humanitarian, string description, EventTag tag, string imagePath)
        {
            Id = id;
            Name = name;
            Type = type;
            OrganizationFee = organizationFee;
            Capacity = capacity;
            State =state;
            City = city;
            Date = date;
            TicketPrice = ticketPrice;
            Humanitarian = humanitarian;
            Description = description;
            Tag = tag;
            ImagePath = imagePath;
        }

        public Event()
        {
        }
    }
}
