using Newtonsoft.Json;

namespace POD_App.Models
{
    public class UniversityL
    {
        public string alpha_two_code { get; set; }
        public string name { get; set; }
        public List<string> domains { get; set; }
        public List<string> web_pages { get; set; }
        public string country { get; set; }

        [JsonProperty("state-province")]
        public object stateprovince
        {
            get; set;
        }
    }
}
