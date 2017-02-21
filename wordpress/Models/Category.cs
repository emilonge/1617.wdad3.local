using System;

namespace Models
{
    public class Category
    {
        public Int32? Id  { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Story { get; set; }

        public Nullable<Int32> ParentCategoryId { get; set; }
        public Category ParentCategory { get; set; }

        public Category() : base()
        {
            
        }

        public override string ToString() 
        {
            return String.Format("Category: {0}", Name);
        }
    }
}