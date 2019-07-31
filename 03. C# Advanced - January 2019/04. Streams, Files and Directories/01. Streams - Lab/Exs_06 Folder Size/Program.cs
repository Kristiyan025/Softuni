namespace Exs_06_Folder_Size
{
    using System.IO;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            var directory = new DirectoryInfo(@"Resources\06. Folder Size\TestFolder");
            var fileSize = (double)(directory.GetFiles().Select(x => x.Length).Sum());
            fileSize = fileSize / 1024.00 / 1024.00; //B -> MB
            using(var writer=new StreamWriter(@"Resources\06. Folder Size\Output.txt"))
            {
                writer.Write(fileSize);
            }

        }
    }
}
