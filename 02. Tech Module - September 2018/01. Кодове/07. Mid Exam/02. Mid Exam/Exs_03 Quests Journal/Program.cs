using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_03_Quests_Journal
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> courses = Console.ReadLine().Split(',').ToList();
            for (int i = 1; i < courses.Count(); i++)
            {
                courses[i] = courses[i].Remove(0, 1);
            }
            while (true)
            {
                string com = Console.ReadLine();
                if(com == "Retire!")
                {
                    break;
                }
                string[] parts = com.Split('-').ToArray();
                string command = parts[0].Remove(parts[0].Count() - 1);
                string param= parts[1].Remove(0, 1);
                switch (command)
                {
                    case "Start":
                        if (!courses.Contains(param))
                        {
                            courses.Add(param);
                        }
                        break;
                    case "Complete":
                        if (courses.Contains(param))
                        {
                            courses.Remove(param);
                        }
                        break;
                    case "Side Quest":
                        string[] c = param.Split(':').ToArray();
                        string quest = c[0];
                        string sideQuest = c[1];
                        if (courses.Contains(quest))
                        {
                            if (!courses.Contains(sideQuest))
                            {
                                courses.Insert(courses.IndexOf(quest) + 1, sideQuest);
                            }
                        }
                        break;
                    case "Renew":
                        if (courses.Contains(param))
                        {
                            courses.Remove(param);
                            courses.Add(param);
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ",courses));

        }
    }
}
