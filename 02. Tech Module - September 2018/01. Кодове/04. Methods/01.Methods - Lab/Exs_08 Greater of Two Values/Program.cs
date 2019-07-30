using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_08_Greater_of_Two_Values
{
    class Program
    {
        static void GetMax(string dataType, string first, string second)
        {
            switch (dataType)
            {
                case "INT":
                    {
                        int a = int.Parse(first);
                        int b = int.Parse(second);
                        Console.WriteLine(Math.Max(a, b));                     
                        break;
                    }
                case "CHAR":
                    {
                        int a = Convert.ToInt32(first);
                        int b = Convert.ToInt32(second);
                        Console.WriteLine(Math.Max(a, b).ToString());
                        break;
                    }
                case "STRING":
                    {
                        int value = string.Compare(first, second);
                        if (value == 1)
                        {
                            Console.WriteLine(first);
                        }
                        else if(value==0 || value == -1)
                        {
                            Console.WriteLine(second);
                        }
                        break;                        
                    }

            }
        }
        static void Main(string[] args)
        {

            var dataType = Console.ReadLine().ToUpper();
            string first = Console.ReadLine();
            string second = Console.ReadLine();           
            GetMax(dataType, first, second);

        }
    }
}
