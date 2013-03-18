using System;
using System.IO;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            CountTree tree = new CountTree("example_0.txt");
            tree.Print();
            Console.WriteLine();
            Console.WriteLine(tree.Count());
            tree.Root().left.left.Print();
            tree = new CountTree("example_2.txt");
            tree.Print();
            Console.WriteLine();
            Console.WriteLine(tree.Count());
            tree = new CountTree("example_4.txt");
            tree.Print();
            Console.WriteLine();
            Console.WriteLine(tree.Count());
            tree = new CountTree("example_6.txt");
            tree.Print();
            Console.WriteLine();
            Console.WriteLine(tree.Count());
            Console.ReadKey();
        }
    }
}
