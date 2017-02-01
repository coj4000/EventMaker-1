using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Popups;
using EventMaker.Model;
using Newtonsoft.Json;

namespace EventMaker.Persistency
{
    public class PersistencyService
    {

        private static string eventFileName = "Events.txt";

        public static async void SaveEventsAsJsonAsync(ObservableCollection<Event> events)
        {
            string eventsJsonString = JsonConvert.SerializeObject(events);
            SerializeEventsFileAsync(eventsJsonString, eventFileName);
        }


        public static async void SerializeEventsFileAsync(string eventsString, string fileName)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(localFile, eventsString);
        }
        /*
        public static async Task<List<Event>> LoadEventsFromJsonAsync()
        {
            
        }

        public static async void SerializeEventsFileAsync(string eventsString, string fileName)
        {
            
        }

        public static async Task<string> DeSerializeEventFileAsync(string fileName)
        {
            
        }
        */
    }
}
