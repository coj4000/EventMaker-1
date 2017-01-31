using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    public class EventCatalogSingleton
    {
        public ObservableCollection<Event> eventcollection = new ObservableCollection<Event>();

        public EventCatalogSingleton()
        {
            Event event1 = new Event(1,"Møde","Her er der tekst","Her", new DateTime(2017,5,5));
            //Event event2 = new Event();
            //Event event3 = new Event(); 
            eventcollection = new ObservableCollection<Event>();
        }

        public void AddEvent(Event e)
        {
            eventcollection.Add(e);
        }

    }
}
