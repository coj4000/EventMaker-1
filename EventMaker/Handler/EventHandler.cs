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
        private EventViewModel EventViewModel;

        public PersistencyService ps;

        public EventHandler(EventViewModel eventViewModel)
        {
            this.EventViewModel = eventViewModel;
            ps = new PersistencyService();
        }

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

            ps.SaveEventsAsJsonAsync(EventCatalogSingleton.Instance.EventCollection);
        }
    }
}
