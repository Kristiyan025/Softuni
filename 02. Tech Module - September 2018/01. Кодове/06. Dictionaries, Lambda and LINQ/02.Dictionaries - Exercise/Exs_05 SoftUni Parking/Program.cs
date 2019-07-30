using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_05_SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var database = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');
                string command = parts[0];
                string user = parts[1];
                switch (command)
                {
                    case "register":
                        string number = parts[2];
                        if (database.ContainsKey(user))
                        {
                            Console.WriteLine($"ERROR: already registered " +
                                              $"with plate number {number}");
                        }
                        else
                        {
                            database.Add(user, number);
                            Console.WriteLine($"{user} registered {number} successfully");
                        }
                        break;
                    case "unregister":
                        if (database.ContainsKey(user))
                        {
                            database.Remove(user);
                            Console.WriteLine($"{user} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {user} not found");
                        }
                        break;
                }
            }
            foreach (var data in database)
            {
                Console.WriteLine($"{data.Key} => {data.Value}");
            }

        }
    }
}
