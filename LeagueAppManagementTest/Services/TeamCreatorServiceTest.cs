using LeagueAppManagement.Data;
using LeagueAppManagement.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LeagueAppManagementTest.Services
{
    [TestClass]
    public class TeamCreatorServiceTest
    {
        private TeamCreator _service;
        [TestInitialize]
        public void TestInitialize()
        {
            _service = new TeamCreator();
        }

        [TestMethod]
        public void TestIsPair_withPairNumber()
        {
            var result = _service.IsPair(2);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestIsPair_WithImpairNumver()
        {
            var result = _service.IsPair(3);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_AddPlayerToATeam_With_2_Players()
        {
            var teamA = new Team
            {
                Players = new List<Player>
            {
                new Player
                {
                    FirstName = "Emman"
                },
                new Player
                {
                    FirstName = "Jacques"
                }
            }
            };

            var teamB = new Team
            {
                Players = new List<Player>
            {
                new Player
                {
                    FirstName = "Eric"
                },
                new Player
                {
                    FirstName = "Richard"
                }
            }
            };

            var playersToAdd = new List<Player> { new Player { FirstName = "Paris" }, new Player { FirstName = "Roger" } };

            _service.AddToTeam(teamA, playersToAdd);

            Assert.AreEqual(3, teamA.Players.Count);
            Assert.AreEqual(1, playersToAdd.Count);
        }


        [TestMethod]
        public void Test_Create_TwoTeams()
        {
            var teams = new List<Team>
            {
                new Team
                {
                      Name = "Orange"
                },
                new Team
                {
                    Name = "Blanc"
                }
            };


            var result = _service.CreateTeams(DataHelper.Players(), teams);

            Assert.AreEqual(result.First().Players.Count, result.Last().Players.Count);

        }
    }
}
