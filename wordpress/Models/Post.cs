using System;
using System.Collections.Generic;

namespace Models
{
    public class Post
    {
        public Int32? Id  { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public string Story { get; set; }

        public Nullable<Int32> CategoryId { get; set; }
        public Category Category { get; set; }
        
        public ICollection<Tag> Tags { get; set; }

        public Post() : base()
        {
            
        }

        public override string ToString() 
        {
            return String.Format("Post: {0}", Title);
        }
    }
}