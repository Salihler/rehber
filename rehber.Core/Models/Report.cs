namespace rehber.Core.Models
{
    public class Report
    {
        public string Location { get; set; }
        public int Contacts { get; set; }

        //[JsonProperty("Phone Numbers")]
        public int PhoneNumbers { get; set; }
    }
}