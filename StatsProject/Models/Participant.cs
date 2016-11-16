using System;
using System.Collections.Generic;

namespace StatsProject.Models
{
    public enum Gender
    {
        Male, Female
    }
    public class Participant
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public Gender Gender { get; set; }


        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}