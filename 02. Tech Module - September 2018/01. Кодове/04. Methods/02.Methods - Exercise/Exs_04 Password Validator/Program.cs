using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_04_Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {

            string password = Console.ReadLine();
            PasswordValidator(password);

        }

        static void PasswordValidator(string password)
        {
            int digitCounter = 0;
            bool isOnlyLettersDigits = true;
            for (int i = 0; i < password.Length; i++)
            {

                if (!char.IsLetterOrDigit(password[i]))
                {
                    isOnlyLettersDigits = false;
                }

                if (char.IsDigit(password[i]))
                {
                    digitCounter++;
                }
            }
            bool possibility1 = true, possibility2 = true, possibility3 = true;
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                possibility1 = false;
            }
            if (!isOnlyLettersDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                possibility2 = false;
            }
            if (digitCounter < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                possibility3 = false;
            }
            if(possibility1 && possibility2 && possibility3)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
