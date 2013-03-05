using System;

namespace _1
{
    public class Stack
    {
        private class StackElement
        {
            public int Num { get; set; }

            public StackElement Next { get; set; }
        }

        private StackElement head;

        public Stack()
        {
            this.head = null;
        }

        public void Push(int num)
        {
            StackElement temp = new StackElement();
            temp.Num = num;
            temp.Next = this.head;
            this.head = temp;
        }

        public int Top()
        {
            return this.head.Num;
        }

        public int Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is empty!");
                return 0;
            }
            int temp = this.head.Num;
            StackElement pos = this.head;
            this.head = this.head.Next;
            return temp;
        }
    }
}
