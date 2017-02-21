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
            /*var usersList = new List<User>();
            for(var i=0;i<100;i++)
            {
                usersList.Add(BogusService.GenerateRandomUser()); 
            }

            foreach(var user in usersList)
            {
                Console.WriteLine(user.ToConsoleString());
            }*/

            var personList = new List<Person>();
            for(var i=0;i<1000;i++)
            {
                personList.Add(BogusService.GenerateRandomPerson()); 
            }

            foreach(var person in personList)
            {
                Console.WriteLine(person.ToConsoleString());
            }
        }
    }
}
