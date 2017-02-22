using System;
using System.Collections.Generic;
using Bogus.Services;
using Bogus.Models;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var r = new Random();

            // Create Persons
            var personList = new List<Person>();
            for(var i=0;i<300;i++)
            {
                personList.Add(BogusService.GenerateRandomPerson()); 
            }

            foreach(var person in personList)
            {
                Console.WriteLine(person.ToConsoleString());
            }

            // Create Users (accounts)
            List<User> usersList = new List<User>();
            for(var i=0;i<100;i++)
            {
                usersList.Add(BogusService.GenerateRandomUser()); 
            }

            foreach(var user in usersList)
            {
                if(r.Next(0, 2) == 0)
                {
                    user.Person = personList[r.Next(299)];
                    user.PersonId = user.Person.Id;
                }
                Console.WriteLine("##########################################################################");
                Console.WriteLine(user.ToConsoleString());
            }

            // Count the amount of robots (no person)
            var amountOfRobots = usersList.FindAll(u => u.PersonId != null).Count;
            Console.WriteLine("##########################################################################");
            Console.WriteLine($@"
Amount of Robots:   { amountOfRobots }
Amount of humans:   { ( usersList.Count - amountOfRobots )}
            ");
        }
    }
}
