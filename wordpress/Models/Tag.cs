using System;

namespace Models
{
    public class Tag
    {
        public Int64? Id  { get; set; }
        public string Name { get; set; }

        public Tag() : base()
        {
            
        }

        public override string ToString() 
        {
            return String.Format("Tag: {0}", Name);
        }
    }
}