using System;

namespace LocalNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Network net = new Network("..\\..\\..\\test.txt", true);
            net.Show();
            net.Step();
            net.Step();
            net.Step();
            net.Show();
            Console.ReadKey();
        }
    }
}
