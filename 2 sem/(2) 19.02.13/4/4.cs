using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            var matrix = new int[num, num];
            Console.WriteLine("Before : ");
            for (int i = 0; i < num; ++i)
            {
                for (int j = 0; j < num; ++j)
                {
                    Random rand = new Random();
                    matrix[i, j] = -i + j + rand.Next(0, 80);
                    Console.Write(matrix[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            Console.WriteLine("After : ");
            matrix = BubbleSort(matrix, num);
            for (int i = 0; i < num; ++i)
            {
                for (int j = 0; j < num; ++j)
                {
                    Console.Write(matrix[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static int[,] Swap(int[,] matrix, int num1, int num2, int num)
        {
            for (int i = 0; i < num; ++i)
            {
                int temp = matrix[num1, i];
                matrix[num1, i] = matrix[num2, i];
                matrix[num2, i] = temp;
            }
            return matrix;
        }

        static int[,] BubbleSort(int[,] matrix, int num)
        {
            for (int i = 0; i < num - 1; ++i)
                for (int j = i + 1; j < num; ++j)
                {
                    if (matrix[1, i] < matrix[1, j])
                    {
                        Swap(matrix, j, i, num);
                    }
                }
            return matrix;
        }
    }
}
