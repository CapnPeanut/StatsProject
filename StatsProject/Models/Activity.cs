using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatsProject.Models
{
    public class Activity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ActivityID { get; set; }
        public string Title { get; set; }
        public int Points { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}