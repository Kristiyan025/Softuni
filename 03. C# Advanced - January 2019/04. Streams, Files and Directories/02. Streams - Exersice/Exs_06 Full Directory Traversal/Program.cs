﻿namespace Exs_06_Full_Directory_Traversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Program
    {
        static string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        static void Main(string[] args)
        {

            string path = Console.ReadLine();
            using(var writer = new StreamWriter($"{filePath}/report2.txt", true))
            {
                writer.WriteLine($"    ***** Main Directory: {new DirectoryInfo(path).Name}*****    ");
            }
            DirectoryPrinting(path);
            var sub = new DirectoryInfo(path).GetDirectories();
            foreach (var dir in sub)
            {
                using(var writer = new StreamWriter($"{filePath}/report2.txt", true))
                {
                    writer.WriteLine($"    ***** Sub Directory: {new DirectoryInfo(dir.FullName).Name}*****    ");
                }
                DirectoryPrinting(dir.FullName);
            }

        }

        static void DirectoryPrinting(string path)
        {
            var files = new DirectoryInfo(path).GetFiles();
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
            using (var writer = new StreamWriter($"{filePath}/report2.txt", true))
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
