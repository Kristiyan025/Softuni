namespace Exs_01_Rhombus_of_Stars
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintUpper(n);
            PrintLower(n);
        }

        static string LineWithStarts(int count, int n)
        {
            int spacesOutside = n - count;
            string line = string.Empty;
            line += new string(' ', spacesOutside);
            for (int i = 0; i < count - 1; i++)
            {
                line += "* ";
            }
            line += '*';
            line += new string(' ', spacesOutside);
            return line;
        }

        static void PrintUpper(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(LineWithStarts(i, n));
            }
        }

        static void PrintLower(int n)
        {
            for (int i = n - 1; i > 0; i--)
            {
                Console.WriteLine(LineWithStarts(i, n));
            }
        }
    }
}
