using System;

namespace Eduportal.Models
{
    public class Post : BaseEntity<Int16>
    {
        public string Title
        {
            get { return Name; }
        }
        public string Body { get; set; }
        public string ThumbnailURL { get; set; }
    }
}