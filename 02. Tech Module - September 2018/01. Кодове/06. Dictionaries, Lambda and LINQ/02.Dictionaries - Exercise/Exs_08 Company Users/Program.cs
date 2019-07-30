using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_08_Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {

            var database = new Dictionary<string, List<string>>();
            while (true)
            {
                string info = Console.ReadLine();
                if (info == "End")
                {
                    break;
                }
                string[] parts = info.Split('-');
                string company = parts[0].Remove(parts[0].Length - 1);
                string emploeeId = parts[1].Remove(0, 2);
                if (database.ContainsKey(company))
                {
                    if (!database[company].Contains(emploeeId))
                    {
                        database[company].Add(emploeeId);
                    }
                }
                else
                {
                    List<string> emploees = new List<string>();
                    emploees.Add(emploeeId);
                    database.Add(company, emploees);
                }
            }
            database = database.OrderBy(n => n.Key).ToDictionary(n => n.Key, n => n.Value);
            foreach (var data in database)
            {
                Console.WriteLine(data.Key);
                foreach (var id in data.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }

        }
    }
}
