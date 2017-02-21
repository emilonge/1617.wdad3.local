using System;

namespace Bogus.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PlainPassword { get; set; }

        public virtual string ToConsoleString()
        {
            return $@"
Firstname:      { FirstName }
Surname:        { SurName }
Username:       { UserName }
Email:          { Email }
Plain password: { PlainPassword }
            ";
        }

        public override string ToString() 
        {
            return FirstName + " " + SurName;
        }
    }
}