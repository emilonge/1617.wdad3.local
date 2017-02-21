using System;

namespace Bogus.Models
{
    /// <summary>
    /// A User is a Robot or a Human who can sign in the application.! If a User is a Robot then the PersonId is NULL. If a User is a Person, the PersonId will be the id of the person. A Person ios not always a User.
    /// </summary>
    public class User
    {
        public Int32? Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PlainPassword { get; set; }

        // A User can be a Person
        public Nullable<Int32> PersonId { get; set; }
        public Person Person { get; set; }

        public virtual string ToConsoleString()
        {
            return $@"
Id:             { Id }
Username:       { UserName }
Email:          { Email }
Plain password: { PlainPassword }
{ ((Person != null)?Person.ToConsoleString():"") }
            ";
        }

        public override string ToString() 
        {
            return UserName;
        }
    }
}