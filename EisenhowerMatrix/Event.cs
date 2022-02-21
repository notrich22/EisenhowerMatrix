using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EisenhowerMatrix
{
    public class Event
    {
        //public DateTime Date {get;set;}
        public string Name {get;set;}
        public bool is_important { get;set;}
        public bool is_urgent { get;set;}
        public Event(string Name, bool importance, bool urgency)
        {
            this.Name = Name;
            this.is_important = importance;
            this.is_urgent = urgency;
        }
    }
}
