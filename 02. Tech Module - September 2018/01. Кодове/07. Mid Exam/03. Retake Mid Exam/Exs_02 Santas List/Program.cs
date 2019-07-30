using System;
using System.Collections.Generic;
using System.Linq;

namespace Exs_02_Santas_List
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> kids = Console.ReadLine().Split('&').ToList();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Finished!")
                {
                    break;
                }
                string[] parts = line.Split(' ');
                string command = parts[0];
                string kidName = parts[1];
                switch (command)
                {
                    case "Bad":
                        if (!kids.Contains(kidName))
                        {
                            kids.Insert(0, kidName);
                        }
                        break;
                    case "Good":
                        if (kids.Contains(kidName))
                        {
                            kids.Remove(kidName);
                        }
                        break;
                    case "Rename":
                        string newKidName = parts[2];
                        int index = -1;
                        if (kids.Contains(kidName))
                        {
                            index = kids.IndexOf(kids.Find(x => x == kidName));
                        }
                        if (index != -1)
                        {
                            kids[index] = newKidName;
                        }
                        break;
                    case "Rearrange":
                        if (kids.Contains(kidName))
                        {
                            kids.RemoveAt(kids.IndexOf(kidName));
                            kids.Add(kidName);
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", kids));

        }
    }
}
