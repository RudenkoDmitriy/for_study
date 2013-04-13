using System.Collections.Generic;
using System.Collections;

namespace _2
{
    /// <summary>
    /// This class using for pass elements in list.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ListIterator<T> : IEnumerator<T>
    {
        public ListIterator(List<T> list)
        {
            this.pos = list.First;
            this.list = list;
        }

        /// <summary>
        /// Move enumerator to next position and check at the end of list.
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            this.numberOFPassedElements++;
            this.pos = pos.Next;
            return numberOFPassedElements < this.list.Length + 1;
        }

        /// <summary>
        /// Return current value.
        /// </summary>
        public T Current
        {
            get
            {
                return this.pos.Value;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        /// <summary>
        /// Sets initial value.
        /// </summary>
        public void Reset()
        {
            this.pos = this.list.First;
            numberOFPassedElements = 0;
        }

        public void Dispose() { }

        private ListElement<T> pos;
        private int numberOFPassedElements = 0;
        private List<T> list;
    }
}
