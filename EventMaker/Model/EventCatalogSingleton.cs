using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMaker.Persistency;

namespace EventMaker.Model
{
    public class EventCatalogSingleton
    {
        #region Properties
        public PersistencyService ps;

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
        #endregion

        private EventCatalogSingleton()
        {
            ps = new PersistencyService();
            eventCollection = new ObservableCollection<Event>();
            FetchEvents();
        }
        
        #region Methods
        public void AddEvent(Event e)
        {
            this.eventCollection.Add(e);
        }

        private async void FetchEvents()
        {
            var events = await ps.LoadEventsFromJsonAsync();

            if (events != null)
            {
                foreach (var item in events)
                {
                    eventCollection.Add(item);
                }
            }
            else
            {
                eventCollection = new ObservableCollection<Event>();
                ps.SaveEventsAsJsonAsync(eventCollection);
            }
        }

        private async void RemoveEvent(Event e)
        {
            eventCollection.Remove(e);
            ps.SaveEventsAsJsonAsync(eventCollection);
        }
        #endregion
    }
}

