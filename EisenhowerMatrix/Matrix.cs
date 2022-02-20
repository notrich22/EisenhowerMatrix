using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EisenhowerMatrix
{
    internal class Matrix
    {
        public List<Event> ToDo { get; set; }
        public List<Event> ToDecide { get; set; }
        public List<Event> ToDelegate { get; set; }
        public List<Event> ToEliminate { get; set; }

        public void Add_Event(Event e)
        {
            if(e.is_important && e.is_urgent)
            {
                ToDo.Append(e);
                return;
            }
            if(e.is_important && !e.is_urgent)
            {
                ToDecide.Append(e);
                return;
            }
            if(!e.is_important && e.is_urgent)
            {
                ToDelegate.Append(e);
                return;
            }
            if(!e.is_important && !e.is_urgent)
            {
                ToEliminate.Append(e);
                return;
            }
        }
        public bool Delete_Event(string name)
        {
            Event to_delete = find_by_name(name);
            if(to_delete != null)
            {
                foreach (Event e in ToDo)
                {
                    if (e == to_delete) ToDo.Remove(e);
                }
                foreach (Event e in ToDecide)
                {
                    if (e == to_delete) ToDecide.Remove(e);
                }
                foreach (Event e in ToDelegate)
                {
                    if (e == to_delete) ToDelegate.Remove(e);
                }
                foreach (Event e in ToEliminate)
                {
                    if (e == to_delete) ToEliminate.Remove(e);
                }
                return true;
            }
            return false;
        }
        public Event find_by_name(string name)
        {
            foreach(Event e in ToDo)
            {
                if (e.Name == name) return e;
            }
            foreach (Event e in ToDecide)
            {
                if (e.Name == name) return e;
            }
            foreach (Event e in ToDelegate)
            {
                if (e.Name == name) return e;
            }
            foreach (Event e in ToEliminate)
            {
                if (e.Name == name) return e;
            }
            return null;
        }
    }
}
