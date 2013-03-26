using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public abstract class Operation : Node
    {
        public override void Print()
        {
            Console.Write('(');
            Left.Print();
            PrintOperation();
            Right.Print();
            Console.Write(')');
        }

        public abstract void PrintOperation();
    }
}
