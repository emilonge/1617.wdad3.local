using System;

namespace Models
{
    public class Employee : Person
    {
        private string _number;

        public Employee(string firstName, string surName, string number) : base(firstName, surName) {
          this._number = number;
        }

        public override string ToString() {
            return String.Format("Employee: {0} {1}", this._firstName, this._surName);
        }
    }
}