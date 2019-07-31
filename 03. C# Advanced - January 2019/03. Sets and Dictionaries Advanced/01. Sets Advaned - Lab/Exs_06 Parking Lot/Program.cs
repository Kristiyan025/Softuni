using System;
using System.Collections.Generic;

namespace Exs_06_Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {

            var set = new HashSet<string>();
            while (true)
            {
                var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "END")
                {
                    break;
                }
                string direction = input[0];
                string number = input[1];
                switch (direction)
                {
                    case "IN":
                        set.Add(number);
                        break;
                    case "OUT":
                        if (set.Contains(number))
                        {
                            set.Remove(number);
                        }
                        break;
                }
            }
            if (set.Count != 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, set));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }

        }
    }
}
