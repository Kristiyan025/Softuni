using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_01_Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> usernames = Console.ReadLine().Split(',').ToList();
            for (int i = 1; i < usernames.Count; i++)
            {
                usernames[i] = usernames[i].Remove(0, 1);
            }
            usernames = usernames.Where(x => IsOnlyDigitsAndLetters(x) && IsTooLongOrShort(x))
                                                .ToList();
            foreach (var user in usernames)
            {
                Console.WriteLine(user);
            }

        }
        static bool IsTooLongOrShort(string s)
        {
            if (s.Length >= 3 && s.Length <= 16)
            {
                return true;
            }
            return false;
        }

        static bool IsOnlyDigitsAndLetters(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if ((char.IsDigit(s[i])) ||
                    (char.IsLetter(s[i])) ||
                    (s[i] == '-') ||
                    (s[i] == '_'))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
