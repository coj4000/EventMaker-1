using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    public class Event
    {
        #region Properties
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
        #endregion

        public Event(int id, string name, string description, string place, DateTime datetime)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Place = place;
            this.DateTime = datetime;
        }

        #region Methods
        public override string ToString()
        {
            return string.Format("Id: {0} Name: {1} Description: {2} Place: {3} DateTime: {4}", Id, Name, Description, Place, DateTime);
        }
        #endregion
    }
}
