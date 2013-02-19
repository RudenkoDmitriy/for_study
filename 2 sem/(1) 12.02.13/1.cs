using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number = ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Factorial = ");
            Console.Write(Fact(num));
            Console.ReadKey();
        }
        public static int Fact(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("InCorrect number!");
                return 0;
            }

            if (n < 2)
            {
                return 1;
            }

            int temp = 1;
            for (int i = 2; i < n + 1; ++i)
            {
                temp = temp * i;
            }
            return temp;
        }

    }
}
