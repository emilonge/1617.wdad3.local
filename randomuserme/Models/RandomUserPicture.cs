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
            var tempStr = "Small Picture:\t{0}\r\nMedium Picture:\t{1}\r\nLarge Picture:\t{2}";

            return String.Format(tempStr,SmallURL,MediumURL,LargeURL);
        }
    }
}
