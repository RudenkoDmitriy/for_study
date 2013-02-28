using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.Push(7);
            calc.Push(8);
            calc.Push(80);
            calc.Divide();
            Console.WriteLine(calc.Result());
            Console.ReadKey();
        }
    }
}
