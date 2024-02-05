using System.Runtime.Serialization;

namespace RainFall.Models
{
    [DataContract]
    public class FloodMonitoringData
    {
        [DataMember(Name = "@context")]
        public string Context { get; set; }

        [DataMember(Name = "meta")]
        public Meta Meta { get; set; }

        [DataMember(Name = "items")]
        public List<Item> Items { get; set; }
    }
}
