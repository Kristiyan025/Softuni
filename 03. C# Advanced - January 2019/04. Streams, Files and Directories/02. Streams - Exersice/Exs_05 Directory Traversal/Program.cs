namespace Exs_05_Directory_Traversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            string path = Console.ReadLine();
            DirectoryPrinting(path);
            
        }

        static void DirectoryPrinting(string path)
        {
            var dir = new DirectoryInfo(path);
            var files = dir.GetFiles();
            var dictionary = new Dictionary<string, SortedDictionary<double, string>>();
            foreach (var file in files)
            {
                string extention = file.Extension;
                string name = file.Name;
                double length = file.Length;
                if (!dictionary.ContainsKey(extention))
                {
                    dictionary.Add(extention, new SortedDictionary<double, string>());
                }
                dictionary[extention].Add(length, name);

            }
            dictionary = dictionary.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (var writer = new StreamWriter($"{filePath}/report.txt"))
            {
                foreach (var ext in dictionary)
                {
                    writer.WriteLine(ext.Key);
                    foreach (var file in ext.Value)
                    {
                        writer.WriteLine($"--{file.Value} - {file.Key / 1024,00:F3}kb");
                    }
                }
            }
        }
    }
}
