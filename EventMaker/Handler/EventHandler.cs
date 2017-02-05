using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMaker.Converter;
using EventMaker.Model;
using EventMaker.ViewModel;
using EventMaker.Persistency;

namespace EventMaker.Handler
{
    public class EventHandler
    {
        #region Properties
        private EventViewModel EventViewModel;

        public PersistencyService ps;

        public EventHandler(EventViewModel eventViewModel)
        {
            this.EventViewModel = eventViewModel;
            ps = new PersistencyService();
        }
        #endregion

        public void CreateEvent()
        {
            Event newEvent = new Event
            (
                EventViewModel.Id,
                EventViewModel.Name,
                EventViewModel.Description,
                EventViewModel.Place,
                DateTimeConverter.DateTimeOffseDateTimeSeDateTime(EventViewModel.Date, EventViewModel.Time)
            );

            EventViewModel.EventCatalogSingleton.AddEvent(newEvent);
            StoreJsonList();
         }

        #region Methods
        public void RemoveEvent()
        {
            EventCatalogSingleton.Instance.EventCollection.Remove(EventViewModel.SelectedEvent);
            StoreJsonList();
        }

        public void StoreJsonList()
        {
            ps.SaveEventsAsJsonAsync(EventCatalogSingleton.Instance.EventCollection);
        }
        #endregion
    }
}
