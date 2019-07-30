namespace Exs_08_Balanced_Parenthesis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            string izraz = Console.ReadLine();
            var stack = new Stack<char>();
            int count = izraz.Length;
            bool isValid = true;
            /*for (int i = 0; i < count; i++)
            {
                if(izraz[i] != izraz[2 * count - i - 1])
                {
                    isValid = false;
                    break;
                }
            }*/
            for (int i = 0; i < count; i++)
            {
                if(izraz[i] == '(' || izraz[i] == '[' || izraz[i] == '{')
                {
                    stack.Push(izraz[i]);
                }
                else if(stack.Any())
                {
                    if((izraz[i] == ')' && stack.Peek() == '(') ||
                       (izraz[i] == ']' && stack.Peek() == '[') ||
                       (izraz[i] == '}' && stack.Peek() == '{'))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                }
                else
                {
                    isValid = false;
                    break;
                }
            }
            if (isValid && !stack.Any())
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
