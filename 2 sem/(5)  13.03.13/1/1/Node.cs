
namespace _1
{
    public abstract class Node
    {
        public char value { set; get; }
        public Node Left { set; get; }
        public Node Right { set; get; }
        public Node Parent { set; get; }

        public virtual void Print()
        {
            return;
        }

        public virtual int Action()
        {
            return '0';
        }
    }
}
