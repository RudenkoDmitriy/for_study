using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public class Stack
    {
        private class StackElement
        {
            public StackElement next;
            public int num;
        }

        private StackElement head;

        public Stack()
        {
            this.head = null;
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
            if (head == null)
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
