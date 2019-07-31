namespace Exs_01_Action_Print
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split().ToList();
            Action <string> print = x => Console.WriteLine(x);
            input.ForEach(print);

        }
    }
}
