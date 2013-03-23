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
            Print_1();
            Print_2();
            Print_3();
        }

        private void Print_1()
        {
            Console.Write('(');
            Left.Print();
        }

        public virtual void Print_2() { }

        private void Print_3()
        {
            Right.Print();
            Console.Write(')');
        }
    }
}
