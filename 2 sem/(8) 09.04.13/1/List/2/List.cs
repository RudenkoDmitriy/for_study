using System;
using System.Collections;
using System.Collections.Generic;

namespace _2
{
    public class List<T> : IEnumerable<T>
    {
        /// <summary>
        /// Insert element in list.
        /// </summary>
        /// <param name="value">
        /// Value of this element.
        /// </param>
        /// <param name="pos">
        /// Position in list, to insert this element.
        /// </param>
        public void Insert(T value, ListElement<T> pos)
        {
            ListElement<T> temp = new ListElement<T>();
            temp.Value = value;
            temp.Next = pos;
            pos.Next = temp;
            ++length;
        }

        /// <summary>
        /// Remove element in list by position.
        /// </summary>
        /// <param name="pos"></param>
        public void Remove(ListElement<T> pos)
        {
            ListElement<T> temp = this.head;
            if (this.head.Next == null)
            {
                throw new ListEmptyException();
            }
            while (temp.Next == null || temp.Next != pos)
            {
                temp = temp.Next;
            }
            temp.Next = pos.Next;
            --length;
        }

        /// <summary>
        /// Length of list.
        /// </summary>
        /// <returns></returns>
        public int Length()
        {
            return length;
        }

        /// <summary>
        /// This function return value of element by position.
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public T Retrieve(ListElement<T> pos)
        {
            return pos.Value;
        }

        /// <summary>
        /// Return next position.
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public ListElement<T> Next(ListElement<T> pos)
        {
            return pos.Next;
        }

        /// <summary>
        /// Return position first element.
        /// </summary>
        /// <returns></returns>
        public ListElement<T> First()
        {
            return this.head;
        }

        /// <summary>
        /// Find element by value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Find(T value)
        {
            ListElement<T> pos = this.First();
            for (int i = 0; i < this.length; ++i)
            {
                if (pos.Next.Value.Equals(value))
                {
                    return true;
                }
                pos = pos.Next;
            }
            return false;
        }

        /// <summary>
        /// Print all elements on console.
        /// </summary>
        public void PrintList()
        {
            ListElement<T> pos = this.First();
            for (int i = 0; i < length; ++i)
            {
                Console.Write(this.Retrieve(pos.Next));
                Console.Write(' ');
                pos = pos.Next;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// This function using for function "foreach".
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return new ListIterator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private ListElement<T> head = new ListElement<T>();
        private int length = 0;
    }
}
