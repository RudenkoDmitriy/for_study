using System.Collections.Generic;
using System.Linq;

namespace _1
{
    public class Map
    {
        public delegate int ListFunction(int number);

        public static List<int> MapFunc(List<int> list, ListFunction func)
        {
            for (int i = 0; i < list.Count(); ++i)
            {
                list[i] = func(list[i]);
            }

            return list;
        }
    }
}
