using System;

namespace Models
{
    public interface IPerson
    {
        Int32? Id
        {
            get;
            set;
        }
        string FirstName
        {
            get;
            set;
        }
        string SurName
        {
            get;
            set;
        }
        string ToString();
    }
}