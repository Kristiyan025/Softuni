namespace Exs_01_Even_Lines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            using(var reader = new StreamReader(@"Resources\text.txt"))
            {
                using (var writer = new StreamWriter(@"Resources\Output.txt"))
                {
                    var chars = new List<char> { '-', ',', '.', '!', '?' };
                    int counter = 0;
                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        if (counter % 2 == 0)
                        {
                            foreach (var symbol in chars)
                            {
                                line = line.Replace(symbol, '@');
                            }
                            var words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                            words.Reverse();
                            writer.WriteLine(string.Join(" ", words));
                        }
                        counter++;
                    }
                }
            }

        }
    }
}
