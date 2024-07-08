namespace POD_App.Models
{
    public class TodayUploadM
    {

        public int Id { get; set; }
        public string consigneeName { get; set; }
        public string consigneeCity { get; set; }
        public string wareHouseName { get; set; }
        public string lrNo { get; set; }
        public string lRdate { get; set; }
        public string invoiceno { get; set; }
        public string reson { get; set; }
        public string status { get; set; }
        public List<string> podPics
        {
            get; set;
        }
    }
}
