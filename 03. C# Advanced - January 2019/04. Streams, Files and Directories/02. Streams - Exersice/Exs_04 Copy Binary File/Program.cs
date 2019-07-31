namespace Exs_04_Copy_Binary_File
{
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {

            using (var reader = new FileStream(@"Resources\copyMe.png", FileMode.Open))
            {
                using (var writer = new FileStream(@"Resources\newCopy.png", FileMode.CreateNew))
                {
                    var buffer = new byte[4096]; //4MB
                    while (true)
                    {
                        int totalRead = reader.Read(buffer, 0, buffer.Length);
                        writer.Write(buffer, 0, totalRead);
                        if (totalRead != buffer.Length)
                        {
                            break;
                        }
                    }
                }
            }

        }
    }
}
