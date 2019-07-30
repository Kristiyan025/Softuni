using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_04_Songs
{
    class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var songs = new Song[n];
            for (int i = 0; i < n; i++)
            {
                string song = Console.ReadLine();
                string[] properties = song.Split('_').ToArray();
                songs[i] = new Song
                {
                    TypeList=properties[0],
                    Name=properties[1],
                    Time=properties[2]
                };
            }
            string requestedTypeList = Console.ReadLine();
            if (requestedTypeList == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    if (song.TypeList == requestedTypeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }

        }
    }
}
