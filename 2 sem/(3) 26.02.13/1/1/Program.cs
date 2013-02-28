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

    public class StackElement
    {
        public StackElement next;
        public int num;
    }

    public class Stack
    {
        private StackElement head;
        public Stack()
        {
            this.head = new StackElement();
            this.head.next = null;
            this.head.num = 0;
        }
        public void Push(int num)
        {
            StackElement temp = new StackElement();
            temp.num = num;
            temp.next = this.head;
            this.head = temp;
        }
        public int Top()
        {
            return this.head.num;
        }
        public int Pop()
        {
            if (head.next == null) 
            {
                Console.WriteLine("Stack is empty!");
                return 0;
            }
            int temp = this.head.num;
            StackElement pos = this.head;
            this.head = this.head.next;
            return temp;
        }
    }
}
