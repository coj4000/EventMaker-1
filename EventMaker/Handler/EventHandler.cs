using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMaker.Converter;
using EventMaker.Model;
using EventMaker.ViewModel;

namespace EventMaker.Handler
{
    public class EventHandler
    {
        private EventViewModel EventViewModel;

        public EventHandler(EventViewModel eventViewModel)
        {
            this.EventViewModel = eventViewModel;
        }

        public void CreateEvent()
        {
            Event newEvent = new Event {DateTime = DateTimeConverter.DateTimeOffseDateTimeSeDateTime(EventViewModel.Date, EventViewModel.Time),
                Description = EventViewModel.Description,
                Id = EventViewModel.Id,
                Name = EventViewModel.Name,
                Place = EventViewModel.Place};
        }
    }
}
