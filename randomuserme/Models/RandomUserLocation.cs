using System;
using System.Runtime.Serialization;

namespace Models
{
    /* JSON
    "location": {
        "street": "7501 شهید مطهری",
        "city": "تبریز",
        "state": "زنجان",
        "postcode": 91499
    }
    */
    [DataContract]
    public class RandomUserLocation
    { 
        [DataMember(Name="street")]
        public string Street { get; set; }
        [DataMember(Name="postcode")]
        public string PostalCode { get; set; }
        [DataMember(Name="city")]
        public string City { get; set; }
        [DataMember(Name="state")]
        public string State { get; set; }
        

        public RandomUserLocation() 
        {
        }

        public override string ToString() 
        {
            var tempStr = "{0} {1}-{2} ({3})";
            return String.Format(tempStr,Street,PostalCode,City,State);
        }
    }
}
