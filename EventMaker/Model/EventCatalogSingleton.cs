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

        private static EventCatalogSingleton instance;

        public static EventCatalogSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EventCatalogSingleton();
                }

                return instance;
            }
        }

        private EventCatalogSingleton()
        {
            Event event1 = new Event(1, "Møde", "Her er der tekst", "Her", new DateTime(2017, 5, 5));

            eventcollection = new ObservableCollection<Event>();
            eventcollection.Add(event1);
        }

        public void AddEvent(Event e)
        {
            this.eventcollection.Add(e);
        }
    }
}
