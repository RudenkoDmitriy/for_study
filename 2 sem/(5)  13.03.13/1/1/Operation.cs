using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public class Operation : Node
    {
        public Operation()
        {
            Left = new Number();
            Right = new Number();
        }

        public override void Print()
        {
            Console.Write('(');
            Left.Print();
            PrintOperation();
            Right.Print();
            Console.Write(')');
        }

        public virtual void PrintOperation() { }

        public override int Action()
        {
            return 0;
        }
    }
}
