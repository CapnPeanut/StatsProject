using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using StatsProject.Models;

namespace StatsProject.DAL
{
    public class StatsInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StatsContext>
    {
        protected override void Seed(StatsContext context)
        {




            // Seeding the database with initial information
            //adding gender, wins, and losses columns




            var Participant = new List<Participant>
            {
            new Participant{ParticipantId=0, FirstName="Jim",LastName="Bob",MembershipDate=DateTime.Parse("2005-08-03"), Gender=Gender.Female, NumberOfLosses=0, NumberOfWins=6},
            new Participant{ParticipantId=1, FirstName="Maggy",LastName="Smith",MembershipDate=DateTime.Parse("2002-05-23"), Gender=Gender.Male, NumberOfLosses=6, NumberOfWins=5},
            new Participant{ParticipantId=2, FirstName="Frank",LastName="Zulu",MembershipDate=DateTime.Parse("2003-02-24"), Gender= Gender.Male, NumberOfLosses=33, NumberOfWins=2},
            new Participant{ParticipantId=3, FirstName="Peter",LastName="Dinklage",MembershipDate=DateTime.Parse("2002-10-01"), Gender=Gender.Female, NumberOfLosses=10, NumberOfWins=6},
            new Participant{ParticipantId=4, FirstName="Yoyo",LastName="Ma",MembershipDate=DateTime.Parse("2002-09-29"), Gender=Gender.Female, NumberOfLosses=20, NumberOfWins=15},
            new Participant{ParticipantId=5, FirstName="Rob",LastName="Lowe",MembershipDate=DateTime.Parse("2001-02-11"), Gender=Gender.Female, NumberOfLosses=24, NumberOfWins=54},
            new Participant{ParticipantId=6, FirstName="Marty",LastName="McFly",MembershipDate=DateTime.Parse("2003-03-26"), Gender=Gender.Female, NumberOfLosses=13, NumberOfWins=34},
            new Participant{ParticipantId=7, FirstName="Joe",LastName="Schmoe",MembershipDate=DateTime.Parse("2005-12-07"), Gender=Gender.Female, NumberOfLosses=23, NumberOfWins=25}
            };


            // Future proofing.  Will add additional pages with speciifics for each individual once I'm comfotable with main stats page





            Participant.ForEach(s => context.Participant.Add(s));
            context.SaveChanges();
            var Activities = new List<Activity>
            {
            new Activity{ActivityID=0,Title="Basketball",Points=3,},
            new Activity{ActivityID=1,Title="Football",Points=3,},
            new Activity{ActivityID=2,Title="Pong",Points=3,},
            new Activity{ActivityID=3,Title="Darts",Points=4,},
            new Activity{ActivityID=4,Title="Pool",Points=4,},
            new Activity{ActivityID=5,Title="Soccer",Points=3,},
            new Activity{ActivityID=6,Title="Golf",Points=4,}
            };
            Activities.ForEach(s => context.Activities.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{ParticipantID=0,ActivityID=1050,},
            new Enrollment{ParticipantID=1,ActivityID=4022,},
            new Enrollment{ParticipantID=2,ActivityID=4041,},
            new Enrollment{ParticipantID=3,ActivityID=1045,},
            new Enrollment{ParticipantID=4,ActivityID=3141,



            },
            new Enrollment{ParticipantID=0,ActivityID=2021,},
            new Enrollment{ParticipantID=1,ActivityID=1050},
            new Enrollment{ParticipantID=2,ActivityID=1050,},
            new Enrollment{ParticipantID=3,ActivityID=4022},
            new Enrollment{ParticipantID=4,ActivityID=4041,},
            new Enrollment{ParticipantID=5,ActivityID=1045},
            new Enrollment{ParticipantID=6,ActivityID=3141,},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}