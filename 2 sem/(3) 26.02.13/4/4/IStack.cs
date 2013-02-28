using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    interface IStack
    {
        void Push(int num);
        int Top();
        int Pop();
    }
}
