using LeagueAppManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeagueAppManagement.Services
{
    public class TeamCreator
    {
        public IEnumerable<Team> CreateTeams(IEnumerable<Player> players, IEnumerable<Team> teams)
        {
            var aPlayers = players.Where(w => w.Grade == GradeEnum.A).ToList();
            var bPlayers = players.Where(w => w.Grade == GradeEnum.B).ToList();
            var cPlayers = players.Where(w => w.Grade == GradeEnum.C).ToList();

            var allPlayers = new List<List<Player>> {
                aPlayers,
                bPlayers,
                cPlayers
            };

            var teamA = teams.First();
            var teamB = teams.Last();

            foreach (var playerList in allPlayers)
            {
                var mix = true;
                var isPair = IsPair(playerList.Count());

                while (mix)
                {

                    if (isPair || playerList.Count > 1)
                    {
                        AddToTeam(teamA, playerList);
                        AddToTeam(teamB, playerList);
                    }
                    else
                    {
                        if (playerList.Count == 1)
                        {
                            if (teamA.Players.Count < teamB.Players.Count)
                            {
                                AddToTeam(teamA, playerList);
                            }
                            else
                            {
                                AddToTeam(teamB, playerList);
                            }
                        }
                    }

                    if (playerList.Count == 0)
                    {
                        mix = false;
                    }
                }
            }

            return teams;
        }

        public void AddToTeam(Team team, List<Player> players)
        {
            var rand = new Random();
            var newPlayer = players[rand.Next(players.Count)];
            team.Players.Add(newPlayer);
            players.Remove(newPlayer);
        }

        public bool IsPair(int number)
        {
            return (double)number / 2 == 1;
        }
    }
}