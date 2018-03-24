using LeagueAppManagement.Data;
using System.Collections.Generic;

namespace LeagueAppManagementTest.Services
{
    public static class DataHelper
    {
        public static List<Player> Players()
        {
            return new List<Player>
            {
                new Player
                {
                    FirstName = "Emmanuel",
                    LastName = "Genest",
                    Grade = GradeEnum.C
                },
                new Player
                {
                     FirstName = "Maxime",
                    LastName = "Frechette",
                    Grade = GradeEnum.A
                },
                new Player
                {
                    FirstName = "Felix",
                    LastName = "Prince",
                    Grade = GradeEnum.B
                },
                new Player
                {
                    FirstName = "Gille Eric",
                    LastName = "Prince",
                    Grade = GradeEnum.D
                },
                new Player
                {
                    FirstName = "Charles",
                    LastName = "Dumond",
                    Grade = GradeEnum.B
                },
                new Player
                {
                     FirstName = "Alex",
                    LastName = "Roumain",
                    Grade = GradeEnum.C
                },
                 new Player
                {
                    FirstName = "Alex",
                    LastName = "Casque Jaune",
                    Grade = GradeEnum.A
                },
                 new Player
                 {
                    FirstName = "Jacques",
                    LastName = "B.Rouillard",
                    Grade = GradeEnum.B
                 },
                 new Player
                 {
                    FirstName = "Vincent",
                    LastName = "Picard",
                    Grade = GradeEnum.D
                 },
                 new Player
                 {
                    FirstName = "Carl",
                    LastName = "Filion",
                    Grade = GradeEnum.B
                 },
                 new Player
                 {
                    FirstName = "Eric",
                    LastName = "Beauregard",
                    Grade = GradeEnum.B
                 },
                new Player
                 {
                    FirstName = "Richard",
                    LastName = "Perrot",
                    Grade = GradeEnum.C
                 },
                new Player
                 {
                    FirstName = "Dominique",
                    LastName = "Body",
                    Grade = GradeEnum.A
                 },
                 new Player
                 {
                    FirstName = "David",
                    LastName = "Goalie",
                    Grade = GradeEnum.C
                 },
                new Player
                 {
                    FirstName = "Sebastien",
                    LastName = "Ottawa",
                    Grade = GradeEnum.B
                 },
                new Player
                 {
                    FirstName = "Pierre Luc",
                    LastName = "Hori",
                    Grade = GradeEnum.A
                 }//,
                //new Player
                //{
                //    FirstName = "Phillipe",
                //    LastName = "Gagnon",
                //    Grade = GradeEnum.A
                //}
                // new Player
                 //{
                 //   FirstName = "Ami",
                 //   LastName = "Gagnon",
                 //   Grade = GradeEnum.B
                 //},
            };
        }
    }
}
