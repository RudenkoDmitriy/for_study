using System;

namespace _1
{
    public class Stack<T>
    {
        /// <summary>
        /// Push element on stack.
        /// </summary>
        /// <param name="value"></param>
        public void Push(T value)
        {
            StackElement<T> temp = new StackElement<T>();
            temp.Value = value;
            temp.Next = this.head;
            this.head = temp;
        }

        /// <summary>
        /// Show element on stack.
        /// </summary>
        /// <returns></returns>
        public T Top()
        {
            if (head == null)
            {
                throw new StackEmptyException();
            }
            return this.head.Value;
        }

        /// <summary>
        /// Show element on stack and delete it from the stack.
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            if (head == null)
            {
                throw new StackEmptyException();
            }
            T temp = this.head.Value;
            StackElement<T> pos = this.head;
            this.head = this.head.Next;
            return temp;
        }

        private StackElement<T> head;
    }
}
