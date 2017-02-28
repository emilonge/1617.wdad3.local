using System;

namespace Eduportal.Models
{ 
    public class Course : BaseEntity<Int64>
    {
        public string Lecturer { get; set; }
    }
}