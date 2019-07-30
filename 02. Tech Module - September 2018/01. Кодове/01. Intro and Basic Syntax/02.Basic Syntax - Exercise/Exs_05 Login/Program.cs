using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_05_Login
{
    class Program
    {
        static void Main(string[] args)
        {

            string userName = Console.ReadLine();
            string password = "";
            for (int i = 0; i < userName.Length; i++)
            {
                password = userName[i] + password;
            }
            int countTries = 0;
            string tryPassword = Console.ReadLine();
            while (tryPassword != password)
            {
                countTries++;
                if (countTries > 3)
                {
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                tryPassword = Console.ReadLine();
            }
            if (tryPassword != password)
            {
                Console.WriteLine($"User {userName} blocked!");
            }
            else
            {
                Console.WriteLine($"User {userName} logged in.");
            }

        }
    }
}
