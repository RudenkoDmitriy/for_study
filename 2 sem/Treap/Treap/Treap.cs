using System;
using System.Collections;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TreapTest")]

namespace TreapNS
{
    internal class Treap : IEnumerable
    {
        internal int Item { get; private set; }
        internal int Priority { get; private set; }

        internal Treap Left { get; private set; }
        internal Treap Right { get; private set; }

        internal Treap() { }

        /// <summary>
        /// Merge two treaps. All items right > all items left!!!
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        internal static Treap Merge(Treap left, Treap right)
        {
            if (left == null)
            {
                return right;
            }
            if (right == null)
            {
                return left;
            }
            if (left.Priority > right.Priority)
            {
                Treap newRight = Merge(left.Right, right);
                return new Treap(left.Item, left.Priority, left.Left, newRight);
            }
            else
            {
                Treap newLeft = Merge(left, right.Left);
                return new Treap(right.Item, right.Priority, newLeft, right.Right);
            }
        }

        /// <summary>
        /// Split treap on two treaps.All items right > item, item > all items left.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        internal void Split(int item, out Treap left, out Treap right)
        {
            left = null;
            right = null;
            Treap newTree = null;
            if (this.Item <= item)
            {
                if (this.Right == null)
                {
                    right = null;
                }
                else
                {
                    this.Right.Split(item, out newTree, out right);
                }
                left = new Treap(this.Item, this.Priority, this.Left, newTree);
            }
            else
            {
                if (this.Left == null)
                {
                    left = null;
                }
                else
                {
                    this.Left.Split(item, out left, out newTree);
                }
                right = new Treap(this.Item, this.Priority, newTree, this.Right);
            }
        }

        internal void Add(int item)
        {
            if (this.Find(item))
            {
                return;
            }
            Treap left;
            Treap right;
            this.Split(item, out left, out right);
            Treap result = new Treap(item, random.Next());
            result = Merge(left, result);
            result = Merge(result, right);
            this.Item = result.Item;
            this.Priority = result.Priority;
            this.Left = result.Left;
            this.Right = result.Right;
        }

        internal void Remove(int item)
        {
            Treap left = new Treap();
            Treap right = new Treap();
            Treap removeItem = new Treap();
            this.Split(item - 1, out left, out right);
            this.Split(item, out removeItem, out right);
            Treap result = Merge(left, right);
            this.Item = result.Item;
            this.Priority = result.Priority;
            this.Left = result.Left;
            this.Right = result.Right;
        }

        internal bool Find(int item)
        {
            if (this.Item == item)
            {
                return true;
            }
            if (this.Item > item && this.Left != null)
            {
                return this.Left.Find(item);
            }
            if (this.Item < item && this.Right != null)
            {
                return this.Right.Find(item);
            }
            return false;
        }

        public IEnumerator GetEnumerator()
        {
            return new TreapIterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        private Treap(int item, int priority)
        {
            this.Item = item;
            this.Priority = priority;
        }

        private Treap(int item, int priority, Treap left, Treap right)
        {
            this.Item = item;
            this.Priority = priority;
            this.Left = left;
            this.Right = right;
        }

        private Random random = new Random();
    }
}
