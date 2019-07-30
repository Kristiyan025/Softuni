using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_10_Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] tickets = Console.ReadLine().Split(new[] { ',', ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            foreach (var tic in tickets)
            {
                if (tic.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                string first = tic.Substring(0, 10);
                string second = tic.Substring(10);
                int length = 0;
                char symbol = ' ';
                for (int i = 6; i <= 10; i++)
                {
                    if(first.Contains(new string('@',i))&&second.Contains(new string('@', i)))
                    {
                        length = i;
                        symbol = '@';
                    }
                    else if(first.Contains(new string('#',i))&&second.Contains(new string('#', i)))
                    {
                        length = i;
                        symbol = '#';
                    }
                    else if(first.Contains(new string('$',i))&&second.Contains(new string('$', i)))
                    {
                        length = i;
                        symbol = '$';
                    }
                    else if(first.Contains(new string('^',i))&&second.Contains(new string('^', i)))
                    {
                        length = i;
                        symbol = '^';
                    }
                }
                if (length < 6)
                {
                    Console.WriteLine($"ticket \"{tic}\" - no match");
                }
                else if (length == 10)
                {
                    Console.WriteLine($"ticket \"{tic}\" - {10}{symbol} Jackpot!");
                }
                else 
                {
                    Console.WriteLine($"ticket \"{tic}\" - {length}{symbol}");
                }
            }

        }
    }
}
