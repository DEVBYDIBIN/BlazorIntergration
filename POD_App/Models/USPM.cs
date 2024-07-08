using Microsoft.Azure.Amqp.Framing;
using Newtonsoft.Json;

namespace POD_App.Models
{
    public class USPM
    {
        public string source_name { get; set; }
        public string source_description { get; set; }
        public string dataset_name { get; set; }
        public string dataset_link { get; set; }
        public string table_id { get; set; }
        public string topic { get; set; }
        public string subtopic { get; set; }
    }

    public class Datum
    {
        [JsonProperty("ID Nation")]
        public string IDNation { get; set; }
        public string Nation { get; set; }

        [JsonProperty("ID Year")]
        public int IDYear { get; set; }
        public string Year { get; set; }
        public int Population { get; set; }

        [JsonProperty("Slug Nation")]
        public string SlugNation { get; set; }
    }

    public class USAPL
    {
        public List<Datum> data { get; set; }
        public List<Source> source { get; set; }
    }

    public class Source
    {
        public List<string> measures { get; set; }
        public USPM annotations { get; set; }
        public string name { get; set; }
        public List<object> substitutions { get; set; }
    }



}
