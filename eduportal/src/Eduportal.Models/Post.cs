using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eduportal.Models
{
    public class Post : BaseEntity<Int16>
    {
        [NotMapped]
        public string Title
        {
            get { return Name; }
            set { Name = value; }
        }
        public string Body { get; set; }
        public string ThumbnailURL { get; set; }
    }
}