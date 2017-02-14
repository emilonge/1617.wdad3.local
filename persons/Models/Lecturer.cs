using System;

namespace Models
{
    public class Lecturer : Person
    {
        public double Salary
        {
            get;
            set;
        }

        public Lecturer() : base()
        {
            
        }

        public Lecturer(string firstName, string surName, double salary) : base(firstName, surName)
        { 
            Salary = salary;
        }

        public Lecturer(Int32 id, string firstName, string surName, double salary) : base(id, firstName, surName)
        {
            Salary = salary;
        }

        public override string ToString() 
        {
            return String.Format("Lecturer: {0} {1} - salary: {2} EURO", FirstName, SurName, Salary);
        }
    }
}