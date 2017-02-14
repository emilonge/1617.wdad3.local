using System;

namespace Models
{
    public class Student : Person
    {
        public string StudentNr
        {
            get;
            set;
        }

        public Student() : base()
        {
            
        }

        public Student(string firstName, string surName, string studentNr) : base(firstName, surName)
        { 
            StudentNr = studentNr;
        }

        public Student(Int32 id, string firstName, string surName, string studentNr) : base(id, firstName, surName)
        {
            StudentNr = studentNr;
        }

        public override string ToString() 
        {
            return String.Format("Student: {0} {1} - nr: {2}", FirstName, SurName, StudentNr);
        }
    }
}