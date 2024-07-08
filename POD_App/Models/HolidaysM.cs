using Newtonsoft.Json;

namespace POD_App.Models
{
    public class HolidaysM
    {
        public string division { get; set; }
        public List<Event> events { get; set; }
    }
    public class Event
    {
        public string title { get; set; }
        public string date { get; set; }
        public string notes { get; set; }
        public bool bunting { get; set; }
    }
    public class Htest
    {
        [JsonProperty("england-and-wales")]
        public HolidaysM englandandwales { get; set; }
    }


}
