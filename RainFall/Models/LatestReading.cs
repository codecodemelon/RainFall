using System.Runtime.Serialization;

namespace RainFall.Models
{
    [DataContract]
    public class LatestReading
    {
        [DataMember(Name = "@id")]
        public string Id { get; set; }

        [DataMember(Name = "date")]
        public string Date { get; set; }

        [DataMember(Name = "dateTime")]
        public string DateTime { get; set; }

        [DataMember(Name = "measure")]
        public string Measure { get; set; }

        [DataMember(Name = "value")]
        public decimal Value { get; set; }
    }
}
