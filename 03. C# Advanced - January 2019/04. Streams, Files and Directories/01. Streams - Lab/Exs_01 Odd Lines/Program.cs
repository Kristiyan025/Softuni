namespace Exs_01_Odd_Lines
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {

            using(var reader=new StreamReader(@"Resources\01. Odd Lines\Input.txt",true))
            {
                int counter = 0;
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    if (counter % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    counter++;
                }
            }

        }
    }
}
