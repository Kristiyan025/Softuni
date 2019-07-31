using System;
using System.Collections.Generic;

namespace Exs_07_SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {

            var regular = new HashSet<string>();
            var vip = new HashSet<string>();
            while (true)
            {
                string guest = Console.ReadLine();
                if (guest == "PARTY")
                {
                    break;
                }
                if (char.IsDigit(guest[0]))
                {
                    vip.Add(guest);
                }
                else
                {
                    regular.Add(guest);
                }
            }
            while (true)
            {
                string guest = Console.ReadLine();
                if (guest == "END")
                {
                    break;
                }
                if (regular.Contains(guest))
                {
                    regular.Remove(guest);
                }
                else if(vip.Contains(guest))
                {
                    vip.Remove(guest);
                }
            }
            Console.WriteLine(regular.Count+vip.Count);
            foreach (var guest in vip)
            {
                Console.WriteLine(guest);
            }
            foreach (var guest in regular)
            {
                Console.WriteLine(guest);
            }

        }
    }
}
