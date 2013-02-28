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
            HashTub hashTub = new HashTub();
            hashTub.Add(5);
            hashTub.Add(4);
            hashTub.Add(789);
            hashTub.Remove(4);
            if (hashTub.Find(4))
                Console.Write("no");
            if (hashTub.Find(789))
                Console.Write("yes");
            Console.ReadKey();
        }
    }

    public class ListElement
    {
        public int num;
        public ListElement next;
    }

    public class List
    {
        private ListElement head;
        private int length;

        public List()
        {
            head = new ListElement();
            head.num = 0;
            head.next = null;
            length = 0;
        }

        public void Insert(int value, ListElement pos)
        {
            ListElement temp = new ListElement();
            temp.num = value;
            temp.next = pos.next;
            pos.next = temp;
            ++length;
        }

        public void Remove(ListElement pos)
        {
            ListElement temp = this.head;
            if (this.head.next == null)
                return;
            while (temp.next == null || temp.next != pos)
            {
                temp = temp.next;
            }
            temp.next = pos.next;
            --length;
        }

        public int Length()
        {
            return length;
        }

        public int Retrieve(ListElement pos)
        {
            return pos.num;
        }

        public ListElement Next(ListElement pos)
        {
            return pos.next;
        }

        public ListElement First()
        {
            return this.head;
        }

        public bool Find(int value)
        {
            ListElement pos = this.First();
            while (pos.next != null)
            {
                if (pos.next.num == value)
                    return true;
                pos = pos.next;
            }
            return false;
        }

        public void PrintList()
        {
            ListElement pos = this.First();
            while (pos.next != null)
            {
                Console.Write(Retrieve(pos.next));
                Console.Write(' ');
                pos = pos.next;
            }
            Console.WriteLine();
        }
    }

    class HashTub
    {
        private int  n = 100;
        private List[] list;

        public HashTub()
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
		    while((pos.next != null) || (list[h].Retrieve(pos) != value))
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
