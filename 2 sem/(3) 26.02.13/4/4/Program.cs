using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.Push(7);
            calc.Push(8);
            calc.Push(80);
            calc.Divide();
            Console.WriteLine(calc.Result());
            Console.ReadKey();
        }
    }

    interface IStack
    {
        void Push(int num);
        int Top();
        int Pop();
    }

    public class StackElement
    {
        public StackElement next;
        public int num;
    }

    public class StackOnList : IStack
    {
        private StackElement head;
        public StackOnList()
        {
            this.head = new StackElement();
            this.head.next = null;
            this.head.num = 0;
        }
        public void Push(int num)
        {
            StackElement temp = new StackElement();
            temp.num = num;
            temp.next = this.head;
            this.head = temp;
        }
        public int Top()
        {
            if (head.next == null)
            {
                Console.WriteLine("Stack is empty!");
                return 0;
            }
            return this.head.num;
        }
        public int Pop()
        {
            if (head.next == null)
            {
                Console.WriteLine("Stack is empty!");
                return 0;
            }
            int temp = this.head.num;
            StackElement pos = this.head;
            this.head = this.head.next;
            return temp;
        }
    }

    public class StackOnArray : IStack
    {
        private int LengthStack;
        private int[] arr;

        public StackOnArray()
        {
            LengthStack = 0;
            arr = new int[100];
            for (int i = 0; i < 100; ++i)
            {
                arr[i] = 0;
            }
        }

        private bool CheckLength()
        {
            return (arr.Length - 2 > LengthStack);
        }

        private bool IsEmpty()
        {
            if (LengthStack == 0)
            {
                Console.WriteLine("Stack is empty!");
            }
            return (LengthStack == 0);
        }

        public int Top()
        {
            if (IsEmpty())
            {
                return 0;
            }
            return arr[LengthStack - 1];
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                return 0;
            }
            int temp = arr[LengthStack - 1];
            LengthStack--;
            arr[LengthStack] = 0;
            return temp;
        }

        public void Push(int num)
        {
            if (!(CheckLength()))
            {
                int[] temp = new int[arr.Length * 2];
                for (int i = 0; i < arr.Length; ++i)
                {
                    temp[i] = arr[i];
                }
                arr = temp;
            }
            arr[LengthStack] = num;
            ++LengthStack;
        }
    }

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
