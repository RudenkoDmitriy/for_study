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
            this.pos = list.First();
            this.list = list;
        }

        public bool MoveNext()
        {
            this.numberOFPassedElements++;
            this.pos = pos.Next;
            return numberOFPassedElements < this.list.Length() + 1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public T Current
        {
            get
            {
                return this.pos.Value;
            }
        }

        public void Reset()
        {
            this.pos = this.list.First();
            numberOFPassedElements = 0;
        }

        public void Dispose() { }

        private ListElement<T> pos;
        private int numberOFPassedElements = 0;
        private List<T> list;
    }
}
