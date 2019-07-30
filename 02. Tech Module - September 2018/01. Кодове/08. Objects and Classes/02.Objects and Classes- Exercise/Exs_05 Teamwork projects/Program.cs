using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_05_Teamwork_projects
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < n; i++)
            {
                string registering = Console.ReadLine();
                string[] info = registering.Split('-');
                string user = info[0];
                string teamName = info[1];
                bool isWorked = true;
                foreach (var team in teams)
                {
                    if(team.Name == teamName)
                    {
                        Console.WriteLine($"Team {teamName} was already created!");
                        isWorked = false;
                        break;
                    }
                    if (team.User == user)
                    {
                        Console.WriteLine($"{user} cannot create another team!");
                        isWorked = false;
                        break;
                    }
                }
                if (isWorked)
                {
                    teams.Add(new Team(teamName, user));
                    Console.WriteLine($"Team {teamName} has been created by {user}!");
                }
            }
            while (true)
            {
                string joining = Console.ReadLine();
                if(joining== "end of assignment")
                {
                    break;
                }
                string[] info = joining.Split('-');
                string joiner = info[0];
                string teamName = info[1].Remove(0, 1);
                bool isNonExistingTeam = true;
                bool isntReccurringJoiner = true;
                foreach (var team in teams)
                {
                    if (joiner == team.User || team.Users.Contains(joiner))
                    {
                        isntReccurringJoiner = false;
                        Console.WriteLine($"Member {joiner} cannot join team {teamName}!");
                    }
                    if (teamName == team.Name)
                    {
                        isNonExistingTeam = false;
                    }

                }
                if (isNonExistingTeam)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                if (!isNonExistingTeam && isntReccurringJoiner)
                {
                    foreach (var team in teams)
                    {
                        if (team.Name == teamName)
                        {
                            team.Users.Add(joiner);
                        }
                    }
                }
            }
            List<string> disbands = teams.Where(x => x.Users.Count() == 0).Select(x=>x.Name).OrderBy(x=>x).ToList();
            teams = teams.Where(x => x.Users.Count() > 0).ToList();
            teams = teams.OrderByDescending(x => x.Users.Count()).ThenBy(x => x.Name).ToList();
            foreach (var team in teams)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.User}");
                team.Users = team.Users.OrderBy(x => x).ToList();
                foreach (var joiner in team.Users)
                {
                    Console.WriteLine($"-- {joiner}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var dis in disbands)
            {
                Console.WriteLine(dis);
            }

        }
    }

    class Team
    {
        public string Name { get; set; }

        public string User { get; set; }

        public List<string> Users { get; set; }
        
        public Team(string name, string user)
        {
            this.Name = name;
            this.User = user;
            this.Users = new List<string>();
        }
    }
}
