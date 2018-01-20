using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Teamwork_Projects
{
    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            ReadTeams(n, teams);
            AddMembers(teams);

            var ordered = teams.OrderByDescending(y => y.Members.Count).ThenBy(x => x.Name).ToList();
            foreach (var t in ordered)
            {
                if (t.Members.Count == 0)
                {
                    continue;
                }
                Console.WriteLine(t.Name);
                Console.WriteLine("- " + t.Creator);
                var orderedMembers = t.Members.OrderBy(x => x).ToList();
                foreach (var m in orderedMembers)
                {
                    Console.WriteLine("-- " + m);
                }
            }

            var disbandTeams = teams.Where(x => x.Members.Count == 0).OrderBy(x => x.Name).ToList();
            Console.WriteLine("Teams to disband:");

            if (disbandTeams.Count != 0)
            {
                foreach (var t in disbandTeams)
                {
                    Console.WriteLine(t.Name);
                }
            }
            

        }

        private static void AddMembers(List<Team> teams)
        {
            var text = Console.ReadLine();

            while (text != "end of assignment")
            {
                var input = text.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string member = input[0];
                string team = input[1];

                if (!teams.Any(x => x.Name == team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else // team exists 
                {
                    if (teams.Any(x => x.Members.Contains(member)) ||
                    teams.Any(x => x.Creator == member))
                    {
                    Console.WriteLine($"Member {member} cannot join team {team}!");
                    }
                    else
                    {
                        int index = teams.FindIndex(x => x.Name == team);
                        teams[index].Members.Add(member);
                    }
                }
                

                text = Console.ReadLine();

            }

        }

        static void ReadTeams(int n, List<Team> teams)
        {
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-');
                string creator = input[0];
                string name = input[1];

                if (teams.Any(x => x.Name == name))
                {
                    Console.WriteLine($"Team {name} was already created!");
                }
                else if (teams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    var team = new Team()
                    {
                        Name = name,
                        Creator = creator,
                        Members = new List<string>(),
                    };
                    teams.Add(team);
                    Console.WriteLine($"Team {name} has been created by {creator}!");
                }

            }
        }
    }
}
