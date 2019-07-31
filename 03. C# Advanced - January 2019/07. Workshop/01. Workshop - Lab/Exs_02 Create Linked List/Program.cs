namespace Exs_02_Create_Linked_List
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            var linkedList = new CoolLinkedList();

            linkedList.AddHead(5);
            linkedList.AddHead(10);
            linkedList.AddHead(15);

            // 15 <-> 10 <-> 5

            Console.WriteLine((int)linkedList.Head == 15);
            Console.WriteLine((int)linkedList.Tail == 5);
            Console.WriteLine(linkedList.Count == 3);

            linkedList.AddTail(20);
            linkedList.AddTail(25);

            // 15 <-> 10 <-> 5 <-> 20 <-> 25

            linkedList.ForEach(Console.WriteLine);

            var arr = linkedList.ToArray();

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine((int)linkedList.Head == 15);
            Console.WriteLine((int)linkedList.Tail == 25);
            Console.WriteLine(linkedList.Count == 5);

            Console.WriteLine((int)linkedList.RemoveHead() == 15);
            Console.WriteLine((int)linkedList.RemoveHead() == 10);
            Console.WriteLine((int)linkedList.RemoveHead() == 5);
            Console.WriteLine((int)linkedList.RemoveTail() == 25);
            Console.WriteLine((int)linkedList.RemoveTail() == 20);
            Console.WriteLine(linkedList.Count == 0);

            try
            {
                Console.WriteLine(linkedList.Head);
                Console.WriteLine(false);
            }
            catch(InvalidOperationException)
            {
                Console.WriteLine(true);
            }

            var newLinkedList = new CoolLinkedList();

            newLinkedList.AddTail(5);
            newLinkedList.AddTail(10);
            newLinkedList.AddTail(5);
            newLinkedList.AddTail(20);
            newLinkedList.AddTail(5);

            newLinkedList.Remove(5);

            Console.WriteLine(newLinkedList.Count == 2);
            newLinkedList.ForEach(Console.WriteLine);
            Console.WriteLine(newLinkedList.Contains(10));
            Console.WriteLine(newLinkedList.Contains(20));
            Console.WriteLine(!newLinkedList.Contains(5));
            newLinkedList.Clear();
            Console.WriteLine(newLinkedList.Count == 0);
            Console.WriteLine(!newLinkedList.Contains(10));
            Console.WriteLine(!newLinkedList.Contains(20));

        }
    }
}
