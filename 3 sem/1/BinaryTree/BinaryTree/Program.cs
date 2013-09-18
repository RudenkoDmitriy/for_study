
namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Add(5);
            tree.Add(6);
            tree.Add(3);
            tree.Add(3);
            tree.Add(78);
            tree.Add(-100);
            tree.Add(232);
            tree.Add(66);
            tree.Add(323);
            tree.Add(7);
            tree.Add(8);
            tree.Add(55);
            foreach (int item in tree)
            {
                System.Console.Write(item);
                System.Console.Write(' ');
            }
            tree.Remove(3);
            tree.Remove(6);
            tree.Remove(323);
            tree.Remove(7);

            System.Console.WriteLine();
            tree.Remove(-100);
            tree.Remove(78);
            int count = 0;
            int[] arr = { -100, 5, 8, 55, 66, 232};
            foreach (int item in tree)
            {
                System.Console.Write(item);
                System.Console.Write(' ');
                count++;
            }
            System.Console.ReadKey();
        }
    }
}
