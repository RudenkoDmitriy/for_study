﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
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
}
