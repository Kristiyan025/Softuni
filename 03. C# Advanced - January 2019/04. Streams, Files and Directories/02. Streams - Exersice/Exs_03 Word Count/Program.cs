namespace Exs_03_Word_Count
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            var words = new Dictionary<string, int>();
            using (var reader = new StreamReader(@"Resources\words.txt"))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    var wordsList = line.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in wordsList)
                    {
                        if (!words.ContainsKey(word))
                        {
                            words.Add(word, 0);
                        }
                    }
                }
            }
            using (var reader = new StreamReader(@"Resources\text.txt"))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    line = line.Replace('.', ' ');
                    line = line.Replace('?', ' ');
                    line = line.Replace(',', ' ');
                    line = line.Replace('-', ' ');
                    line = line.Replace('!', ' ');
                    var wordList = line.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in wordList)
                    {
                        if (words.ContainsKey(word))
                        {
                            words[word]++;
                        }
                    }
                }
            }
            words = words.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            using (var writer = new StreamWriter(@"Resources\actualResult.txt"))
            {
                foreach (var word in words)
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }

        }
    }
}
