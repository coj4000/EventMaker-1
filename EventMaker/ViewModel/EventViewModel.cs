using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMaker.Model;

namespace EventMaker.ViewModel
{
    public class EventViewModel
    {
        private EventCatalogSingleton eventCatalogSingleton;

        public EventCatalogSingleton EventCatalogSingleton
        {
            get { return eventCatalogSingleton; }
            set { eventCatalogSingleton = value; }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string place;

        public string Place
        {
            get { return place; }
            set { place = value; }
        }

        private DateTimeOffset _date;

        public DateTimeOffset Date 
        {
            get { return _date; }
            set { _date = value; }
        }

        private TimeSpan _time;

        public TimeSpan Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public EventViewModel()
        {
            DateTime dt = System.DateTime.Now;
            _date = new DateTimeOffset(dt.Year, dt.Month, dt.Day, 0,0,0,0, new TimeSpan());
            _time = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
        }

    }
}
