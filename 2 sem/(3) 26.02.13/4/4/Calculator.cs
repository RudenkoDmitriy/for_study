using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    public class Calculator
    {
        private IStack stack;
        private int check;  // checks number of numbers

        public Calculator()
        {
            stack = new StackOnList();
            //stack = new StackOnArray();
            check = 0;
        }

        public void Push(int num)
        {
            stack.Push(num);
            ++check;
        }

        public void Add()
        {
            if (check < 2)
            {
                Console.WriteLine("insufficient numbers to add");
                return;
            }
            int num1 = stack.Pop();
            int num2 = stack.Pop();
            stack.Push(num1 + num2);
            check = check - 2;
        }

        public void Subtract()
        {
            if (check < 2)
            {
                Console.WriteLine("insufficient numbers to substract");
                return;
            }
            int num1 = stack.Pop();
            int num2 = stack.Pop();
            stack.Push(num1 - num2);
            check = check - 2;
        }

        public void Multiply()
        {
            if (check < 2)
            {
                Console.WriteLine("insufficient numbers to multiply");
                return;
            }
            int num1 = stack.Pop();
            int num2 = stack.Pop();
            stack.Push(num1 * num2);
            check = check - 2;
        }

        public void Divide()
        {
            if (check < 2)
            {
                Console.WriteLine("insufficient numbers to divide");
                return;
            }
            int num1 = stack.Pop();
            int num2 = stack.Pop();
            stack.Push(num1 / num2);
            check = check - 2;
        }

        public int Result()
        {
            --check;
            return stack.Pop();
        }
    }
}
