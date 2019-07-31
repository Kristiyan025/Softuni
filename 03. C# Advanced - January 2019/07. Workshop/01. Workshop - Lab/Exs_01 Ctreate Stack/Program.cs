namespace Exs_01_Create_Stack
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            var stack = new CoolStack();

            stack.Push(3);
            stack.Push(2);
            stack.Push(7);
            stack.Push(6);
            stack.Push(4);

            Console.WriteLine(stack.Count == 5);

            var last = (int)stack.Pop();

            Console.WriteLine(last == 4);

            stack.ForEach(x => Console.WriteLine(x));

        }
    }
}
