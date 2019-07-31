namespace Exs_05_Slice_File
{
    using System;
    using System.IO;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            using(var reader = new FileStream(@"Resources\05. Slice File\sliceMe.txt", FileMode.Open))
            {
                var partLength = (long)Math.Ceiling((double)reader.Length / n);
                if(partLength < 1024)
                {
                    Console.WriteLine("Sorry, but the file is too small or the parts are too much!");
                    return;
                }
                var ost = (int)(partLength % 4096);
                var times = partLength / 4096;
                for (int i = 1; i <= n; i++)
                {
                    string newFileName = $@"Resources\05. Slice File\Part-{i}.txt";
                    using(var writer = new FileStream(newFileName, FileMode.CreateNew))
                    {
                        var buffer = new byte[4096]; //4KB
                        for (int j = 0; j < times; j++)
                        {
                            reader.Read(buffer, 0, buffer.Length);
                            writer.Write(buffer, 0, buffer.Length);
                        }
                        reader.Read(buffer, 0, ost);
                        writer.Write(buffer, 0, ost);
                        /*while (true)
                        {
                            int count = reader.Read(buffer, 0, buffer.Length);
                            currentFileSize += count;
                            writer.Write(buffer, 0, count);
                            if (count < buffer.Length)
                            {
                                break;
                            }
                            if (currentFileSize >= partLength)
                            {
                                break;
                            }
                        }*/
                    }
                }           
            }

        }
    }
}
