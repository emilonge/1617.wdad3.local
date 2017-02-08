using System;
using System.Runtime.Serialization;

namespace Com.Ahs.Forcastio.Models
{
    [DataContract]
    public class ForecastIO
    {
        [DataMember(Name="latitude")]
        public decimal Latitude { get; set; }
        [DataMember(Name="longitude")]
        public decimal Longitude { get; set; }
        [DataMember(Name="timezone")]
        public string Timezone { get; set; }
        [DataMember(Name="offset")]
        public int Offset { get; set; }
        [DataMember(Name="currently")]
        public ForecastCurrently Now { get; set; }

        public ForecastIO() {
        }
    }
}
