namespace StatsProject.Models
{
    public enum Outcome
    {
        Win, Loss, Tie
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int ActivityID { get; set; }
        public int ParticipantID { get; set; }
        public Outcome? Outcome { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual Participant Participant { get; set; }
    }
}