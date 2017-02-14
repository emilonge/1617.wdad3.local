using System;

namespace Models
{
    public enum GenderType : byte {
        Unknown = 0,
        Male = 1,
        Female = 2,
        NotApplicable = 9
    }

    public enum MartialStatusType : byte {
        Unknown = 1,
        Single = 2,
        LivingTogether = 3,
        Engaged = 4,
        Married = 5,
        Seperated = 6,
        Divorced = 7,
        Widow = 8
    }

    public class Person : IPerson
    {
        public Int32 Id
        {
            get;
            set;
        }
        public string FirstName
        {
            get;
            set;
        }
        public string SurName
        {
            get;
            set;
        }

        public GenderType Gender 
        { 
            get; 
            set; 
        }

        public MartialStatusType MartialStatus 
        { 
            get; 
            set; 
        }   

        public Person() : base()
        {
            
        }

        public Person(string firstName, string surName) : this()
        {
            FirstName = firstName;
            SurName = surName;
        }

        public Person(Int32 id, string firstName, string surName) : this(firstName, surName)
        {
            Id = id;
        }

        public override string ToString()
        {
            return String.Format("Person:\t {0} {1}", FirstName, SurName);
        }
    }
}