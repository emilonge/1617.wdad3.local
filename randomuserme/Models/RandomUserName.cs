using System;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class RandomUserName
    { 
        [DataMember(Name="title")]
        public string Title { get; set; }
        [DataMember(Name="first")]
        public string FirstName { get; set; }
        [DataMember(Name="last")]
        public string SurName { get; set; }

        public RandomUserName() 
        {
        }

        public override string ToString() 
        {
            var tempStr = "{0} {1} {2}";
            return String.Format(tempStr,Title,FirstName,SurName);
        }
    }
}
