using System;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class RandomUser
    { 
        [DataMember(Name="gender")]
        public string Gender { get; set; }
        [DataMember(Name="email")]
        public string Email { get; set; }
        [DataMember(Name="dob")]
        public string DayOfBirth { get; set; }
        [DataMember(Name="nat")]
        public string Nationality { get; set; }
        [DataMember(Name="registered")]
        public string RegisteredAt { get; set; }
        [DataMember(Name="phone")]
        public string TEL { get; set; }
        [DataMember(Name="cell")]
        public string GSM { get; set; }
        [DataMember(Name="name")]
        public RandomUserName Name { get; set; }
        [DataMember(Name="location")]
        public RandomUserLocation Location { get; set; }
        [DataMember(Name="login")]
        public RandomUserLogin Login { get; set; }
        [DataMember(Name="picture")]
        public RandomUserPicture Picture { get; set; }

        public RandomUser() 
        {
        }

        public override string ToString() 
        {
            return Name.ToString();
        }

        public string ToConsoleString() 
        {
            var tempStr = "";
            tempStr += "Name:\t\t" + Name.ToString();
            tempStr += "\r\nGender:\t\t" + Gender;
            tempStr += "\r\nDay of birth:\t" + DayOfBirth;
            tempStr += "\r\nNationality:\t" + Nationality;
            tempStr += "\r\nTel:\t\t" + TEL;
            tempStr += "\r\nGSM:\t\t" + GSM;
            tempStr += "\r\nAddress:\t" + Location.ToString();
            tempStr += "\r\n" + Picture.ToConsoleString();
            tempStr += "\r\n" + Login.ToConsoleString();

            return tempStr;
        }
    }
}
