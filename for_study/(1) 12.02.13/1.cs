using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number.");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorial = ");
            Console.Write(Fib(num));
            Console.ReadKey();
        }
        public static int Fact(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return Fact(n - 1) * n;
        }
    }
}
