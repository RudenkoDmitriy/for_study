using System;

namespace _1
{
    public class Multiply : Node
    {
        public Multiply()
        {
            left = new Number();
            right = new Number();
        }

        public override int Action()
        {
            return left.Action() * right.Action();
        }

        public override void Print()
        {
            Console.Write('(');
            left.Print();
            Console.Write('*');
            right.Print();
            Console.Write(')');
        }
    }
}
