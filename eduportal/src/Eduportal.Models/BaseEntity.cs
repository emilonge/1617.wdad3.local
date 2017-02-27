using System;

namespace Eduportal.Models
{
    public abstract class BaseEntity<T> : IBaseEntity<T>
    {
        public T Id  { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt  { get; set; }
        public Nullable<DateTime> UpdatedAt  { get; set; }
        public Nullable<DateTime> DeletedAt  { get; set; }
    }
}