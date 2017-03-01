using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Bogus;
using Bogus.DataSets;
using Bogus.Extensions;
using Eduportal.Models;

namespace Eduportal.Db
{
    public class ApplicationDbContextSeeder 
    {
        public static void Initialize()
        {
            ApplicationDbContextSeeder.Seeding(new ApplicationDbContextFactory().Create()).Wait();
        }

        public static void Initialize(IServiceProvider serviceProvider)
        {
            ApplicationDbContextSeeder.Seeding(serviceProvider.GetService<ApplicationDbContext>()).Wait();
        }

        private static async Task Seeding(ApplicationDbContext context)
        {
            using(context) 
            {
                var random = new Random();

                // Create Random Posts
                if(!context.Posts.Any())
                {
                    var lorem = new Bogus.DataSets.Lorem(locale: "nl");
                    var postSkeleton = new Faker<Post>()
                        .RuleFor(p => p.Title, f => lorem.Sentence())
                        .RuleFor(p => p.Description, f => String.Join(" ", lorem.Words(5)))
                        .RuleFor(p => p.Body, f => lorem.Paragraphs(random.Next(5, 15)))
                        .RuleFor(p => p.CreatedAt, f => DateTime.Now)
                        .FinishWith((f, u) =>
                        {
                            Console.WriteLine("Post created with Bogus: {0}!", u.Title);
                        });

                    var posts = new List<Post>();

                    for(var i = 0; i < 25;i++)
                    {
                        var post = postSkeleton.Generate();
                        posts.Add(post);
                    }

                    context.Posts.AddRange(posts);
                    await context.SaveChangesAsync();
                }

                // Create Random Persons
                if(!context.Persons.Any())
                {
                    var personSkeleton = new Faker<Eduportal.Models.Person>()
                        .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                        .RuleFor(u => u.SurName, f => f.Name.LastName())
                        .RuleFor(u => u.Gender, f => f.PickRandom<GenderType>())
                        .RuleFor(u => u.MartialStatus, f => f.PickRandom<MartialStatusType>())
                        .RuleFor(u => u.DayOfBirth, f => f.Person.DateOfBirth)
                        .FinishWith((f, u) =>
                        {
                            Console.WriteLine("Person created with Bogus: {0} {1}!", u.FirstName, u.SurName);
                        });

                    var persons = new List<Eduportal.Models.Person>();

                    for(var i = 0; i < 250;i++)
                    {
                        var person = personSkeleton.Generate();
                        persons.Add(person);
                    }

                    context.Persons.AddRange(persons);
                    await context.SaveChangesAsync();
                }
            }
        }
        
        private static DateTime GenerateDateTime(int yFrom, int yTo, int mFrom, int mTo, int dFrom, int dTo) 
        {
            var random = new Random();
            try
            {
                return new DateTime(random.Next(yFrom, yTo), random.Next(mFrom, mTo), random.Next(dFrom, dTo));
            }
            catch(Exception ex) 
            {
                return GenerateDateTime(yFrom, yTo, mFrom, mTo, dFrom, dTo);
            }
        }

        private static string GenerateAlwaysTheSamePassword()
        {
            return "Rode_Biet_2016";
        }

        private static string GeneratePassword(int length, bool upper, bool lower, bool digits, bool signs)
        {
            var source = new List<char>();
            var random = new Random();
            var result = "";
            var i = 0;
        
            if(upper)
                source.AddRange("ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToList());
        
            if(lower)
                source.AddRange("abcdefghijklmnopqrstuvwxyz".ToList());
        
            if(digits)
                source.AddRange("1234567890".ToList());
        
            if(signs)
                source.AddRange("'&#()§!$%{}\\/.;,?:+=~[]".ToList());
        
            while(i++ < length)
                result += source[random.Next(0, source.Count)];
        
            return result;
        }
        
        public static string GeneratePassword(int length)
        {
            return GeneratePassword(length, true, true, true, true);
        }
    }
}