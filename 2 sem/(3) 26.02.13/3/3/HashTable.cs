using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class HashTable
    {
        private const int  n = 100;
        private List[] list;

        public HashTable()
        {
            list = new List[n];
            for (int i = 0; i < n; ++i)
            {
                list[i] = new List();
            }

        }

        private int Hash(int value)
        {
            return value % (n + 1);
        }

        public bool Find(int value)
        {
            int h = Hash(value);
            return list[h].Find(value);
        }

        public void Remove(int value)
        {
            int h = Hash(value);
            ListElement pos = list[h].First();
            while ((pos.next != null) || (list[h].Retrieve(pos) != value))
            {
                int temp = list[h].Retrieve(pos);
                pos = list[h].Next(pos);
            }
            if (list[h].Retrieve(pos) == value)
            {
                list[h].Remove(pos);
            }
        }

        public void Add(int value)
        {
            if (!Find(value))
            {
                int h = Hash(value);
                ListElement pos = list[h].First();
                list[h].Insert(value, pos);
            }
        }
    }
}
