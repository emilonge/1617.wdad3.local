using System;

namespace Eduportal.Models
{
    public interface IPerson
    {
        Int32 Id  { get; set; }
        string FirstName { get; set; }
        string SurName { get; set; }
        Nullable<GenderType> Gender  { get; set; }
        Nullable<MartialStatusType> MartialStatus { get; set; }
        Nullable<DateTime> DayOfBirth  { get; set; }
        DateTime CreatedAt  { get; set; }
        Nullable<DateTime> UpdatedAt  { get; set; }
        Nullable<DateTime> DeletedAt  { get; set; }
    }
}