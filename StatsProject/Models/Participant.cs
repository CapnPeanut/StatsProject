using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatsProject.Models
{
    public enum Gender
    {
        Male, Female
    }


    public class Participant
    {
        public int ParticipantId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode =true)]
        public DateTime MembershipDate { get; set; }
        public Gender Gender { get; set; }
//      public Outcome? Outcome { get; set; }
        public int NumberOfWins { get; set; }
        public int NumberOfLosses { get; set; }


        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}