using System;
using Bogus.Models;
using Bogus;
using Bogus.DataSets;
using Bogus.Extensions;

namespace Bogus.Services
{
    public class BogusService
    {
        public static User GenerateRandomUser()
        {
            // Make skeleton of User via Bogus (Library)
            var userSkeleton = new Faker<User>()
                .RuleFor(u => u.Id, f => f.UniqueIndex)
                .RuleFor(u => u.UserName, (f, u) => f.Internet.UserName(f.Person.FirstName, f.Person.LastName))
                .RuleFor(u => u.Email, (f, u) => f.Internet.Email(f.Person.FirstName, f.Person.LastName))
                .RuleFor(u => u.PlainPassword, f => "Slaam_1889");

            return userSkeleton.Generate();
        }

        public static Bogus.Models.Person GenerateRandomPerson()
        {
            // Make skeleton of User via Bogus (Library)
            var personSkeleton = new Faker<Bogus.Models.Person>()
                .RuleFor(u => u.Id, f => f.UniqueIndex)
                .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                .RuleFor(u => u.SurName, f => f.Name.LastName())
                .RuleFor(u => u.Gender, f => f.PickRandom<GenderType>())
                .RuleFor(u => u.MartialStatus, f => f.PickRandom<MartialStatusType>())
                .RuleFor(u => u.DayOfBirth, f => f.Person.DateOfBirth);

            return personSkeleton.Generate();
        }
    }
}