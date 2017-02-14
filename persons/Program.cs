using System;
using System.Collections.Generic;
using Models;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<IPerson> persons = new List<IPerson>
            {
                new Person(1, "Olivier", "Parent"),
                new Student(2, "Philippe", "De Pauw - Waterschoot", "66-6666-666-90210"),
                new Lecturer(3, "Daniel", "Termont", 29230.65)
            };

            foreach(var person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
