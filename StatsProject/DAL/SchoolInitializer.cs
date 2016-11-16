using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using StatsProject.Models;

namespace StatsProject.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var Participant = new List<Participant>
            {
            new Participant{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01"), Gender=Gender.Female},
            new Participant{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01"), Gender=Gender.Male},
            new Participant{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01"), Gender= Gender.Male},
            new Participant{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01"), Gender=Gender.Female},
            new Participant{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01"), Gender=Gender.Female},
            new Participant{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01"), Gender=Gender.Female},
            new Participant{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01"), Gender=Gender.Female},
            new Participant{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01"), Gender=Gender.Female}
            };

            Participant.ForEach(s => context.Participant.Add(s));
            context.SaveChanges();
            var Activitys = new List<Activity>
            {
            new Activity{ActivityID=1050,Title="Chemistry",Points=3,},
            new Activity{ActivityID=4022,Title="Microeconomics",Points=3,},
            new Activity{ActivityID=4041,Title="Macroeconomics",Points=3,},
            new Activity{ActivityID=1045,Title="Calculus",Points=4,},
            new Activity{ActivityID=3141,Title="Trigonometry",Points=4,},
            new Activity{ActivityID=2021,Title="Composition",Points=3,},
            new Activity{ActivityID=2042,Title="Literature",Points=4,}
            };
            Activitys.ForEach(s => context.Activitys.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{ParticipantID=1,ActivityID=1050,Outcome=Outcome.Win},
            new Enrollment{ParticipantID=1,ActivityID=4022,Outcome=Outcome.Loss},
            new Enrollment{ParticipantID=1,ActivityID=4041,Outcome=Outcome.Win},
            new Enrollment{ParticipantID=2,ActivityID=1045,Outcome=Outcome.Tie},
            new Enrollment{ParticipantID=2,ActivityID=3141,Outcome=Outcome.Win



            },
            new Enrollment{ParticipantID=2,ActivityID=2021,Outcome=Outcome.Win},
            new Enrollment{ParticipantID=3,ActivityID=1050},
            new Enrollment{ParticipantID=4,ActivityID=1050,},
            new Enrollment{ParticipantID=4,ActivityID=4022,Outcome=Outcome.Loss},
            new Enrollment{ParticipantID=5,ActivityID=4041,Outcome=Outcome.Loss},
            new Enrollment{ParticipantID=6,ActivityID=1045},
            new Enrollment{ParticipantID=7,ActivityID=3141,Outcome=Outcome.Tie},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}