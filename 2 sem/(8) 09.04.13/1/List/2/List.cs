using System;
using System.Collections;
using System.Collections.Generic;

namespace _2
{
    /// <summary>
    /// List of items.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class List<T> : IEnumerable<T>
    {
        /// <summary>
        /// Insert element in list.
        /// </summary>
        /// <param name="value">
        /// Value of this element.
        /// </param>
        /// <param name="position">
        /// Position in list, to insert this element. ('0' - 'Length of list');
        /// </param>
        public void Insert(T value, int position)
        {
            ListElement<T> pos = this.head;
            if (position > this.Length)
            {
                position = this.length;
            }
            if (position < 0)
            {
                position = 0;
            }
            for (int i = 0; i < position; ++i)
            {
                pos = pos.Next;
            }
            ListElement<T> temp = new ListElement<T>();
            temp.Value = value;
            if (pos != null)
            {
                temp.Next = pos.Next;
            }
            pos.Next = temp;
            ++length;
        }

        /// <summary>
        /// Remove element in list by position. ('0' - 'Length of list - 1')
        /// </summary>
        /// <param name="position"></param>
        public void Remove(int position)
        {
            ListElement<T> temp = this.head.Next;
            if (this.head.Next == null)
            {
                throw new ListEmptyException();
            }
            if (position == 0)
            {
                if (this.head.Next.Next == null)
                {
                    this.head.Next = null;
                }
                else
                {
                    this.head.Next = this.head.Next.Next;
                }
                --length;
                return;
            }
            for (int i = 1; i < position; ++i)
            {
                temp = temp.Next;
            }
            if (position == (this.Length))
            {
                temp.Next = null;
            }
            else
            {
                temp.Next = temp.Next.Next;
            }
            --length;
        }

        /// <summary>
        /// Length of list.
        /// </summary>
        /// <returns></returns>
        public int Length
        {
            get
            {
                return this.length;
            }
        }

        /// <summary>
        /// Return position first element.
        /// </summary>
        /// <returns></returns>
        public ListElement<T> First
        {
            get
            {
                return this.head;
            }
        }

        /// <summary>
        /// Find element by value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Find(T value)
        {
            ListElement<T> pos = this.First;
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
