using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    public class ListElement
    {
        private int num;

        public int GetNum()
        {
            return num;
        }

        public void SetNum(int num)
        {
            this.num = num;
        }

        private ListElement next;

        public ListElement GetNext()
        {
            return next;
        }

        public void SetNext(ListElement value)
        {
            this.next = value;
        }
    }
}
