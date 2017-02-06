using System;

namespace Models
{
    public class Student : Person
    {
        private string _number;

        public Student(string firstName, string surName, string number) : base(firstName, surName) {
            this._number = number;
        }

        public override string ToString() {
            return String.Format("Student: {0} {1}", this._firstName, this._surName);
        }
    }
}