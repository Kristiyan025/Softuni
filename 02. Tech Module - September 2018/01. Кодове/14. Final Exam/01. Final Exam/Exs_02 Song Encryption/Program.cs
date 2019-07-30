using System;
using System.Text;

namespace Exs_02_Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string info = Console.ReadLine();
                if (info == "end")
                {
                    break;
                }
                string[] songsInfo = info.Split(':');
                string artist = songsInfo[0];
                string song = songsInfo[1];
                if (IsValidArtist(artist) && IsValidSong(song))
                {
                    int l = artist.Length;
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < artist.Length; i++)
                    {
                        if (artist[i] == ' ' || artist[i] == '\'')
                        {
                            sb.Append(artist[i]);
                        }
                        else
                        {
                            char newS = Convert.ToChar(Convert.ToInt32(artist[i]) + l);
                            if ((char.IsUpper(artist[i]) && newS > 'Z') || (char.IsLower(artist[i]) && newS > 'z'))
                            {
                                newS = Convert.ToChar(Convert.ToInt32(newS) - 26);
                            }
                            sb.Append(newS);
                        }
                    }
                    sb.Append('@');
                    for (int i = 0; i < song.Length; i++)
                    {
                        if (song[i] == ' ')
                        {
                            sb.Append(song[i]);
                        }
                        else
                        {
                            char newS = Convert.ToChar(Convert.ToInt32(song[i]) + l);
                            if (newS > 'Z')
                            {
                                newS = Convert.ToChar(Convert.ToInt32(newS) - 26);
                            }
                            sb.Append(newS);
                        }
                    }
                    Console.WriteLine($"Successful encryption: {sb}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }
        }

        static bool IsValidArtist(string name)
        {
            if (!char.IsUpper(name[0]))
            {
                return false;
            }
            for (int i = 1; i < name.Length; i++)
            {
                if (!(char.IsLower(name[i]) || name[i] == '\'' || name[i] == ' '))
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsValidSong(string song)
        {
            for (int i = 0; i < song.Length; i++)
            {
                if (!(char.IsUpper(song[i]) || song[i] == ' '))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
