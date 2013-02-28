using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            ListElement pos = list.First();
            for (int i = 1; i < 10; ++i)
            {
                list.Insert(i, pos);
                pos = list.Next(pos);
            }
            list.PrintList();
            pos = list.Next(list.First());
            pos = list.Next(pos);
            list.Remove(pos);
            list.PrintList();
            Console.ReadKey();
        }
    }
}
