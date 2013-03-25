
namespace _1
{
    public abstract class Node
    {

        public char Value { set; get; }
        public Node Left { set; get; }
        public Node Right { set; get; }

        public abstract void Print();

        public abstract int Action();
    }
}
