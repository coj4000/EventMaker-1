using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    public class Event
    {
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
        private DateTime dateTime;

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        public Event()
        {
            
        }

        public override string ToString()
        {

            return base.ToString();
        }
    }
}
