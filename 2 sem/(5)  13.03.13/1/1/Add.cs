using System;

namespace _1
{
    public class Add : Node
    {
        public Add()
        {
            left = new Number();
            right = new Number();
        }

        public override int Action()
        {
            return left.Action() + right.Action();
        }

        public override void Print()
        {
            Console.Write('(');
            left.Print();
            Console.Write('+');
            right.Print();
            Console.Write(')');
        }
    }
}
