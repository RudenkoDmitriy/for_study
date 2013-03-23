using System;
using System.IO;

namespace _1
{
    class Program
    {
        static void CounTreeTest(string s)
        {
            CountTree tree = new CountTree(s);
            tree.Print();
            Console.WriteLine();
            Console.WriteLine(tree.Count());
            Console.WriteLine("***************");
        }

        static void Main(string[] args)
        {
            CounTreeTest("../../example_0.txt");
            CounTreeTest("../../example_2.txt");
            CounTreeTest("../../example_3.txt");
            CounTreeTest("../../example_4.txt");
            CounTreeTest("../../example_6.txt");
            CountTree tree = new CountTree("../../example_4.txt");
            tree.Root().Left.Print();
            Console.WriteLine();
            Console.WriteLine(tree.Root().Left.Action());
            Console.ReadKey();
        }
    }
}
