
namespace _1
{
    public abstract class Node
    {
        public char value { set; get; }
        public Node left { set; get; }
        public Node right { set; get; }
        public Node parent { set; get; }
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
