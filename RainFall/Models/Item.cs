using System.Runtime.Serialization;

namespace RainFall.Models
{
    [DataContract]
    public class Item
    {
        [DataMember(Name = "@id")]
        public string Id { get; set; }

        [DataMember(Name = "label")]
        public string? Label { get; set; }

        [DataMember(Name = "latestReading")]
        public LatestReading? LatestReading { get; set; }

        [DataMember(Name = "notation")]
        public string? Notation { get; set; }

        [DataMember(Name = "parameter")]
        public string? Parameter { get; set; }

        [DataMember(Name = "parameterName")]
        public string? ParameterName { get; set; }

        [DataMember(Name = "period")]
        public int? Period { get; set; }

        [DataMember(Name = "qualifier")]
        public string? Qualifier { get; set; }

        [DataMember(Name = "station")]
        public string? Station { get; set; }

        [DataMember(Name = "stationReference")]
        public string? StationReference { get; set; }

        [DataMember(Name = "unit")]
        public string? Unit { get; set; }

        [DataMember(Name = "unitName")]
        public string? UnitName { get; set; }

        [DataMember(Name = "valueType")]
        public string ValueType { get; set; }

        [DataMember(Name = "dateTime")]
        public string? DateTime { get; set; }

        [DataMember(Name = "measure")]
        public string? Measure { get; set; }

        [DataMember(Name = "value")]
        public double? Value { get; set; }
    }
}
