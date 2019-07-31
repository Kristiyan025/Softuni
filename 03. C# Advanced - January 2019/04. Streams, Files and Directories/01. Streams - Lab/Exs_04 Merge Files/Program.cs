namespace Exs_04_Merge_Files
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {

            var firstLines = new List<string>();
            using(var reader1 = new StreamReader(@"Resources\04. Merge Files\FileOne.txt"))
            {
                using (var reader2 = new StreamReader(@"Resources\04. Merge Files\FileTwo.txt"))
                {
                    using (var writer = new StreamWriter(@"Resources\04. Merge Files\Output.txt"))
                    {
                        while (true)
                        {
                            string line1 = reader1.ReadLine();
                            string line2 = reader2.ReadLine();
                            if (line1 == null && line2 == null)
                            {
                                break;
                            }
                            if (line1 != null)
                            {
                                writer.WriteLine(line1);
                            }
                            if (line2 != null)
                            {
                                writer.WriteLine(line2);
                            }
                        }
                    }
                }
            }

        }
    }
}
