using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            for (int i = 1; i < 10; ++i)
            {
                stack.Push(i);
            }
            for (int i = 1; i < 10; ++i)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.ReadKey();
        }

    }
}
