using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_07_Store_Boxes
{
    class Item
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    class Box
    {
        public string SerialNumber { get; set; }
        
        public Item TheItem { get; set; }

        public int ItemQuantity { get; set; }

        public decimal BoxPrice { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Box> boxes = new List<Box>();
            while (true)
            {
                string box = Console.ReadLine();
                if (box == "end")
                {
                    break;
                }
                string[] properties = box.Split(' ').ToArray();
                boxes.Add(new Box
                {
                    SerialNumber=properties[0],
                    TheItem = new Item
                    {
                        Name=properties[1],
                        Price=decimal.Parse(properties[3])
                    },
                    ItemQuantity=int.Parse(properties[2]),
                    BoxPrice=decimal.Parse(properties[3])*int.Parse(properties[2])
                });
            }
            boxes = boxes.OrderByDescending(n => n.BoxPrice).ToList();
            foreach (var box in boxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.TheItem.Name} - ${box.TheItem.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:F2}");
            }

        }
    }
}
