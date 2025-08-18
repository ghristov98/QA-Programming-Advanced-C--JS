namespace _03.TeamworkProjects
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("-");
                string creator = input[0];
                string teamName = input[1];

                if (teams.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(t => t.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team currentTeam = new Team(teamName, creator);

                    teams.Add(currentTeam);

                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            string joinInformation = Console.ReadLine();

            while (joinInformation != "end of assignment")
            {
                string[] data = joinInformation.Split("->");
                string member = data[0];
                string teamName = data[1];

                if (!teams.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Any(t => t.Members.Contains(member)
                                    || t.Creator == member))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                }
                else
                {
                    Team teamToAdd = teams.FirstOrDefault(t => t.TeamName == teamName);

                    teamToAdd.Members.Add(member);
                }

                joinInformation = Console.ReadLine();
            }

            List<Team> validTeams = teams.Where(t => t.Members.Count > 0)
                                         .OrderByDescending(t => t.Members.Count)
                                         .ThenBy(t => t.TeamName)
                                         .ToList();

            foreach (Team team in validTeams)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.Creator}");

                foreach (string member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            List<Team> teamsToDisband = teams.Where(t => t.Members.Count == 0)
                                             .OrderBy(t => t.TeamName)
                                             .ToList();

            Console.WriteLine("Teams to disband:");

            foreach (Team team in teamsToDisband)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }
}