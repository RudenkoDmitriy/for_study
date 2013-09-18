using System.Collections.Generic;
using System.Collections;

namespace BinaryTree
{
    public class TreeIterator : IEnumerator
    {
        public TreeIterator(Tree tree)
        {
            InitializeList(tree);
        }

        public bool MoveNext()
        {
            this.numberOFPassedItems++;
            return numberOFPassedItems < this.list.Count;
        }

        public int Current
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

        public void Dispose() { }

        private List<int> list = new List<int>();
        private int numberOFPassedItems = -1;

        private void InitializeList(Tree tree)
        {
            if (tree == null)
            {
                return;
            }
            InitializeList(tree.Left);
            this.list.Add(tree.Item);
            InitializeList(tree.Right);
        }
    }
}
