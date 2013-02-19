using System;

namespace ConsoleApplication1
{
    struct Bin
    {
        public int i;
        public int j;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of matrix (natural odd number).");
            int n = Convert.ToInt32(Console.ReadLine());
            var matrix = new int[n, n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    matrix[i, j] = i * 10 + j + 10;
                    Console.Write(matrix[i, j]); //для проверки
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            Print(n, matrix);
            Console.ReadKey();
        }

        static Bin Move(Bin temp, int checkMove, int[,] matrix, int n)
        {
            for (int k = 0; k < n; ++k)
            {
                Console.Write(matrix[temp.i, temp.j]);
                Console.Write(' ');
                switch (checkMove)
                {
                    case 1:
                        temp.j++;
                        break;
                    case 2:
                        temp.i++;
                        break;
                    case 3:
                        temp.j--;
                        break;
                    case 4:
                        temp.i--;
                        break;
                }
            }
            return temp;
        }

        static void Print(int n, int[,] matrix)
        {
            if (n == 1)
            {
                Console.WriteLine(matrix[1, 1]);
                return;
            }
            Bin temp;
            temp.i = n / 2;
            temp.j = temp.i;
            int checkMove = 1;
            for (int i = 1; i < n; ++i)
            {
                temp = Move(temp, checkMove, matrix, i);
                ++checkMove;
                if (checkMove > 4)
                {
                    checkMove = checkMove - 4;
                }
                temp = Move(temp, checkMove, matrix, i);
                ++checkMove;
                if (checkMove > 4)
                {
                    checkMove = checkMove - 4;
                }
            }
            temp = Move(temp, checkMove, matrix, n);
        }

    }
}
