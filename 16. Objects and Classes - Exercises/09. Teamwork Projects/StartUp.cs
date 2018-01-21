namespace _09.Teamwork_Projects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var countOfTeams = int.Parse(Console.ReadLine());
            var teams = new List<Team>();

            for (int i = 0; i < countOfTeams; i++)
            {
                var newTeam = Console.ReadLine()
                    .Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                var membersList = new List<string>();

                var team = new Team
                {
                    Name = newTeam[1],
                    CreatorName = newTeam[0],
                    Members = membersList
                };

                if (!teams.Select(x => x.Name).Contains(team.Name))
                {
                    if (!teams.Select(x => x.CreatorName).Contains(team.CreatorName))
                    {
                        teams.Add(team);
                        Console.WriteLine($"Team {newTeam[1]} has been created by {newTeam[0]}!");
                    }
                    else
                    {
                        Console.WriteLine($"{team.CreatorName} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {team.Name} was already created!");
                }
            }

            var teamRegistration = Console.ReadLine();

            while (!teamRegistration.Equals("end of assignment"))
            {
                var tokens = teamRegistration
                    .Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                var newUser = tokens[0];
                var teamName = tokens[1];

                if (!teams.Select(x => x.Name).Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Select(x => x.Members).Any(x => x.Contains(newUser)) ||
                    teams.Select(x => x.CreatorName).Contains(newUser))
                {
                    Console.WriteLine($"Member {newUser} cannot join team {teamName}!");
                }
                else
                {
                    int teamToJoinIndex = teams.FindIndex(x => x.Name == teamName);
                    teams[teamToJoinIndex].Members.Add(newUser);
                }

                teamRegistration = Console.ReadLine();
            }

            var teamsToDisband = teams
                .OrderBy(x => x.Name)
                .Where(x => x.Members.Count == 0);

            var fullTeams = teams
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.Name)
                .Where(x => x.Members.Count > 0);

            foreach (var team in fullTeams)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.CreatorName}");

                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var item in teamsToDisband)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}