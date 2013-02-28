using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    public class StackOnArray : IStack
    {
        private int lengthStack;
        private int[] arr;

        public StackOnArray()
        {
            lengthStack = 0;
            arr = new int[100];
        }

        private bool CheckLength()
        {
            return (arr.Length - 2 > lengthStack);
        }

        private bool IsEmpty()
        {
            if (lengthStack == 0)
            {
                Console.WriteLine("Stack is empty!");
            }
            return (lengthStack == 0);
        }

        public int Top()
        {
            if (IsEmpty())
            {
                return 0;
            }
            return arr[lengthStack - 1];
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                return 0;
            }
            int temp = arr[lengthStack - 1];
            lengthStack--;
            arr[lengthStack] = 0;
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
            arr[lengthStack] = num;
            ++lengthStack;
        }
    }
}
