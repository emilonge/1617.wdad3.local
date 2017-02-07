using System;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class RandomUserPicture
    { 
        /* JSON
        "picture": {
            "large": "https://randomuser.me/api/portraits/women/48.jpg",
            "medium": "https://randomuser.me/api/portraits/med/women/48.jpg",
            "thumbnail": "https://randomuser.me/api/portraits/thumb/women/48.jpg"
        }
        */
        [DataMember(Name="large")]
        public string LargeURL { get; set; }
        [DataMember(Name="medium")]
        public string MediumURL { get; set; }
        [DataMember(Name="thumbnail")]
        public string SmallURL { get; set; }

        public RandomUserPicture() 
        {
        }

        public override string ToString() 
        {
            return SmallURL;
        }

        public string ToConsoleString() 
        {
            return $@"
Small Picture:  { SmallURL }
Medium Picture: { MediumURL }
Large Picture:  { LargeURL }";
        }
    }
}
