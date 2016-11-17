using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatsProject.Models
{

    // Setting up a gender selector field with an enum

    public enum Gender
    {
        Male, Female
    }


    // Initializing getters and setters for the currrent database on the participant page

    public class Participant
    {
        public int ParticipantId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        // Setting the date to a specific format
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode =true)]
        public DateTime MembershipDate { get; set; }
        public Gender Gender { get; set; }
        //consideration for an outcome varaible to be used for some stat keeping 
        //public Outcome? Outcome { get; set; }
        public int NumberOfWins { get; set; }
        public int NumberOfLosses { get; set; }


        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}