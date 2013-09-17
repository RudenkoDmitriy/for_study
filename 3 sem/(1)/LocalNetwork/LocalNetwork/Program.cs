using System;

namespace LocalNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Network net = new Network("..\\..\\..\\test1.txt");
            net.Show();
            net.Step();
            net.Step();
            net.Step();
            net.Step();
            net.Step();
            net.Show();
            net.Step();
            net.Step();
            net.Step();
            net.Show();
            Console.WriteLine("*********");
            net = new Network("..\\..\\..\\test2.txt");
            net.Show();
            net.Step();
            net.Step();
            net.Step();
            net.Step();
            net.Step();
            net.Show();
            net.Step();
            net.Step();
            net.Step();
            net.Show();
            Console.ReadKey();
        }
    }
}
