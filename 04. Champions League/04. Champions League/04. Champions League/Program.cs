using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Champions_League
{
    class Program
    {
        public static Dictionary<string, Team> AllTeams = new Dictionary<string, Team>();
        public static void Main()
        {
            //Dictionary<string, Team> AllTeams = new Dictionary<string, Team>();

            while (true)
            {
                var line = Console.ReadLine().Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                if (line[0] == "stop")
                {
                    break;
                }

                string firstTeamName = line[0].Trim();
                string secondTeamName = line[1].Trim();

                if (!AllTeams.ContainsKey(firstTeamName))
                {
                    Team newTeam = new Team(firstTeamName);
                    AllTeams.Add(firstTeamName, newTeam);
                }
                if (!AllTeams.ContainsKey(secondTeamName))
                {
                    Team newTeam = new Team(secondTeamName);
                    AllTeams.Add(secondTeamName, newTeam);
                }

                AllTeams[firstTeamName].Opponents.Add(secondTeamName);
                AllTeams[secondTeamName].Opponents.Add(firstTeamName);

                var homeResult = Array.ConvertAll(line[2].Split(new[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
                var awayResult = Array.ConvertAll(line[3].Split(new[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
                var firstTeamScore = homeResult[0] + awayResult[1];
                var secondTeamScore = homeResult[1] + awayResult[0];

                if (firstTeamScore > secondTeamScore)
                {
                    AllTeams[firstTeamName].Wins++;
                }
                else if (firstTeamScore < secondTeamScore)
                {
                    AllTeams[secondTeamName].Wins++;
                }
                else
                {
                    if (awayResult[1] > homeResult[1])
                    {
                        AllTeams[firstTeamName].Wins++;
                    }
                    else
                    {
                        AllTeams[secondTeamName].Wins++;
                    }
                }
            }

            var st = AllTeams.OrderByDescending(team => team.Value.Wins).ThenBy(team => team.Value.TeamName);


            foreach (var team in st)
            {
                Console.WriteLine(team.Value.TeamName);
                Console.WriteLine("- Wins: {0}", team.Value.Wins);
                Console.WriteLine("- Opponents: {0}", string.Join(", ", team.Value.Opponents));
            }
            var sts = 0;
        }

        public class Team
        {
            public Team(string name)
            {
                this.TeamName = name;
                this.Wins = 0;
                this.Opponents = new SortedSet<string>();
            }

            public string TeamName { get; set; }

            public int Wins { get; set; }

            public SortedSet<string> Opponents { get; set; }
        }
    }
}
