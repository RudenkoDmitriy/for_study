using System;

namespace LocalNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Network net = new Network("..\\..\\..\\test.txt", RandNext);
            net.Show();
            net.Step();
            net.Step();
            net.Step();
            net.Show();
            Console.ReadKey();
        }

        public static Random rand = new Random();
        public static int RandNext()
        {
            return rand.Next(0, 100);
        }
    }
}
