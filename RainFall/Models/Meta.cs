using System.Runtime.Serialization;

namespace RainFall.Models
{
    [DataContract]
    public class Meta
    {
        [DataMember(Name = "publisher")]
        public string Publisher { get; set; }

        [DataMember(Name = "licence")]
        public string Licence { get; set; }

        [DataMember(Name = "documentation")]
        public string Documentation { get; set; }

        [DataMember(Name = "version")]
        public string Version { get; set; }

        [DataMember(Name = "comment")]
        public string Comment { get; set; }

        [DataMember(Name = "hasFormat")]
        public List<string> HasFormat { get; set; }
    }
}
