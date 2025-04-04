﻿namespace POD_App.Models
{
    public class SpaceEM
    {
        public int id { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public bool featured { get; set; }
        public string type { get; set; }
        public string country_code { get; set; }
        public string abbrev { get; set; }
        public string description { get; set; }
        public string administrator { get; set; }
        public string founding_year { get; set; }
        public string launchers { get; set; }
        public string spacecraft { get; set; }
        public object parent { get; set; }
        public string image_url { get; set; }
        public string logo_url { get; set; }
    }

    public class SpaceEML
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<SpaceEM> results { get; set; }
    }
}
