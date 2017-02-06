using System;
using System.Runtime.Serialization;

namespace Models
{
    /* JSON
    "login": {
        "username": "ticklishcat986",
        "password": "goats",
        "salt": "jrU6aVrD",
        "md5": "2917b10b72a6679b542b1fe66d721ff3",
        "sha1": "bcef58176259ff22d593452cca53df6afdd5fdbf",
        "sha256": "19d2272258614147a19275fa2c85ec297bc9ff7d98b95acd3a74c5273fef0000"
    }
    */
    [DataContract]
    public class RandomUserLogin
    { 
        [DataMember(Name="username")]
        public string Username { get; set; }
        [DataMember(Name="password")]
        public string Password { get; set; }
        [DataMember(Name="salt")]
        public string Salt { get; set; }
        [DataMember(Name="sha256")]
        public string SHA256 { get; set; }

        public RandomUserLogin() 
        {
        }

        public override string ToString() 
        {
            return Username;
        }

        public string ToConsoleString() 
        {
            var tempStr = "Username:\t{0}\r\nPassword:\t{1}\r\nSalt:\t\t{2}\r\nSha256:\t\t{3}";

            return String.Format(tempStr,Username,Password,Salt,SHA256);
        }
    }
}
