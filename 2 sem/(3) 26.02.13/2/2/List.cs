using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    public class List
    {
        private ListElement head;
        private int length;

        public List()
        {
            head = new ListElement();
            head.SetNum(0);
            head.SetNext(null);
            length = 0;
        }

        public void Insert(int value, ListElement pos)
        {
            ListElement temp = new ListElement();
            temp.SetNum(value);
            temp.SetNext(pos.GetNext());
            pos.SetNext(temp);
            ++length;
        }

        public void Remove(ListElement pos)
        {
            ListElement temp = this.head;
            if (this.head.GetNext() ==null)
                return;
            while (temp.GetNext() == null || temp.GetNext() != pos)
            {
                temp = temp.GetNext();
            }
            temp.SetNext(pos.GetNext());
            --length;
        }

        public int Length()
        {
            return length;
        }

        public int Retrieve(ListElement pos)
        {
            return pos.GetNum();
        }

        public ListElement Next(ListElement pos)
        {
            return pos.GetNext();
        }

        public ListElement First()
        {
            return this.head;
        }

        public bool Find(int value)
        {
            ListElement pos = this.First();
            while (pos.GetNext() != null)
            {
                if (pos.GetNext().GetNum() == value)
                    return true;
                pos.SetNext(pos.GetNext());
            }
            return false;
        }

        public void PrintList()
        {
            ListElement pos = this.First();
            for (int i = 0; i < length; ++i)
            {
                Console.Write(Retrieve(pos.GetNext()));
                Console.Write(' ');
                pos = pos.GetNext();
            }
            Console.WriteLine();
        }
    }
}
