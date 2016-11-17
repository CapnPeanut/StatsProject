using StatsProject.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace StatsProject.DAL
{
    public class StatsContext : DbContext
    {
        // Simply initializing getters and setters for the database
        public StatsContext() : base("StatsContext")
        {
        }

        public DbSet<Participant> Participant { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Activity> Activities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}