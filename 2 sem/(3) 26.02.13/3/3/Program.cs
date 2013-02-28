using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable hashTable = new HashTable();
            hashTable.Add(5);
            hashTable.Add(4);
            hashTable.Add(789);
            hashTable.Remove(4);
            if (hashTable.Find(4))
                Console.Write("no");
            if (hashTable.Find(789))
                Console.Write("yes");
            Console.ReadKey();
        }
    }
}
