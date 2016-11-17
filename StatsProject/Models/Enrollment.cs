namespace StatsProject.Models
{


    public class Enrollment
    {


        //getters and setters for Enrollment class to be used at a later time


        public int EnrollmentID { get; set; }
        public int ActivityID { get; set; }
        public int ParticipantID { get; set; }


        public virtual Activity Activity { get; set; }
        public virtual Participant Participant { get; set; }
    }
}