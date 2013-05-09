using System.Collections;
using System.Collections.Generic;

namespace TreapNS
{
    internal class TreapIterator : IEnumerator
    {
        internal TreapIterator(Treap treap)
        {
            InitializeList(treap);
        }

        public bool MoveNext()
        {
            this.numberOFPassedItems++;
            return numberOFPassedItems < this.list.Count;
        }

        internal int Current
        {
            get
            {
                return this.list[numberOFPassedItems];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Reset() { }

        internal void Dispose() { }

        private List<int> list = new List<int>();
        private int numberOFPassedItems = -1;

        private void InitializeList(Treap treap)
        {
            if (treap == null || (treap.Item == 0 && treap.Priority == 0))
            {
                return;
            }
            InitializeList(treap.Left);
            this.list.Add(treap.Item);
            InitializeList(treap.Right);
        }
    }
}
