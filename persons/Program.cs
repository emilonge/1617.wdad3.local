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
                new Employee("Philippe", "De Pauw", "666-66-666"),
                new Student("Sir", "I Can Do Everything", "123456")  
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
