using System.Runtime.Serialization;

namespace RainFall.Models
{
    [DataContract]
    public class BaseModel
    {
        [DataMember(Name = "@context")]
        public string Context { get; set; }

        [DataMember(Name = "meta")]
        public Meta Meta { get; set; }

        [DataMember(Name = "items")]
        public List<Item> Items { get; set; }

        [DataMember(Name = "limit")]
        public int Limit { get; set; }
    }
}
