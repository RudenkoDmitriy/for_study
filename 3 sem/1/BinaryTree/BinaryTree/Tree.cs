using System.Collections;

namespace BinaryTree
{
    public class Tree : IEnumerable
    {
        public Tree()
        {
            this.parent = this;
        }

        /// <summary>
        /// Adds the item to the tree.
        /// </summary>
        /// <param name="value"></param>
        public void Add(int value)
        {
            if (this.Find(value))
            {
                return;
            }
            if (length == 0)
            {
                this.Item = value;
                length++;
                return;
            }            
            this.length++;
            if (this.Item > value)
            {
                if (this.Left == null)
                {
                    this.Left = new Tree();
                    this.Left.Item = value;
                    this.Left.parent = this;
                    return;
                }
                else
                {
                    this.Left.Add(value);
                }
            }
            else
            {
                if (this.Right == null)
                {
                    this.Right = new Tree();
                    this.Right.Item = value;
                    this.Right.parent = this;
                    return;
                }
                else
                {
                    this.Right.Add(value);
                }
            }
        }

        /// <summary>
        /// Finds the item in the tree.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Find(int value)
        {
            if (this.Item == value)
            {
                return true;
            }
            else
            {
                if (this.Item > value)
                {
                    if (this.Left == null)
                    {
                        return false;
                    }
                    else
                    {
                        this.Left.length = this.length;
                        return this.Left.Find(value);
                    }
                }
                else
                {
                    if (this.Right == null)
                    {
                        return false;
                    }
                    else
                    {
                        this.Right.length = this.length;
                        return this.Right.Find(value);
                    }
                }
            }
        }

        /// <summary>
        /// Removes the item in the tree.
        /// </summary>
        /// <param name="value"></param>
        public void Remove(int value)
        {
            if (value > this.Item)
            {
                if (this.Right != null)
                {
                    this.Right.Remove(value);
                }
                else
                {
                    return;
                }
            }
            if (value < this.Item)
            {
                if (this.Left != null)
                {
                    this.Left.Remove(value);
                }
                else
                {
                    return;
                }
            }
            if (value == this.Item)
            {
                this.length--;
                if (this.Right == null && this.Left == null)
                {
                   /* if (this.parent.Left == this)
                    {
                        this.parent.Left = null;
                        return;
                    }
                    else
                    {
                        this.parent.Right = null;
                        return;
                    }*/
                    SetToNull(ref this.parent, this.parent.Left == this);
                    return;
                }
                if (this.Right == null)
                {
                    this.parent.Left = this.Left;
                    return;
                }
                if (this.Left == null)
                {
                    this.parent.Right = this.Right;
                    return;
                }
                if (this.Right.Left != null)
                {
                    this.Item = this.Right.Left.Item;
                    this.Right.Left.Remove(this.Right.Left.Item);
                }
                else
                {
                    this.Item = this.Right.Item;
                    this.Right.Remove(this.Right.Item);
                }
            }
        }

        /// <summary>
        /// This function using for function "foreach".
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            return new TreeIterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Tree Right
        {
            get;
            private set;
        }

        public Tree Left
        {
            get;
            private set;
        }

        public int Item
        {
            get;
            private set;
        }
        
        private static void SetToNull(ref Tree tree, bool isLeft)
        {
            if (isLeft)
                tree.Left = null;
            else
                tree.Right = null;
        }
        private Tree parent;
        private int length = 0;
    }
}
