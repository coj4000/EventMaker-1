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
        private ObservableCollection<Event> eventCollection;

        public ObservableCollection<Event> EventCollection
        {
            get { return eventCollection; }
            set { eventCollection = value; }
        }

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

            eventCollection = new ObservableCollection<Event>();
            eventCollection.Add(event1);
        }

        public void AddEvent(Event e)
        {
            this.eventCollection.Add(e);
        }
    }
}
