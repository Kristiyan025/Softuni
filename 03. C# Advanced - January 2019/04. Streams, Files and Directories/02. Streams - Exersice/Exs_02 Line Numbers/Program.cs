namespace Exs_02_Line_Numbers
{
    using System.Collections.Generic;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {

            using (var reader = new StreamReader(@"Resources\text.txt"))
            {
                using (var writer = new StreamWriter(@"Resources\Output.txt"))
                {
                    var chars = new List<char> { '-', ',', '.', '!', '?', '\'' };
                    int counter = 1;
                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        int symbols = 0;
                        int letters = 0;
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (chars.Contains(line[i]))
                            {
                                symbols++;
                            }
                            else if(line[i]!=' ')
                            {
                                letters++;
                            }
                        }
                        line = $"Line {counter}: {line} ({letters})({symbols})";
                        writer.WriteLine(line);
                        counter++;
                    }
                }
            }

        }
    }
}
