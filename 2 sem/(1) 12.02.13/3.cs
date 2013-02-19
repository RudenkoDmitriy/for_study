using System;

namespace ConsoleApplication1
{
    class Program3
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 23, 54, 3, 45, 67, 46, 23, 99, 8 };
            Console.WriteLine("Before:");
            ShowArr(arr);
            BubbleSort(arr);
            Console.WriteLine("After:");
            ShowArr(arr);
            Console.ReadKey();
        }
        public static void ShowArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write(arr[i]);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; ++i)
                for (int j = i + 1; j < arr.Length; ++j)
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
        }
    }
}
