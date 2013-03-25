using System;

namespace _1
{
    public class Number : Node
    {
        public override int Action()
        {
            return Convert.ToInt32(Value) - 48;
        }

        public override void Print()
        {
            Console.Write(' ');
            Console.Write(Value);
            Console.Write(' ');
        }
    }
}
