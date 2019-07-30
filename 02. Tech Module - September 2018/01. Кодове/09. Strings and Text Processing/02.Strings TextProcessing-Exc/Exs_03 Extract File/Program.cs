using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_03_Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {

            string direction = Console.ReadLine();
            int index = direction.LastIndexOf('\\');
            direction = direction.Remove(0, index + 1);
            string[] parts = direction.Split('.');
            string name = parts[0];
            string extention = parts[1];
            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extention}");

        }
    }
}
