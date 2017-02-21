using System;
using System.Collections.Generic;

namespace Models
{
    public class Blog
    {
        public Int16? Id  { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Slugify { get; set; }

        public ICollection<Post> Posts { get; set; }

        public Blog() : base()
        {
            Posts = new List<Post>();
        }

        public override string ToString() 
        {
            return String.Format("Blog: {0}", Title);
        }
    }
}