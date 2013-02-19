using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number.");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonachi number = ");
            Console.Write(Fib(num));
            Console.ReadKey();
        }
        public static int Fib(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            if (n == 2)
            {
                return 2;
            }
            int num1 = 1;
            int num2 = 2;
            int temp = 1;
            for (int i = 3; i < n + 1; ++i)
            {
                temp = num1;
                num1 = num2;
                num2 = num2 + temp;
            }
            return num2;
        }
    }
}
